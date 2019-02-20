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
            this.chkAutoCopy = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnGen = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbTitleGenerate = new MaterialSkin.Controls.MaterialLabel();
            this.lbTitleInfo = new MaterialSkin.Controls.MaterialLabel();
            this.pnCor2 = new System.Windows.Forms.Panel();
            this.pnCor1 = new System.Windows.Forms.Panel();
            this.lbGenInfo = new System.Windows.Forms.Label();
            this.lbAccInfo = new System.Windows.Forms.Label();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.picTA = new System.Windows.Forms.PictureBox();
            this.notif.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTA)).BeginInit();
            this.SuspendLayout();
            // 
            // notif
            // 
            this.notif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.notif.Controls.Add(this.lbAlt);
            this.notif.Location = new System.Drawing.Point(0, 304);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(230, 40);
            this.notif.TabIndex = 0;
            // 
            // lbAlt
            // 
            this.lbAlt.AutoSize = true;
            this.lbAlt.Depth = 0;
            this.lbAlt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAlt.Location = new System.Drawing.Point(5, 11);
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
            this.pnInfo.Controls.Add(this.picHead);
            this.pnInfo.Controls.Add(this.chkAutoCopy);
            this.pnInfo.Controls.Add(this.btnGen);
            this.pnInfo.Controls.Add(this.lbTitleGenerate);
            this.pnInfo.Controls.Add(this.lbTitleInfo);
            this.pnInfo.Controls.Add(this.pnCor2);
            this.pnInfo.Controls.Add(this.pnCor1);
            this.pnInfo.Controls.Add(this.lbGenInfo);
            this.pnInfo.Controls.Add(this.lbAccInfo);
            this.pnInfo.Location = new System.Drawing.Point(13, 118);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(473, 163);
            this.pnInfo.TabIndex = 5;
            this.pnInfo.Visible = false;
            // 
            // chkAutoCopy
            // 
            this.chkAutoCopy.AutoSize = true;
            this.chkAutoCopy.Depth = 0;
            this.chkAutoCopy.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAutoCopy.Location = new System.Drawing.Point(311, 115);
            this.chkAutoCopy.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutoCopy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutoCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutoCopy.Name = "chkAutoCopy";
            this.chkAutoCopy.Ripple = true;
            this.chkAutoCopy.Size = new System.Drawing.Size(90, 30);
            this.chkAutoCopy.TabIndex = 5;
            this.chkAutoCopy.Text = "AutoCopy";
            this.chkAutoCopy.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.AutoSize = true;
            this.btnGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGen.Depth = 0;
            this.btnGen.Icon = null;
            this.btnGen.Location = new System.Drawing.Point(186, 111);
            this.btnGen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGen.Name = "btnGen";
            this.btnGen.Primary = false;
            this.btnGen.Size = new System.Drawing.Size(121, 36);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate Alt!";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
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
            this.lbTitleGenerate.Size = new System.Drawing.Size(136, 18);
            this.lbTitleGenerate.TabIndex = 1;
            this.lbTitleGenerate.Text = "Generate Accounts";
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
            // pnCor2
            // 
            this.pnCor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.pnCor2.Location = new System.Drawing.Point(174, 17);
            this.pnCor2.Name = "pnCor2";
            this.pnCor2.Size = new System.Drawing.Size(5, 130);
            this.pnCor2.TabIndex = 0;
            // 
            // pnCor1
            // 
            this.pnCor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.pnCor1.Location = new System.Drawing.Point(17, 40);
            this.pnCor1.Name = "pnCor1";
            this.pnCor1.Size = new System.Drawing.Size(5, 72);
            this.pnCor1.TabIndex = 0;
            // 
            // lbGenInfo
            // 
            this.lbGenInfo.AutoSize = true;
            this.lbGenInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenInfo.ForeColor = System.Drawing.Color.White;
            this.lbGenInfo.Location = new System.Drawing.Point(265, 48);
            this.lbGenInfo.Name = "lbGenInfo";
            this.lbGenInfo.Size = new System.Drawing.Size(110, 45);
            this.lbGenInfo.TabIndex = 3;
            this.lbGenInfo.Text = "User:\r\nToken:\r\nPassword: anything";
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
            // picStatus
            // 
            this.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStatus.Image = global::TAccountGen.Properties.Resources.status;
            this.picStatus.Location = new System.Drawing.Point(404, 12);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(24, 24);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStatus.TabIndex = 8;
            this.picStatus.TabStop = false;
            this.picStatus.Click += new System.EventHandler(this.picStatus_Click);
            // 
            // picGithub
            // 
            this.picGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.Location = new System.Drawing.Point(434, 12);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(24, 24);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGithub.TabIndex = 7;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
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
            // picHead
            // 
            this.picHead.Location = new System.Drawing.Point(188, 40);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(64, 64);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHead.TabIndex = 6;
            this.picHead.TabStop = false;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.picGithub);
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
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
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
        private System.Windows.Forms.Panel pnCor2;
        private System.Windows.Forms.PictureBox picHead;
        private MaterialSkin.Controls.MaterialCheckBox chkAutoCopy;
        private MaterialSkin.Controls.MaterialFlatButton btnGen;
        private System.Windows.Forms.Label lbGenInfo;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox picStatus;
    }
}

