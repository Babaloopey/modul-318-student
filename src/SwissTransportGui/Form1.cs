using System.ComponentModel;
using System.Runtime.InteropServices;
using SwissTransport.Models;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();

        bool departureIsBeingUpdated = false;
        bool destinationIsBeingUpdated = false;

        Station SelectedDeparture = new Station();
        Station SelectedDestination = new Station();

        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            DepartureBox.DisplayMember = "Name";
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


        private void DepartureBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (departureIsBeingUpdated == false)
            {
                departureIsBeingUpdated = true;
                var txt = DepartureBox.Text;

                Stations stations = helper.getStations(DepartureBox.Text);

                if (stations != null)
                {

                    List<Station> Data = new List<Station>();
                    Station MockStation = new Station();
                    MockStation.Name = DepartureBox.Text;

                    Data.Add(MockStation);

                    DepartureBox.DataSource = null;
                    Data.AddRange(stations.StationList);
                    DepartureBox.DataSource = Data;

                    DepartureBox.DisplayMember = "Name";
                    DepartureBox.DroppedDown = true;
                    DepartureBox.SelectedIndex = 0;
                    Cursor.Current = Cursors.Default;
                    DepartureBox.Select(txt.Length, 0);



                }
                departureIsBeingUpdated = false;
            }
        }

        private void DestinationBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (destinationIsBeingUpdated == false)
            {
                destinationIsBeingUpdated = true;
                var txt = DestinationBox.Text;

                Stations stations = helper.getStations(DestinationBox.Text);

                if (stations != null)
                {

                    List<Station> Data = new List<Station>();
                    Station MockStation = new Station();
                    MockStation.Name = DestinationBox.Text;

                    Data.Add(MockStation);
                    Data.AddRange(stations.StationList);

                    Console.WriteLine(stations.StationList[0].Coordinate.XCoordinate.ToString());

                    DestinationBox.DataSource = Data;

                    DestinationBox.DisplayMember = "Name";
                    DestinationBox.DroppedDown = true;
                    DestinationBox.SelectedIndex = 0;
                    Cursor.Current = Cursors.Default;
                    DestinationBox.Select(txt.Length, 0);



                }
                destinationIsBeingUpdated = false;
            }
            }

        private void DepartureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station selectedDeparture = DepartureBox.SelectedItem as Station;
            
        }

        private void DestinationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station selectedDestination = DestinationBox.SelectedItem as Station;

        }
    }
}