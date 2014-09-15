using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketHelper.Ticket;

namespace TicketHelper
{
    public partial class ChkVerifyForm : Form
    {
        public ChkVerifyForm()
        {
            InitializeComponent();
        }

        public Image img;
        async private void ChkVerifyForm_Load(object sender, EventArgs e)
        {
            img = await TicketHandler.LoginInitAndGetloginVcode(IsFirst: true);
            //初始化配置并加载验证码
            this.pbImg.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bitmap = (Bitmap)img;

        }

        async private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 200; i++)
            {
                img = await TicketHandler.LoginInitAndGetloginVcode();
                using (var bitmap = (Bitmap)img)
                {
                    bitmap.Save(System.Environment.CurrentDirectory + "\\verify\\img_" + i + ".png");
                }
            }
        }
    }
}
