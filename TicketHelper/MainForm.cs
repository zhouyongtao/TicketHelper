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
        private string _loginName;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string loginName)
        {
            InitializeComponent();
            _loginName = loginName;
            this.HelpButtonText = "��ǰ�û���" + _loginName;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //���س���
            this.cmbStart.DisplayMember = "CityName";
            this.cmbStart.ValueMember = "CityCode";
            this.cmbStart.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStart.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStart.DataSource = CityHandler.GetCityData();
            this.cmbStart.Text = "�Ϻ�";

            this.cmbEnd.DisplayMember = "CityName";
            this.cmbEnd.ValueMember = "CityCode";
            this.cmbEnd.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbEnd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbEnd.DataSource = CityHandler.GetCityData();
            this.cmbEnd.Text = "����";

        }
        /// <summary>
        /// ��ѯ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.dtBookTicketDate.Text.IsEmpty() || this.cmbStart.SelectedValue.IsNull() || this.cmbEnd.SelectedValue.IsNull()) return;
            var data = await TicketHandler.queryleftTicket(Convert.ToDateTime((this.dtBookTicketDate.Text)).ToString("yyyy-MM-dd"), this.cmbStart.SelectedValue.ToString(), this.cmbEnd.SelectedValue.ToString());
        }
    }
}