namespace TicketHelper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.superGridViewForTicket = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblitem = new DevComponents.DotNetBar.LabelItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblChangeStation = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtBookTicketDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cmbEnd = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbStart = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbstripMenu = new DevComponents.DotNetBar.TabStrip();
            this.谢谢 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem2 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem3 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem4 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem5 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem6 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem7 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem8 = new DevComponents.DotNetBar.CheckBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtBookTicketDate)).BeginInit();
            this.SuspendLayout();
            // 
            // superGridViewForTicket
            // 
            this.superGridViewForTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridViewForTicket.BackColor = System.Drawing.Color.White;
            this.superGridViewForTicket.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridViewForTicket.ForeColor = System.Drawing.Color.Black;
            this.superGridViewForTicket.Location = new System.Drawing.Point(-2, 121);
            this.superGridViewForTicket.Name = "superGridViewForTicket";
            this.superGridViewForTicket.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal;
            this.superGridViewForTicket.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.superGridViewForTicket.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGridViewForTicket.Size = new System.Drawing.Size(1049, 400);
            this.superGridViewForTicket.TabIndex = 3;
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblitem});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 517);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1046, 16);
            this.metroStatusBar1.TabIndex = 5;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // lblitem
            // 
            this.lblitem.Name = "lblitem";
            this.lblitem.Text = "Ready";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(46, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 25);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.SeaGreen;
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "上车站 :";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(330, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 25);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.Color.Peru;
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "到达站 :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblChangeStation
            // 
            this.lblChangeStation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblChangeStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblChangeStation.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeStation.ForeColor = System.Drawing.Color.Black;
            this.lblChangeStation.Location = new System.Drawing.Point(293, 27);
            this.lblChangeStation.Name = "lblChangeStation";
            this.lblChangeStation.Size = new System.Drawing.Size(32, 25);
            this.lblChangeStation.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.lblChangeStation.Symbol = "";
            this.lblChangeStation.SymbolColor = System.Drawing.Color.LightSeaGreen;
            this.lblChangeStation.TabIndex = 12;
            this.lblChangeStation.Click += new System.EventHandler(this.lblChangeStation_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(583, 27);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 25);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX4.Symbol = "";
            this.labelX4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "日期 :";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtBookTicketDate
            // 
            this.dtBookTicketDate.AllowEmptyState = false;
            this.dtBookTicketDate.AutoAdvance = true;
            this.dtBookTicketDate.AutoOverwrite = false;
            this.dtBookTicketDate.AutoSelectDate = true;
            this.dtBookTicketDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtBookTicketDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBookTicketDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBookTicketDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBookTicketDate.ButtonDropDown.Visible = true;
            this.dtBookTicketDate.DefaultInputValues = false;
            this.dtBookTicketDate.DisabledBackColor = System.Drawing.Color.Gray;
            this.dtBookTicketDate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtBookTicketDate.ForeColor = System.Drawing.Color.Black;
            this.dtBookTicketDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dtBookTicketDate.InputMouseWheelEnabled = false;
            this.dtBookTicketDate.IsPopupCalendarOpen = false;
            this.dtBookTicketDate.Location = new System.Drawing.Point(684, 30);
            // 
            // 
            // 
            this.dtBookTicketDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBookTicketDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBookTicketDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtBookTicketDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBookTicketDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBookTicketDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.dtBookTicketDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBookTicketDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBookTicketDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBookTicketDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBookTicketDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBookTicketDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBookTicketDate.MonthCalendar.TodayButtonVisible = true;
            this.dtBookTicketDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBookTicketDate.Name = "dtBookTicketDate";
            this.dtBookTicketDate.Size = new System.Drawing.Size(120, 22);
            this.dtBookTicketDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBookTicketDate.TabIndex = 17;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(820, 28);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(163, 26);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.Symbol = "";
            this.btnQuery.SymbolColor = System.Drawing.Color.Teal;
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbEnd
            // 
            this.cmbEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEnd.DisplayMember = "Text";
            this.cmbEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEnd.ForeColor = System.Drawing.Color.Black;
            this.cmbEnd.FormattingEnabled = true;
            this.cmbEnd.ItemHeight = 20;
            this.cmbEnd.Location = new System.Drawing.Point(447, 28);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.PreventEnterBeep = true;
            this.cmbEnd.Size = new System.Drawing.Size(121, 26);
            this.cmbEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEnd.TabIndex = 20;
            // 
            // cmbStart
            // 
            this.cmbStart.DisplayMember = "Text";
            this.cmbStart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStart.ForeColor = System.Drawing.Color.Black;
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.ItemHeight = 20;
            this.cmbStart.Location = new System.Drawing.Point(162, 28);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.PreventEnterBeep = true;
            this.cmbStart.Size = new System.Drawing.Size(121, 26);
            this.cmbStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStart.TabIndex = 21;
            // 
            // tbstripMenu
            // 
            this.tbstripMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbstripMenu.AutoSelectAttachedControl = true;
            this.tbstripMenu.CanReorderTabs = true;
            this.tbstripMenu.CloseButtonVisible = true;
            this.tbstripMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbstripMenu.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstripMenu.ForeColor = System.Drawing.Color.Black;
            this.tbstripMenu.Location = new System.Drawing.Point(0, 95);
            this.tbstripMenu.Name = "tbstripMenu";
            this.tbstripMenu.SelectedTab = this.tabItem4;
            this.tbstripMenu.SelectedTabFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.tbstripMenu.Size = new System.Drawing.Size(1046, 27);
            this.tbstripMenu.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tbstripMenu.TabIndex = 22;
            this.tbstripMenu.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tbstripMenu.Tabs.Add(this.谢谢);
            this.tbstripMenu.Tabs.Add(this.tabItem2);
            this.tbstripMenu.Tabs.Add(this.tabItem3);
            this.tbstripMenu.Tabs.Add(this.tabItem4);
            this.tbstripMenu.Text = "tabStrip1";
            // 
            // 谢谢
            // 
            this.谢谢.Name = "谢谢";
            this.谢谢.Text = " 2015-05-10  星期一";
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = " 2015-05-10  星期二";
            // 
            // tabItem3
            // 
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = " 2015-05-10  星期三";
            // 
            // tabItem4
            // 
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = " 2015-05-10  星期四";
            // 
            // metroToolbar1
            // 
            this.metroToolbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToolbar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar1.ContainerControlProcessDialogKey = true;
            this.metroToolbar1.DragDropSupport = true;
            this.metroToolbar1.ExpandButtonVisible = false;
            this.metroToolbar1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.metroToolbar1.ForeColor = System.Drawing.Color.Black;
            this.metroToolbar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.checkBoxItem1,
            this.checkBoxItem2,
            this.checkBoxItem3,
            this.checkBoxItem4,
            this.checkBoxItem5,
            this.checkBoxItem6,
            this.checkBoxItem7,
            this.checkBoxItem8});
            this.metroToolbar1.Location = new System.Drawing.Point(46, 72);
            this.metroToolbar1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(522, 22);
            this.metroToolbar1.TabIndex = 23;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "车次类型";
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "全部";
            // 
            // checkBoxItem2
            // 
            this.checkBoxItem2.Name = "checkBoxItem2";
            this.checkBoxItem2.Text = "D字头";
            // 
            // checkBoxItem3
            // 
            this.checkBoxItem3.Name = "checkBoxItem3";
            this.checkBoxItem3.Text = "G字头";
            // 
            // checkBoxItem4
            // 
            this.checkBoxItem4.Name = "checkBoxItem4";
            this.checkBoxItem4.Text = "Z字头";
            // 
            // checkBoxItem5
            // 
            this.checkBoxItem5.Name = "checkBoxItem5";
            this.checkBoxItem5.Text = "T字头";
            // 
            // checkBoxItem6
            // 
            this.checkBoxItem6.Name = "checkBoxItem6";
            this.checkBoxItem6.Text = "K字头";
            // 
            // checkBoxItem7
            // 
            this.checkBoxItem7.Name = "checkBoxItem7";
            this.checkBoxItem7.Text = "其他";
            // 
            // checkBoxItem8
            // 
            this.checkBoxItem8.Name = "checkBoxItem8";
            this.checkBoxItem8.Text = "学生票";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 533);
            this.Controls.Add(this.metroToolbar1);
            this.Controls.Add(this.tbstripMenu);
            this.Controls.Add(this.cmbStart);
            this.Controls.Add(this.cmbEnd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dtBookTicketDate);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblChangeStation);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.superGridViewForTicket);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButtonVisible = true;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBookTicketDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridViewForTicket;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem lblitem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblChangeStation;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBookTicketDate;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEnd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStart;
        private DevComponents.DotNetBar.TabStrip tbstripMenu;
        private DevComponents.DotNetBar.TabItem 谢谢;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem2;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem3;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem4;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem5;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem6;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem7;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem8;
    }
}