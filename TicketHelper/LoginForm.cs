using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using NLog;
using TicketHelper.Ticket;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using TicketHelper.Helper;
using TicketHelper.Helper.Encrypt;

namespace TicketHelper
{
    public partial class LoginForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public string _loginName;
        public LoginForm()
        {
            InitializeComponent();
        }

        async private void LoginForm_Load(object sender, EventArgs e)
        {
            //���ü�¼������ʾ��Ϣ
            this.superTooltip.SetSuperTooltip(this.cbxRemMe, new SuperTooltipInfo("", "", @"��˵��ס,��������Ʊ�ɹ�", null, null, eTooltipColor.Lemon));
            this.superTooltip.Enabled = true;
            //ע���¼�
            this.HelpButtonClick += LoginForm_HelpButtonClick;
            this.btnLogin.Click += btnLogin_Click;
            //�����û���������
            string filePath = Environment.CurrentDirectory + "\\data\\account.data";
            if (File.Exists(filePath))
            {
                var loginData = DESEncrypt.Decrypt(File.ReadAllText(filePath));
                if (!loginData.IsEmpty() && loginData.Contains("@") && loginData.Split("@").Length == 2)
                {
                    this.txtName.Text = loginData.Split("@")[0];
                    this.txtPwd.Text = loginData.Split("@")[1];
                    this.txtVerifyNo.Focus();
                }
            }

            //��ʼ�����ò�������֤��
            this.refImgCode.Image = await TicketHandler.LoginInitAndGetloginVcode(IsFirst: true);
        }


        /// <summary>
        /// �û���½
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnLogin_Click(object sender, EventArgs e)
        {
            #region ��֤���ݸ�ʽ
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                this.txtName.FocusHighlightEnabled = true;
                this.txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPwd.Text) || this.txtPwd.Text.Trim().Length < 6)
            {
                this.txtPwd.FocusHighlightEnabled = true;
                this.txtPwd.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtVerifyNo.Text) || this.txtVerifyNo.TextLength != 4)
            {
                this.txtVerifyNo.FocusHighlightEnabled = true;
                this.txtVerifyNo.Focus();
                return;
            }
            #endregion

            //this.btnLogin.Enabled = false;
            //this.btnLogin.Text = "���Ժ�...";
            // this.Enabled = false;
        }
        async private void txtVerifyNo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtVerifyNo.TextLength != 4 || this.txtPwd.Text.Trim().Length < 6 || string.IsNullOrEmpty(this.txtName.Text)) return;
            //��֤��֤���Ƿ���ȷ
            /*
            bool h = await TicketHandler.ChkVerifyCodeAnsyn(this.txtVerifyNo.Text);
            if (!h)
            {
                this.txtVerifyNo.FocusHighlightColor = Color.Red;
                this.txtVerifyNo.FocusHighlightEnabled = true;
                this.txtVerifyNo.Focus();
                return;
                //  this.superTooltip.SetSuperTooltip(this.txtVerifyNo, new SuperTooltipInfo("", "", @"��֤����󣬻������ưɣ�", null, null, eTooltipColor.Lemon));
                //this.superTooltip.ShowTooltipImmediately = false;
            }
             */
            bool loginIn = await TicketHandler.loginVerifyLogin(this.txtName.Text.Trim(), this.txtPwd.Text.Trim(), this.txtVerifyNo.Text.Trim());
            if (!loginIn)
            {
                //������ʱ���Ż�һ��
                this.txtPwd.FocusHighlightColor = Color.Red;
                this.txtPwd.FocusHighlightEnabled = true;
                this.txtPwd.Focus();
                return;
            }
            _loginName = this.txtName.Text;
            if (this.cbxRemMe.Checked)
            {
                try
                {
                    //��ס�û���������
                    var loginData = DESEncrypt.Encrypt(this.txtName.Text + "@" + this.txtPwd.Text);
                    string dirPath = Directory.GetCurrentDirectory() + "\\data";
                    if (!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                    }
                    string filePath = dirPath + "\\account.data";
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    using (var writer = new StreamWriter(filePath, false, Encoding.Default))
                    {
                        writer.Write(loginData);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        # region  ˢ����֤��
        /// <summary>
        /// ˢ����֤��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void lblRefreshVerifyCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.refImgCode.Image = await TicketHandler.LoginInitAndGetloginVcode();
        }
        async private void refImgCode_Click(object sender, EventArgs e)
        {
            this.refImgCode.Image = await TicketHandler.LoginInitAndGetloginVcode();
        }
        #endregion


        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LoginForm_HelpButtonClick(object sender, EventArgs e)
        {
            this.HelpButtonText = "I'am Irving O(��_��)O~~";
        }

        /// <summary>
        /// û���˺�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNoAccountNo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kyfw.12306.cn/otn/regist/init");
        }
    }
}