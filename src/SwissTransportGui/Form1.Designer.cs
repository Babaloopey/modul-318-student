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
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.DepartureLbl = new System.Windows.Forms.Label();
            this.DepartureBox = new System.Windows.Forms.TextBox();
            this.DepartureboardButton = new System.Windows.Forms.Button();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.TabManager.SuspendLayout();
            this.ConnectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
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
            this.ConnectionsTab.Controls.Add(this.DestinationBox);
            this.ConnectionsTab.Controls.Add(this.DestinationLbl);
            this.ConnectionsTab.Controls.Add(this.DepartureLbl);
            this.ConnectionsTab.Controls.Add(this.DepartureBox);
            this.ConnectionsTab.Controls.Add(this.DepartureboardButton);
            this.ConnectionsTab.Controls.Add(this.ConnectionButton);
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
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(163, 99);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(373, 39);
            this.DestinationBox.TabIndex = 7;
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(29, 99);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(74, 32);
            this.DestinationLbl.TabIndex = 6;
            this.DestinationLbl.Text = "Nach:";
            // 
            // DepartureLbl
            // 
            this.DepartureLbl.AutoSize = true;
            this.DepartureLbl.Location = new System.Drawing.Point(29, 33);
            this.DepartureLbl.Name = "DepartureLbl";
            this.DepartureLbl.Size = new System.Drawing.Size(60, 32);
            this.DepartureLbl.TabIndex = 5;
            this.DepartureLbl.Text = "Von:";
            // 
            // DepartureBox
            // 
            this.DepartureBox.Location = new System.Drawing.Point(163, 28);
            this.DepartureBox.Name = "DepartureBox";
            this.DepartureBox.Size = new System.Drawing.Size(373, 39);
            this.DepartureBox.TabIndex = 4;
            // 
            // DepartureboardButton
            // 
            this.DepartureboardButton.Location = new System.Drawing.Point(1253, 92);
            this.DepartureboardButton.Name = "DepartureboardButton";
            this.DepartureboardButton.Size = new System.Drawing.Size(294, 46);
            this.DepartureboardButton.TabIndex = 3;
            this.DepartureboardButton.Text = "Abfahrtstafel";
            this.DepartureboardButton.UseVisualStyleBackColor = true;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(1253, 24);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(294, 46);
            this.ConnectionButton.TabIndex = 2;
            this.ConnectionButton.Text = "Verbindungen suchen";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(779, 26);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(409, 39);
            this.DatePicker.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(6, 192);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 82;
            this.DataGrid.RowTemplate.Height = 41;
            this.DataGrid.Size = new System.Drawing.Size(1572, 866);
            this.DataGrid.TabIndex = 0;
            // 
            // SearchTab
            // 
            this.SearchTab.Location = new System.Drawing.Point(8, 46);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(1584, 1064);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Stationssuche";
            this.SearchTab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabManager;
        private TabPage ConnectionsTab;
        private TextBox DestinationBox;
        private Label DestinationLbl;
        private Label DepartureLbl;
        private TextBox DepartureBox;
        private Button DepartureboardButton;
        private Button ConnectionButton;
        private DateTimePicker DatePicker;
        private DataGridView DataGrid;
        private TabPage SearchTab;
    }
}