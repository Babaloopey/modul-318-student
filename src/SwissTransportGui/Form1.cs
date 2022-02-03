using System.ComponentModel;
using System.Runtime.InteropServices;
using SwissTransport.Models;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();
        public Form1()
        {
            InitializeComponent();
            AllocConsole();

            
            //DepartureBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            //DepartureBox.AutoCompleteSource = AutoCompleteSource.ListItems;

           



        }

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            string departure = DepartureBox.Text;
            string destination = DestinationBox.Text;

            var connections = helper.getConnections(departure, destination);

            if (connections != null)
            {
                DataGrid.DataSource = connections;

                DataGrid.Columns[0].Width = (int)(DataGrid.Width * 0.25);
                DataGrid.Columns[1].Width = (int)(DataGrid.Width * 0.1);
                DataGrid.Columns[2].Width = (int)(DataGrid.Width * 0.25);
                DataGrid.Columns[3].Width = (int)(DataGrid.Width * 0.1);
                DataGrid.Columns[4].Width = (int)(DataGrid.Width * 0.1);
                DataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = SearchBox.Text;
                Stations stations = helper.getStations(searchTerm);

                if (stations != null)
                {
                    StationsGrid.DataSource = stations.StationList;
                    StationsGrid.Columns[0].Visible = false;
                    StationsGrid.Columns[1].Visible = true;
                    StationsGrid.Columns[2].Visible = false;
                    StationsGrid.Columns[3].Visible = false;
                    StationsGrid.Columns[4].Visible = false;
                    StationsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe");
            }
        }



        private void DepartureboardBtn_Click(object sender, EventArgs e)
        {
            string location = DepartureBox.Text;
            List<StationboardForDisplay> stationBoard = helper.getStationBoard(location);

            if (stationBoard != null)
            {
                DataGrid.DataSource = stationBoard;

                DataGrid.Columns[0].Width = (int)(DataGrid.Width * 0.35);
                DataGrid.Columns[1].Width = (int)(DataGrid.Width * 0.3);
                DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DepartureBox_TextChanged(object sender, EventArgs e)
        {
            var stations = helper.getStations(DepartureBox.Text);
            DepartureBox.DataSource = stations.StationList;
            DepartureBox.DisplayMember = "Name";
            
        }
    }
}