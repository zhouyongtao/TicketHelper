using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TicketHelper.Ticket;
using TicketHelper.Model;

namespace TicketHelper
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string loginName)
        {
            InitializeComponent();
            this.HelpButtonText = "当前用户：" + loginName;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //加载城市
            this.cmbStart.ItemHeight = 20;
            this.cmbStart.DisplayMember = "CityName";
            this.cmbStart.ValueMember = "CityCode";
            this.cmbStart.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStart.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStart.DataSource = CityHandler.GetCityData();
            this.cmbStart.Text = "上海";
            this.cmbEnd.ItemHeight = 20;
            this.cmbEnd.DisplayMember = "CityName";
            this.cmbEnd.ValueMember = "CityCode";
            this.cmbEnd.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbEnd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbEnd.DataSource = CityHandler.GetCityData();
            this.cmbEnd.Text = "明光";

            //加载菜单
            for (int i = 0; i < 7; i++)
            {
                this.tbstripMenu.Tabs.Add(new TabItem()
                {
                    Text = WeekDayHandler.GetWeekDayDetail(DateTime.Now.AddDays(i))
                });
            }

        }


        /// <summary>
        /// 查询车次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.dtBookTicketDate.Text.IsEmpty() || this.cmbStart.SelectedValue.IsNull() || this.cmbEnd.SelectedValue.IsNull()) return;
            var data = await TicketHandler.queryleftTicket(Convert.ToDateTime((this.dtBookTicketDate.Text)).ToString("yyyy-MM-dd"), this.cmbStart.SelectedValue.ToString(), this.cmbEnd.SelectedValue.ToString());
            this.Activate();
        }

        private void lblChangeStation_Click(object sender, EventArgs e)
        {
            if (this.cmbStart.SelectedValue.IsNull() || this.cmbEnd.SelectedValue.IsNull()) return;
            string temp = this.cmbStart.Text;
            this.cmbStart.Text = this.cmbEnd.Text;
            this.cmbEnd.Text = temp;
        }
    }
}