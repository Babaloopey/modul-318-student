namespace SwissTransportGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabManager = new System.Windows.Forms.TabControl();
            this.ConnectionsTab = new System.Windows.Forms.TabPage();
            this.DepartureBox = new System.Windows.Forms.ComboBox();
            this.StationboardLbl = new System.Windows.Forms.Label();
            this.DestinationBox = new System.Windows.Forms.ComboBox();
            this.StationLbl = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.DomainUpDown();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.DepartureLbl = new System.Windows.Forms.Label();
            this.DepartureboardBtn = new System.Windows.Forms.Button();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.MapBtn = new System.Windows.Forms.Button();
            this.SubmitStationBtn = new System.Windows.Forms.Button();
            this.StationsGrid = new System.Windows.Forms.DataGridView();
            this.LookForStationsBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TabManager.SuspendLayout();
            this.ConnectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabManager
            // 
            this.TabManager.Controls.Add(this.ConnectionsTab);
            this.TabManager.Controls.Add(this.SearchTab);
            this.TabManager.Location = new System.Drawing.Point(12, 12);
            this.TabManager.Name = "TabManager";
            this.TabManager.SelectedIndex = 0;
            this.TabManager.Size = new System.Drawing.Size(1600, 1118);
            this.TabManager.TabIndex = 0;
            // 
            // ConnectionsTab
            // 
            this.ConnectionsTab.Controls.Add(this.DepartureBox);
            this.ConnectionsTab.Controls.Add(this.StationboardLbl);
            this.ConnectionsTab.Controls.Add(this.DestinationBox);
            this.ConnectionsTab.Controls.Add(this.StationLbl);
            this.ConnectionsTab.Controls.Add(this.TimeBox);
            this.ConnectionsTab.Controls.Add(this.TimeLbl);
            this.ConnectionsTab.Controls.Add(this.DateLbl);
            this.ConnectionsTab.Controls.Add(this.DestinationLbl);
            this.ConnectionsTab.Controls.Add(this.DepartureLbl);
            this.ConnectionsTab.Controls.Add(this.DepartureboardBtn);
            this.ConnectionsTab.Controls.Add(this.ConnectionBtn);
            this.ConnectionsTab.Controls.Add(this.DatePicker);
            this.ConnectionsTab.Controls.Add(this.DataGrid);
            this.ConnectionsTab.Location = new System.Drawing.Point(8, 46);
            this.ConnectionsTab.Name = "ConnectionsTab";
            this.ConnectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionsTab.Size = new System.Drawing.Size(1584, 1064);
            this.ConnectionsTab.TabIndex = 0;
            this.ConnectionsTab.Text = "Verbindungen";
            this.ConnectionsTab.UseVisualStyleBackColor = true;
            // 
            // DepartureBox
            // 
            this.DepartureBox.FormattingEnabled = true;
            this.DepartureBox.Location = new System.Drawing.Point(209, 33);
            this.DepartureBox.Name = "DepartureBox";
            this.DepartureBox.Size = new System.Drawing.Size(373, 40);
            this.DepartureBox.TabIndex = 14;
            this.DepartureBox.SelectedIndexChanged += new System.EventHandler(this.DepartureBox_SelectedIndexChanged);

            this.DepartureBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DepartureBox_KeyUp);
            // 
            // StationboardLbl
            // 
            this.StationboardLbl.AutoSize = true;
            this.StationboardLbl.Location = new System.Drawing.Point(32, 173);
            this.StationboardLbl.Name = "StationboardLbl";
            this.StationboardLbl.Size = new System.Drawing.Size(0, 32);
            this.StationboardLbl.TabIndex = 1;
            // 
            // DestinationBox
            // 
            this.DestinationBox.FormattingEnabled = true;
            this.DestinationBox.Location = new System.Drawing.Point(209, 96);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(373, 40);
            this.DestinationBox.TabIndex = 13;
            this.DestinationBox.SelectedIndexChanged += new System.EventHandler(this.DestinationBox_SelectedIndexChanged);

            this.DestinationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DestinationBox_KeyUp);
            // 
            // StationLbl
            // 
            this.StationLbl.AutoSize = true;
            this.StationLbl.Location = new System.Drawing.Point(216, 173);
            this.StationLbl.Name = "StationLbl";
            this.StationLbl.Size = new System.Drawing.Size(0, 32);
            this.StationLbl.TabIndex = 11;
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(835, 97);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(240, 39);
            this.TimeBox.TabIndex = 10;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(715, 99);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(60, 32);
            this.TimeLbl.TabIndex = 9;
            this.TimeLbl.Text = "Zeit:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(700, 31);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(91, 32);
            this.DateLbl.TabIndex = 8;
            this.DateLbl.Text = "Datum:";
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(124, 99);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(74, 32);
            this.DestinationLbl.TabIndex = 6;
            this.DestinationLbl.Text = "Nach:";
            // 
            // DepartureLbl
            // 
            this.DepartureLbl.AutoSize = true;
            this.DepartureLbl.Location = new System.Drawing.Point(124, 33);
            this.DepartureLbl.Name = "DepartureLbl";
            this.DepartureLbl.Size = new System.Drawing.Size(60, 32);
            this.DepartureLbl.TabIndex = 5;
            this.DepartureLbl.Text = "Von:";
            // 
            // DepartureboardBtn
            // 
            this.DepartureboardBtn.Location = new System.Drawing.Point(1237, 92);
            this.DepartureboardBtn.Name = "DepartureboardBtn";
            this.DepartureboardBtn.Size = new System.Drawing.Size(294, 46);
            this.DepartureboardBtn.TabIndex = 3;
            this.DepartureboardBtn.Text = "Abfahrtstafel";
            this.DepartureboardBtn.UseVisualStyleBackColor = true;
            this.DepartureboardBtn.Click += new System.EventHandler(this.DepartureboardBtn_Click);
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.Location = new System.Drawing.Point(1237, 26);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(294, 46);
            this.ConnectionBtn.TabIndex = 2;
            this.ConnectionBtn.Text = "Verbindungen suchen";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(833, 28);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(242, 39);
            this.DatePicker.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(6, 223);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 82;
            this.DataGrid.RowTemplate.Height = 41;
            this.DataGrid.Size = new System.Drawing.Size(1572, 835);
            this.DataGrid.TabIndex = 0;
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.MapBtn);
            this.SearchTab.Controls.Add(this.SubmitStationBtn);
            this.SearchTab.Controls.Add(this.StationsGrid);
            this.SearchTab.Controls.Add(this.LookForStationsBtn);
            this.SearchTab.Controls.Add(this.SearchBtn);
            this.SearchTab.Controls.Add(this.DescriptionLbl);
            this.SearchTab.Controls.Add(this.SearchBox);
            this.SearchTab.Location = new System.Drawing.Point(8, 46);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(1584, 1064);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Stationssuche";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // MapBtn
            // 
            this.MapBtn.Location = new System.Drawing.Point(1071, 992);
            this.MapBtn.Name = "MapBtn";
            this.MapBtn.Size = new System.Drawing.Size(150, 46);
            this.MapBtn.TabIndex = 6;
            this.MapBtn.Text = "Karte";
            this.MapBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitStationBtn
            // 
            this.SubmitStationBtn.Location = new System.Drawing.Point(1293, 992);
            this.SubmitStationBtn.Name = "SubmitStationBtn";
            this.SubmitStationBtn.Size = new System.Drawing.Size(285, 46);
            this.SubmitStationBtn.TabIndex = 5;
            this.SubmitStationBtn.Text = "Station übernehmen";
            this.SubmitStationBtn.UseVisualStyleBackColor = true;
            // 
            // StationsGrid
            // 
            this.StationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationsGrid.Location = new System.Drawing.Point(6, 115);
            this.StationsGrid.Name = "StationsGrid";
            this.StationsGrid.RowHeadersWidth = 82;
            this.StationsGrid.RowTemplate.Height = 41;
            this.StationsGrid.Size = new System.Drawing.Size(1572, 856);
            this.StationsGrid.TabIndex = 4;
            // 
            // LookForStationsBtn
            // 
            this.LookForStationsBtn.Location = new System.Drawing.Point(1154, 42);
            this.LookForStationsBtn.Name = "LookForStationsBtn";
            this.LookForStationsBtn.Size = new System.Drawing.Size(379, 46);
            this.LookForStationsBtn.TabIndex = 3;
            this.LookForStationsBtn.Text = "Stationen in der Nähe finden";
            this.LookForStationsBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(816, 42);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(150, 46);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(81, 49);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(142, 32);
            this.DescriptionLbl.TabIndex = 1;
            this.DescriptionLbl.Text = "Suchbegriff:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(240, 46);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(556, 39);
            this.SearchBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 1141);
            this.Controls.Add(this.TabManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabManager.ResumeLayout(false);
            this.ConnectionsTab.ResumeLayout(false);
            this.ConnectionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabManager;
        private TabPage ConnectionsTab;
        private Label DestinationLbl;
        private Label DepartureLbl;
        private Button DepartureboardBtn;
        private Button ConnectionBtn;
        private DateTimePicker DatePicker;
        private DataGridView DataGrid;
        private TabPage SearchTab;
        private DomainUpDown TimeBox;
        private Label TimeLbl;
        private Label DateLbl;
        private Button LookForStationsBtn;
        private Button SearchBtn;
        private Label DescriptionLbl;
        private TextBox SearchBox;
        private Button MapBtn;
        private Button SubmitStationBtn;
        private DataGridView StationsGrid;
        private Label StationLbl;
        private ComboBox DestinationBox;
        private Label StationboardLbl;
        private ComboBox DepartureBox;
    }
}