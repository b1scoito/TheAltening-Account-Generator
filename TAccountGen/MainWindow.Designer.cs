namespace TAccountGen
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notif = new System.Windows.Forms.Panel();
            this.lbAlt = new MaterialSkin.Controls.MaterialLabel();
            this.lbTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.txtApiKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.pnCor1 = new System.Windows.Forms.Panel();
            this.lbTitleInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lbAccInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.picTA = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitleGenerate = new MaterialSkin.Controls.MaterialLabel();
            this.notif.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTA)).BeginInit();
            this.SuspendLayout();
            // 
            // notif
            // 
            this.notif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.notif.Controls.Add(this.lbAlt);
            this.notif.Location = new System.Drawing.Point(0, 300);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(231, 40);
            this.notif.TabIndex = 0;
            // 
            // lbAlt
            // 
            this.lbAlt.AutoSize = true;
            this.lbAlt.Depth = 0;
            this.lbAlt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAlt.Location = new System.Drawing.Point(5, 7);
            this.lbAlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAlt.Name = "lbAlt";
            this.lbAlt.Size = new System.Drawing.Size(152, 18);
            this.lbAlt.TabIndex = 1;
            this.lbAlt.Text = "Alt: AnAlt! Generated!";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Depth = 0;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(73, 23);
            this.lbTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(218, 18);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "TheAltening Account Generator";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(77, 46);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(35, 15);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "v0.x.x";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Depth = 0;
            this.txtApiKey.Hint = "Your API Key";
            this.txtApiKey.Location = new System.Drawing.Point(13, 90);
            this.txtApiKey.MaxLength = 32767;
            this.txtApiKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.PasswordChar = '\0';
            this.txtApiKey.SelectedText = "";
            this.txtApiKey.SelectionLength = 0;
            this.txtApiKey.SelectionStart = 0;
            this.txtApiKey.Size = new System.Drawing.Size(163, 23);
            this.txtApiKey.TabIndex = 4;
            this.txtApiKey.TabStop = false;
            this.txtApiKey.UseSystemPasswordChar = false;
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnInfo.Controls.Add(this.lbTitleGenerate);
            this.pnInfo.Controls.Add(this.lbTitleInfo);
            this.pnInfo.Controls.Add(this.panel1);
            this.pnInfo.Controls.Add(this.pnCor1);
            this.pnInfo.Controls.Add(this.lbAccInfo);
            this.pnInfo.Location = new System.Drawing.Point(14, 126);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(473, 163);
            this.pnInfo.TabIndex = 5;
            this.pnInfo.Visible = false;
            // 
            // pnCor1
            // 
            this.pnCor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.pnCor1.Location = new System.Drawing.Point(17, 40);
            this.pnCor1.Name = "pnCor1";
            this.pnCor1.Size = new System.Drawing.Size(5, 72);
            this.pnCor1.TabIndex = 0;
            // 
            // lbTitleInfo
            // 
            this.lbTitleInfo.AutoSize = true;
            this.lbTitleInfo.Depth = 0;
            this.lbTitleInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTitleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitleInfo.Location = new System.Drawing.Point(26, 40);
            this.lbTitleInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitleInfo.Name = "lbTitleInfo";
            this.lbTitleInfo.Size = new System.Drawing.Size(94, 18);
            this.lbTitleInfo.TabIndex = 1;
            this.lbTitleInfo.Text = "Account Info";
            // 
            // lbAccInfo
            // 
            this.lbAccInfo.AutoSize = true;
            this.lbAccInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccInfo.ForeColor = System.Drawing.Color.White;
            this.lbAccInfo.Location = new System.Drawing.Point(26, 63);
            this.lbAccInfo.Name = "lbAccInfo";
            this.lbAccInfo.Size = new System.Drawing.Size(56, 45);
            this.lbAccInfo.TabIndex = 3;
            this.lbAccInfo.Text = "User:\r\nPlan:\r\nExpires in";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::TAccountGen.Properties.Resources.fechar;
            this.btnClose.Location = new System.Drawing.Point(464, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picTA
            // 
            this.picTA.Image = global::TAccountGen.Properties.Resources.icon;
            this.picTA.Location = new System.Drawing.Point(15, 17);
            this.picTA.Name = "picTA";
            this.picTA.Size = new System.Drawing.Size(52, 50);
            this.picTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTA.TabIndex = 1;
            this.picTA.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Location = new System.Drawing.Point(174, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 130);
            this.panel1.TabIndex = 0;
            // 
            // lbTitleGenerate
            // 
            this.lbTitleGenerate.AutoSize = true;
            this.lbTitleGenerate.Depth = 0;
            this.lbTitleGenerate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTitleGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitleGenerate.Location = new System.Drawing.Point(185, 17);
            this.lbTitleGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitleGenerate.Name = "lbTitleGenerate";
            this.lbTitleGenerate.Size = new System.Drawing.Size(136, 19);
            this.lbTitleGenerate.TabIndex = 1;
            this.lbTitleGenerate.Text = "Generate Accounts";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.picTA);
            this.Controls.Add(this.notif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheAltening - Account Generator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.notif.ResumeLayout(false);
            this.notif.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel notif;
        private MaterialSkin.Controls.MaterialLabel lbAlt;
        private System.Windows.Forms.PictureBox picTA;
        private MaterialSkin.Controls.MaterialLabel lbTitle;
        private System.Windows.Forms.Label lbVersion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApiKey;
        private System.Windows.Forms.Panel pnInfo;
        private MaterialSkin.Controls.MaterialLabel lbTitleInfo;
        private System.Windows.Forms.Panel pnCor1;
        private System.Windows.Forms.Label lbAccInfo;
        private System.Windows.Forms.PictureBox btnClose;
        private MaterialSkin.Controls.MaterialLabel lbTitleGenerate;
        private System.Windows.Forms.Panel panel1;
    }
}

