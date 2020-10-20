namespace RegularAssessmentTranscriptFixedRank
{
    partial class ConfigForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboConfigure = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lbc01 = new System.Windows.Forms.LinkLabel();
            this.lbv01 = new System.Windows.Forms.LinkLabel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveConfig = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.iptRd = new DevComponents.Editors.IntegerInput();
            this.dtCurDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboExam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboRefExam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboSemester = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cboSchoolYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.ChkExportStudList = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dtEndAttend = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginAttend = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dtEndMerit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginMerit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtEndDermit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginDermit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.dtEndService = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginService = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptRd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCurDate)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDermit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDermit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginService)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConfigure
            // 
            this.cboConfigure.DisplayMember = "Name";
            this.cboConfigure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboConfigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfigure.FormattingEnabled = true;
            this.cboConfigure.ItemHeight = 19;
            this.cboConfigure.Location = new System.Drawing.Point(110, 10);
            this.cboConfigure.Name = "cboConfigure";
            this.cboConfigure.Size = new System.Drawing.Size(273, 25);
            this.cboConfigure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboConfigure.TabIndex = 0;
            this.cboConfigure.SelectedIndexChanged += new System.EventHandler(this.cboConfigure_SelectedIndexChanged);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Location = new System.Drawing.Point(478, 18);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(73, 17);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "刪除設定檔";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Location = new System.Drawing.Point(399, 18);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(73, 17);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "複製設定檔";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Location = new System.Drawing.Point(274, 323);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(112, 17);
            this.linkLabel5.TabIndex = 11;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "下載合併欄位總表";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // lbc01
            // 
            this.lbc01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbc01.AutoSize = true;
            this.lbc01.BackColor = System.Drawing.Color.Transparent;
            this.lbc01.Location = new System.Drawing.Point(182, 323);
            this.lbc01.Name = "lbc01";
            this.lbc01.Size = new System.Drawing.Size(86, 17);
            this.lbc01.TabIndex = 10;
            this.lbc01.TabStop = true;
            this.lbc01.Text = "變更套印樣板";
            this.lbc01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lbv01
            // 
            this.lbv01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbv01.AutoSize = true;
            this.lbv01.BackColor = System.Drawing.Color.Transparent;
            this.lbv01.Location = new System.Drawing.Point(90, 323);
            this.lbv01.Name = "lbv01";
            this.lbv01.Size = new System.Drawing.Size(86, 17);
            this.lbv01.TabIndex = 9;
            this.lbv01.TabStop = true;
            this.lbv01.Text = "檢視套印樣板";
            this.lbv01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(17, 12);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(87, 21);
            this.labelX11.TabIndex = 5;
            this.labelX11.Text = "樣板設定檔：";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveConfig.Enabled = false;
            this.btnSaveConfig.Location = new System.Drawing.Point(317, 521);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "儲存設定";
            this.btnSaveConfig.Tooltip = "儲存當前的樣板設定。";
            this.btnSaveConfig.Click += new System.EventHandler(this.SaveTemplate);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(398, 521);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "確定";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(479, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(807, 681);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.Transparent;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Location = new System.Drawing.Point(23, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 450);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.labelX19);
            this.tabControlPanel1.Controls.Add(this.labelX18);
            this.tabControlPanel1.Controls.Add(this.iptRd);
            this.tabControlPanel1.Controls.Add(this.dtCurDate);
            this.tabControlPanel1.Controls.Add(this.labelX17);
            this.tabControlPanel1.Controls.Add(this.circularProgress1);
            this.tabControlPanel1.Controls.Add(this.listViewEx1);
            this.tabControlPanel1.Controls.Add(this.labelX7);
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.Controls.Add(this.cboExam);
            this.tabControlPanel1.Controls.Add(this.labelX4);
            this.tabControlPanel1.Controls.Add(this.cboRefExam);
            this.tabControlPanel1.Controls.Add(this.cboSemester);
            this.tabControlPanel1.Controls.Add(this.labelX8);
            this.tabControlPanel1.Controls.Add(this.labelX9);
            this.tabControlPanel1.Controls.Add(this.cboSchoolYear);
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(534, 466);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // labelX19
            // 
            this.labelX19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX19.AutoSize = true;
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(366, 158);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(74, 21);
            this.labelX19.TabIndex = 19;
            this.labelX19.Text = "位四捨五入";
            // 
            // labelX18
            // 
            this.labelX18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX18.AutoSize = true;
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(182, 158);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(127, 21);
            this.labelX18.TabIndex = 18;
            this.labelX18.Text = "平均計算至小數點後";
            // 
            // iptRd
            // 
            // 
            // 
            // 
            this.iptRd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iptRd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iptRd.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iptRd.Location = new System.Drawing.Point(314, 156);
            this.iptRd.MaxValue = 5;
            this.iptRd.MinValue = 0;
            this.iptRd.Name = "iptRd";
            this.iptRd.ShowUpDown = true;
            this.iptRd.Size = new System.Drawing.Size(45, 25);
            this.iptRd.TabIndex = 17;
            this.iptRd.Value = 2;
            // 
            // dtCurDate
            // 
            // 
            // 
            // 
            this.dtCurDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtCurDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCurDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtCurDate.ButtonDropDown.Visible = true;
            this.dtCurDate.IsPopupCalendarOpen = false;
            this.dtCurDate.Location = new System.Drawing.Point(199, 123);
            // 
            // 
            // 
            this.dtCurDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCurDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtCurDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtCurDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCurDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtCurDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCurDate.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtCurDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.dtCurDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtCurDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCurDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtCurDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCurDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtCurDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtCurDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCurDate.MonthCalendar.TodayButtonVisible = true;
            this.dtCurDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtCurDate.Name = "dtCurDate";
            this.dtCurDate.Size = new System.Drawing.Size(161, 25);
            this.dtCurDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCurDate.TabIndex = 16;
            // 
            // labelX17
            // 
            this.labelX17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX17.AutoSize = true;
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(91, 125);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(101, 21);
            this.labelX17.TabIndex = 15;
            this.labelX17.Text = "成績校正日期：";
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.Class = "";
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.FocusCuesEnabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(384, 55);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgress1.ProgressTextVisible = true;
            this.circularProgress1.Size = new System.Drawing.Size(66, 62);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.circularProgress1.TabIndex = 14;
            // 
            // listViewEx1
            // 
            this.listViewEx1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.CheckBoxes = true;
            this.listViewEx1.HideSelection = false;
            this.listViewEx1.Location = new System.Drawing.Point(84, 186);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(366, 191);
            this.listViewEx1.TabIndex = 8;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.List;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(132, 18);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(60, 21);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "學年度：";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(84, 156);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 21);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "列印科目：";
            // 
            // cboExam
            // 
            this.cboExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboExam.DisplayMember = "Name";
            this.cboExam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExam.FormattingEnabled = true;
            this.cboExam.ItemHeight = 19;
            this.cboExam.Location = new System.Drawing.Point(199, 53);
            this.cboExam.Name = "cboExam";
            this.cboExam.Size = new System.Drawing.Size(160, 25);
            this.cboExam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboExam.TabIndex = 5;
            this.cboExam.ValueMember = "ID";
            this.cboExam.SelectedIndexChanged += new System.EventHandler(this.ExamChanged);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(91, 55);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 21);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "列印成績試別：";
            // 
            // cboRefExam
            // 
            this.cboRefExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRefExam.DisplayMember = "Name";
            this.cboRefExam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRefExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRefExam.FormattingEnabled = true;
            this.cboRefExam.ItemHeight = 19;
            this.cboRefExam.Location = new System.Drawing.Point(199, 87);
            this.cboRefExam.Name = "cboRefExam";
            this.cboRefExam.Size = new System.Drawing.Size(160, 25);
            this.cboRefExam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboRefExam.TabIndex = 6;
            this.cboRefExam.ValueMember = "ID";
            // 
            // cboSemester
            // 
            this.cboSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSemester.DisplayMember = "Text";
            this.cboSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.ItemHeight = 19;
            this.cboSemester.Location = new System.Drawing.Point(305, 16);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(54, 25);
            this.cboSemester.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSemester.TabIndex = 4;
            this.cboSemester.TextChanged += new System.EventHandler(this.ExamChanged);
            // 
            // labelX8
            // 
            this.labelX8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(91, 89);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(101, 21);
            this.labelX8.TabIndex = 5;
            this.labelX8.Text = "參考成績試別：";
            // 
            // labelX9
            // 
            this.labelX9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(258, 18);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(47, 21);
            this.labelX9.TabIndex = 5;
            this.labelX9.Text = "學期：";
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSchoolYear.DisplayMember = "Text";
            this.cboSchoolYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSchoolYear.FormattingEnabled = true;
            this.cboSchoolYear.ItemHeight = 19;
            this.cboSchoolYear.Location = new System.Drawing.Point(199, 16);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(54, 25);
            this.cboSchoolYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSchoolYear.TabIndex = 3;
            this.cboSchoolYear.TextChanged += new System.EventHandler(this.ExamChanged);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "成績";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.dtEndService);
            this.tabControlPanel3.Controls.Add(this.dtBeginService);
            this.tabControlPanel3.Controls.Add(this.labelX21);
            this.tabControlPanel3.Controls.Add(this.labelX22);
            this.tabControlPanel3.Controls.Add(this.labelX23);
            this.tabControlPanel3.Controls.Add(this.dtEndDermit);
            this.tabControlPanel3.Controls.Add(this.dtBeginDermit);
            this.tabControlPanel3.Controls.Add(this.labelX6);
            this.tabControlPanel3.Controls.Add(this.labelX10);
            this.tabControlPanel3.Controls.Add(this.labelX20);
            this.tabControlPanel3.Controls.Add(this.dtEndMerit);
            this.tabControlPanel3.Controls.Add(this.dtBeginMerit);
            this.tabControlPanel3.Controls.Add(this.labelX1);
            this.tabControlPanel3.Controls.Add(this.labelX3);
            this.tabControlPanel3.Controls.Add(this.labelX5);
            this.tabControlPanel3.Controls.Add(this.labelX16);
            this.tabControlPanel3.Controls.Add(this.labelX15);
            this.tabControlPanel3.Controls.Add(this.ChkExportStudList);
            this.tabControlPanel3.Controls.Add(this.dtEndAttend);
            this.tabControlPanel3.Controls.Add(this.dtBeginAttend);
            this.tabControlPanel3.Controls.Add(this.labelX14);
            this.tabControlPanel3.Controls.Add(this.labelX13);
            this.tabControlPanel3.Controls.Add(this.linkLabel5);
            this.tabControlPanel3.Controls.Add(this.labelX12);
            this.tabControlPanel3.Controls.Add(this.lbv01);
            this.tabControlPanel3.Controls.Add(this.lbc01);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(534, 421);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // labelX16
            // 
            this.labelX16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX16.AutoSize = true;
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(29, 361);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(74, 21);
            this.labelX16.TabIndex = 26;
            this.labelX16.Text = "其它設定：";
            // 
            // labelX15
            // 
            this.labelX15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX15.AutoSize = true;
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(29, 296);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(74, 21);
            this.labelX15.TabIndex = 25;
            this.labelX15.Text = "樣板設定：";
            // 
            // ChkExportStudList
            // 
            this.ChkExportStudList.AutoSize = true;
            this.ChkExportStudList.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ChkExportStudList.BackgroundStyle.Class = "";
            this.ChkExportStudList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ChkExportStudList.Location = new System.Drawing.Point(50, 388);
            this.ChkExportStudList.Name = "ChkExportStudList";
            this.ChkExportStudList.Size = new System.Drawing.Size(107, 21);
            this.ChkExportStudList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ChkExportStudList.TabIndex = 19;
            this.ChkExportStudList.Text = "產生學生清單";
            this.ChkExportStudList.CheckedChanged += new System.EventHandler(this.ChkExportStudList_CheckedChanged);
            // 
            // dtEndAttend
            // 
            // 
            // 
            // 
            this.dtEndAttend.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndAttend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndAttend.ButtonDropDown.Visible = true;
            this.dtEndAttend.IsPopupCalendarOpen = false;
            this.dtEndAttend.Location = new System.Drawing.Point(314, 44);
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndAttend.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndAttend.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndAttend.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.TodayButtonVisible = true;
            this.dtEndAttend.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndAttend.Name = "dtEndAttend";
            this.dtEndAttend.Size = new System.Drawing.Size(143, 25);
            this.dtEndAttend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndAttend.TabIndex = 18;
            // 
            // dtBeginAttend
            // 
            // 
            // 
            // 
            this.dtBeginAttend.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginAttend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginAttend.ButtonDropDown.Visible = true;
            this.dtBeginAttend.IsPopupCalendarOpen = false;
            this.dtBeginAttend.Location = new System.Drawing.Point(93, 44);
            this.dtBeginAttend.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginAttend.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginAttend.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginAttend.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginAttend.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginAttend.Name = "dtBeginAttend";
            this.dtBeginAttend.Size = new System.Drawing.Size(143, 25);
            this.dtBeginAttend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginAttend.TabIndex = 17;
            // 
            // labelX14
            // 
            this.labelX14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX14.AutoSize = true;
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(267, 46);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(47, 21);
            this.labelX14.TabIndex = 16;
            this.labelX14.Text = "結束：";
            // 
            // labelX13
            // 
            this.labelX13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX13.AutoSize = true;
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(49, 46);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(47, 21);
            this.labelX13.TabIndex = 15;
            this.labelX13.Text = "開始：";
            // 
            // labelX12
            // 
            this.labelX12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(29, 19);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(216, 21);
            this.labelX12.TabIndex = 14;
            this.labelX12.Text = "請選擇日期區間：(依區間統計缺曠)";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "缺曠、獎懲、學習服務及樣板";
            // 
            // dtEndMerit
            // 
            // 
            // 
            // 
            this.dtEndMerit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndMerit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndMerit.ButtonDropDown.Visible = true;
            this.dtEndMerit.IsPopupCalendarOpen = false;
            this.dtEndMerit.Location = new System.Drawing.Point(314, 107);
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndMerit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndMerit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndMerit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.TodayButtonVisible = true;
            this.dtEndMerit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndMerit.Name = "dtEndMerit";
            this.dtEndMerit.Size = new System.Drawing.Size(143, 25);
            this.dtEndMerit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndMerit.TabIndex = 31;
            // 
            // dtBeginMerit
            // 
            // 
            // 
            // 
            this.dtBeginMerit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginMerit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginMerit.ButtonDropDown.Visible = true;
            this.dtBeginMerit.IsPopupCalendarOpen = false;
            this.dtBeginMerit.Location = new System.Drawing.Point(93, 107);
            this.dtBeginMerit.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginMerit.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginMerit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginMerit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginMerit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginMerit.Name = "dtBeginMerit";
            this.dtBeginMerit.Size = new System.Drawing.Size(143, 25);
            this.dtBeginMerit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginMerit.TabIndex = 30;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(267, 109);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(47, 21);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "結束：";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(49, 109);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(47, 21);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "開始：";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(29, 82);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(216, 21);
            this.labelX5.TabIndex = 27;
            this.labelX5.Text = "請選擇日期區間：(依區間統計獎勵)";
            // 
            // dtEndDermit
            // 
            // 
            // 
            // 
            this.dtEndDermit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndDermit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndDermit.ButtonDropDown.Visible = true;
            this.dtEndDermit.IsPopupCalendarOpen = false;
            this.dtEndDermit.Location = new System.Drawing.Point(314, 163);
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndDermit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndDermit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndDermit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.TodayButtonVisible = true;
            this.dtEndDermit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndDermit.Name = "dtEndDermit";
            this.dtEndDermit.Size = new System.Drawing.Size(143, 25);
            this.dtEndDermit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndDermit.TabIndex = 36;
            // 
            // dtBeginDermit
            // 
            // 
            // 
            // 
            this.dtBeginDermit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginDermit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginDermit.ButtonDropDown.Visible = true;
            this.dtBeginDermit.IsPopupCalendarOpen = false;
            this.dtBeginDermit.Location = new System.Drawing.Point(93, 163);
            this.dtBeginDermit.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginDermit.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginDermit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginDermit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginDermit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginDermit.Name = "dtBeginDermit";
            this.dtBeginDermit.Size = new System.Drawing.Size(143, 25);
            this.dtBeginDermit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginDermit.TabIndex = 35;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(267, 165);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(47, 21);
            this.labelX6.TabIndex = 34;
            this.labelX6.Text = "結束：";
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(49, 165);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(47, 21);
            this.labelX10.TabIndex = 33;
            this.labelX10.Text = "開始：";
            // 
            // labelX20
            // 
            this.labelX20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(29, 138);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(243, 21);
            this.labelX20.TabIndex = 32;
            this.labelX20.Text = "請選擇日期區間：(依區間統計康橋懲戒)";
            // 
            // dtEndService
            // 
            // 
            // 
            // 
            this.dtEndService.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndService.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndService.ButtonDropDown.Visible = true;
            this.dtEndService.IsPopupCalendarOpen = false;
            this.dtEndService.Location = new System.Drawing.Point(314, 224);
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndService.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndService.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndService.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.TodayButtonVisible = true;
            this.dtEndService.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndService.Name = "dtEndService";
            this.dtEndService.Size = new System.Drawing.Size(143, 25);
            this.dtEndService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndService.TabIndex = 41;
            // 
            // dtBeginService
            // 
            // 
            // 
            // 
            this.dtBeginService.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginService.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginService.ButtonDropDown.Visible = true;
            this.dtBeginService.IsPopupCalendarOpen = false;
            this.dtBeginService.Location = new System.Drawing.Point(93, 224);
            this.dtBeginService.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginService.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginService.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginService.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginService.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginService.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginService.Name = "dtBeginService";
            this.dtBeginService.Size = new System.Drawing.Size(143, 25);
            this.dtBeginService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginService.TabIndex = 40;
            // 
            // labelX21
            // 
            this.labelX21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX21.AutoSize = true;
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.Class = "";
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(267, 226);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(47, 21);
            this.labelX21.TabIndex = 39;
            this.labelX21.Text = "結束：";
            // 
            // labelX22
            // 
            this.labelX22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX22.AutoSize = true;
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.Class = "";
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(49, 226);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(47, 21);
            this.labelX22.TabIndex = 38;
            this.labelX22.Text = "開始：";
            // 
            // labelX23
            // 
            this.labelX23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX23.AutoSize = true;
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.Class = "";
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Location = new System.Drawing.Point(29, 199);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(243, 21);
            this.labelX23.TabIndex = 37;
            this.labelX23.Text = "請選擇日期區間：(依區間統計服務學習)";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(565, 552);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cboConfigure);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.MaximizeBox = true;
            this.Name = "ConfigForm";
            this.Text = "定期評量成績單(康橋)";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptRd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCurDate)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDermit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDermit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboConfigure;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel lbc01;
        private System.Windows.Forms.LinkLabel lbv01;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.ButtonX btnSaveConfig;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboExam;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboRefExam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSemester;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSchoolYear;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndAttend;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginAttend;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.CheckBoxX ChkExportStudList;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCurDate;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.Editors.IntegerInput iptRd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndService;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginService;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndDermit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginDermit;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndMerit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginMerit;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}