using MaterialSkin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Transitions;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace TAccountGen
{
    public partial class MainWindow : Form
    {
        #region "Events"
        public MainWindow()
        {
            InitializeComponent();
            // idk thats gay for me.
            CheckForIllegalCrossThreadCalls = false;
            // materialgaymanager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green600, Accent.Green700, TextShade.WHITE);
            // hide the notification panel whoa how COOL!
            notif.Location = new Point(notif.Location.X - 238, notif.Location.Y);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Yeah that's json.
            var version = JsonConvert.DeserializeObject<VersionAPI>(Get(versionapi));
            lbVersion.Text = string.Format("{0}" + version.protocol_text, "v");
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "generator-auth-token")))
            {
                    Match match = rgx.Match(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "generator-auth-token")));
                    if (match.Success) { txtApiKey.Text = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "generator-auth-token")); }
            }
        }
        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
            Match match = rgx.Match(txtApiKey.Text);
            if (match.Success)
            {
                Notification("Loading Information..", 1500);
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "generator-auth-token"), match.Value);
                switch (Get(string.Format(licenseapi + "{0}", match.Value)))
                {
                    // Huh?
                    case "Unauthorized":
                        Notification("API Error: Unauthorized (API Key Invalid)", 4000);
                        return;
                    case "Forbidden":
                        Notification("API Error: Forbidden", 4000);
                        return;
                    case "NotFound":
                        Notification("API Error: Not Found", 4000);
                        return;
                    case "InternalServerError":
                        Notification("API Error: Internal Server Error", 4000);
                        return;
                }
                var license = JsonConvert.DeserializeObject<LicenseAPI>(Get(string.Format(licenseapi + "{0}", match.Value)));
                if (license.premium == false)
                {
                    // I don't think that this error will ever show up.
                    Notification("Account is not premium!", 4000);
                    return;
                }
                pnInfo.Visible = true;
                plan = license.premium_name;
                // Info from the license API.
                lbAccInfo.Text = string.Format("User: {0}\nPlan: {1}\nExpires in: {2}", license.username, license.premium_name.ToUpper(), license.expires);
            }
            else
            {
                pnInfo.Visible = false;
            }
        }
        [STAThread]
        public void test()
        {
            Match match = rgx.Match(txtApiKey.Text);

            switch (Get(string.Format(genapi + "{0}", match.Value)))
            {
                case "Unauthorized":
                    // Either the API Token was not provided or is invalid. To learn how to get and include your API Token in the request please refer to the Authorization section.
                    Notification("API Error: Unauthorized (API Key Invalid)", 4000);
                    return;
                case "Forbidden":
                    // The api token provided is not able to access the requested endpoint. E.g: free customer attempts to access /generate.
                    Notification("API Error: Forbidden", 4000);
                    return;
                case "NotFound":
                    // The requested endpoint does not exist. If you get this error make sure you didn't misspell the endpoint.
                    Notification("API Error: Not Found", 4000);
                    return;
                case "InternalServerError":
                    // Our servers encountered and unexpected error, try again later.
                    Notification("API Error: Internal Server Error", 4000);
                    return;
            }

            var geninfo = JsonConvert.DeserializeObject<GenerateAPI>(Get(string.Format(genapi + "{0}", match.Value)));
            if (geninfo.limit == true)
            {
                Notification("API Is Limited!", 2000);
                return;
            }
            // Checks for premium plan. If it's premium it'll show a cape whether or not exists
            if (plan == "premium")
            {
                lbGenInfo.Location = new Point(lbGenInfo.Location.X, lbGenInfo.Location.Y - 6);
                lbGenInfo.Text = string.Format("User: {0}\nToken: {1}\nPassword: anything\nCape:{2}", geninfo.username, geninfo.token, geninfo.cape);
                Notification(string.Format("Alt: {0} Generated!", geninfo.username), 3000);
                // Loads skin if it exists.
                picHead.Load(string.Format("https://crafatar.com/avatars/{0}?size=64?overlay=true", geninfo.skin));
                if (chkAutoCopy.Checked)
                {
                    // Sets token:pass to the clipboard.
                    Clipboard.SetText(string.Format("{0}:{1}", geninfo.token, "anything"));
                }
                return;
            }
            lbGenInfo.Location = new Point(lbGenInfo.Location.X, 48);
            Notification(string.Format("Alt: {0} Generated!", geninfo.username), 3000);
            lbGenInfo.Text = string.Format("User:{0}\nToken:{1}\nPassword: anything", geninfo.username, geninfo.token);
            // That's slowwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww w  w         w               w                                   w                             w uh?? hello? w                                                w
            picHead.Load(string.Format("https://crafatar.com/avatars/{0}?size=64?overlay=true", geninfo.skin));
            if (chkAutoCopy.Checked)
            {
                Invoke((Action)(() => { Clipboard.SetText(string.Format("{0}:{1}", geninfo.token, "anything")); }));
            }
        }
        private void btnGen_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(test)) { IsBackground = true }.Start();
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Bye!
            Environment.Exit(0);
        }
        private void picGithub_Click(object sender, EventArgs e)
        {
            // Annoying
            Process.Start("https://github.com/b1scoito/TheAltening-Account-Generator");
        }
        private void picStatus_Click(object sender, EventArgs e)
        {
            // Yeah?
            var getstatus = JsonConvert.DeserializeObject<StatusROOT>(Get(statusapi));
            MessageBox.Show(string.Format("Authentication Servers: {0}\nSession Server: {1}\nWebsite: {2}\nChecker: {3}", getstatus.status.authentication, getstatus.status.sessions, getstatus.status.website, getstatus.status.checker), "TheAltening Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        // Utils (Too lazy to create an class)
        #region "Shadow"
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled) cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS() { bottomHeight = 1, leftWidth = 0, rightWidth = 0, topHeight = 0 };
                        DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                default: break;
            }
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region "Strings n Shit"
        public static string versionapi = "http://api.thealtening.com/app/version";
        public static string statusapi = "http://api.thealtening.com/status";
        public static string licenseapi = "http://api.thealtening.com/v1/license?token=";
        public static string genapi = "http://api.thealtening.com/v1/generate?token=";
        public static string plan;
        static Regex rgx = new Regex(@"^(api)-([A-Z0-9a-z]{4})-([A-Z0-9a-z]{4})-([A-Z0-9a-z]{4})$");
        static Regex b64 = new Regex(@"^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$");
        public static string extstatuscode;
        #endregion
        #region "Utils"
        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            try
            {

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {

                HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
                switch (errorResponse.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        extstatuscode = "Unauthorized";
                        break;
                    case HttpStatusCode.Forbidden:
                        extstatuscode = "Forbidden";
                        break;
                    case HttpStatusCode.NotFound:
                        extstatuscode = "Not Found";
                        break;
                    case HttpStatusCode.InternalServerError:
                        extstatuscode = "Internal Server Error";
                        break;
                }
                return extstatuscode;

            }
        }
        private async Task Wait(int ms)
        {
            await Task.Delay(ms);
        }
        private async void Notification(string msg, int delay)
        {
            Transition.run(notif, "Left", 0, new TransitionType_Acceleration(350));
            lbAlt.Text = msg;
            await Wait(delay);
            Transition.run(notif, "Left", -238, new TransitionType_Acceleration(350));
        }
        #endregion
        #region "JsonClasses"
        public class VersionAPI
        {
            public int protocol { get; set; }
            public string protocol_text { get; set; }
            public string update_message { get; set; }
            public string url_download { get; set; }
            public string url_showcase { get; set; }
        }
        public class LicenseAPI
        {
            public string username { get; set; }
            public bool premium { get; set; }
            public string premium_name { get; set; }
            public string expires { get; set; }
        }
        public class GenerateAPI
        {
            public string token { get; set; }
            public string username { get; set; }
            public string expires { get; set; }
            public bool limit { get; set; }
            public string skin { get; set; }
            public string cape { get; set; }
            public string password { get; set; }
        }
        public class Endpoints
        {
            public string server_authentication { get; set; }
            public string server_session { get; set; }
        }
        public class StatusAPI
        {
            public string authentication { get; set; }
            public string sessions { get; set; }
            public string website { get; set; }
            public string checker { get; set; }
        }
        public class StatusROOT
        {
            public Endpoints endpoints { get; set; }
            public StatusAPI status { get; set; }
        }
        #endregion

    }
}
