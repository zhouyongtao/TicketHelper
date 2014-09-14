﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace TicketHelper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(login._loginName));
            }

            //Application.Run(new MainForm());
        }
    }
}
