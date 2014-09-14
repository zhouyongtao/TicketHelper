namespace TicketHelper
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPwd = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.txtVerifyNo = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblNoAccountNo = new System.Windows.Forms.LinkLabel();
            this.cbxRemMe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblRefreshVerifyCode = new System.Windows.Forms.LinkLabel();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.refImgCode = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Name = "labelX1";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPwd.BackgroundStyle.Class = "TextBoxBorder";
            this.txtPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPwd.ButtonClear.Visible = true;
            this.txtPwd.ForeColor = System.Drawing.Color.Black;
            this.txtPwd.HidePromptOnLeave = true;
            resources.ApplyResources(this.txtPwd, "txtPwd");
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtName.BackgroundStyle.Class = "TextBoxBorder";
            this.txtName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.ButtonDropDown.Visible = true;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // superTooltip
            // 
            resources.ApplyResources(this.superTooltip, "superTooltip");
            this.superTooltip.ShowTooltipForFocusedControl = false;
            // 
            // txtVerifyNo
            // 
            this.txtVerifyNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVerifyNo.BackgroundStyle.Class = "TextBoxBorder";
            this.txtVerifyNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVerifyNo.ButtonClear.Visible = true;
            this.txtVerifyNo.ForeColor = System.Drawing.Color.Black;
            this.txtVerifyNo.HidePromptOnLeave = true;
            resources.ApplyResources(this.txtVerifyNo, "txtVerifyNo");
            this.txtVerifyNo.Name = "txtVerifyNo";
            this.txtVerifyNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtVerifyNo.TextChanged += new System.EventHandler(this.txtVerifyNo_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Name = "labelX2";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Name = "labelX3";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Name = "labelX4";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblNoAccountNo
            // 
            resources.ApplyResources(this.lblNoAccountNo, "lblNoAccountNo");
            this.lblNoAccountNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNoAccountNo.ForeColor = System.Drawing.Color.Black;
            this.lblNoAccountNo.Name = "lblNoAccountNo";
            this.lblNoAccountNo.TabStop = true;
            this.lblNoAccountNo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNoAccountNo_LinkClicked);
            // 
            // cbxRemMe
            // 
            this.cbxRemMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cbxRemMe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRemMe.Checked = true;
            this.cbxRemMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRemMe.CheckValue = "Y";
            resources.ApplyResources(this.cbxRemMe, "cbxRemMe");
            this.cbxRemMe.ForeColor = System.Drawing.Color.Black;
            this.cbxRemMe.Name = "cbxRemMe";
            this.cbxRemMe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxRemMe.TextColor = System.Drawing.Color.DimGray;
            // 
            // lblRefreshVerifyCode
            // 
            resources.ApplyResources(this.lblRefreshVerifyCode, "lblRefreshVerifyCode");
            this.lblRefreshVerifyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRefreshVerifyCode.ForeColor = System.Drawing.Color.Black;
            this.lblRefreshVerifyCode.Name = "lblRefreshVerifyCode";
            this.lblRefreshVerifyCode.TabStop = true;
            this.lblRefreshVerifyCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefreshVerifyCode_LinkClicked);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            resources.ApplyResources(this.reflectionImage1, "reflectionImage1");
            this.reflectionImage1.Name = "reflectionImage1";
            // 
            // refImgCode
            // 
            this.refImgCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.refImgCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refImgCode.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.refImgCode.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.refImgCode, "refImgCode");
            this.refImgCode.Name = "refImgCode";
            this.refImgCode.ReflectionEnabled = false;
            this.refImgCode.Click += new System.EventHandler(this.refImgCode_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refImgCode);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.lblRefreshVerifyCode);
            this.Controls.Add(this.cbxRemMe);
            this.Controls.Add(this.lblNoAccountNo);
            this.Controls.Add(this.txtVerifyNo);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButtonVisible = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtPwd;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown txtName;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtVerifyNo;
        private System.Windows.Forms.LinkLabel lblNoAccountNo;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRemMe;
        private System.Windows.Forms.LinkLabel lblRefreshVerifyCode;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ReflectionImage refImgCode;
    }
}