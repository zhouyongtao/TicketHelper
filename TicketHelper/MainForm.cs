using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TicketHelper.Ticket;

namespace TicketHelper
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {      //加载城市


            this.cmbStart.DisplayMember = "CityName";
            this.cmbStart.ValueMember = "CityCode";
            this.cmbStart.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStart.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStart.DataSource = CityHandler.GetCityData();
            this.cmbStart.Text = "上海";

            this.cmbEnd.DisplayMember = "CityName";
            this.cmbEnd.ValueMember = "CityCode";
            this.cmbEnd.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbEnd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbEnd.DataSource = CityHandler.GetCityData();
            this.cmbEnd.Text = "北京";

        }
        /// <summary>
        /// 查询车次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}