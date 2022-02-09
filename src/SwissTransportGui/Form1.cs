using System.ComponentModel;
using System.Runtime.InteropServices;
using SwissTransport.Models;
using System.Diagnostics;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();

        bool departureIsBeingUpdated = false;
        bool destinationIsBeingUpdated = false;

        //Für Weiterentwicklung der Applikation
        Station SelectedDeparture = new Station();
        Station SelectedDestination = new Station();

        Station SelectedStation = new Station();
        ConnectionForDisplay SelectedConnection = new ConnectionForDisplay();
        StationboardForDisplay SelectedStationboardentry = new StationboardForDisplay();



        public Form1()
        {
            InitializeComponent();
          //  AllocConsole();

            DatePicker.Checked = false;
            TimePicker.Checked = false;

            MailBtn.Enabled = false;
            MapBtn.Enabled = false;
            LookForStationsBtn.Enabled = false;
        }



        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            StationLbl.Text = "";
            string departure = DepartureBox.Text;
            string destination = DestinationBox.Text;

            List<ConnectionForDisplay>? connections = new List<ConnectionForDisplay>();

            if (DatePicker.Checked && TimePicker.Checked)
            {
                connections = helper.GetConnections(departure, destination, Date: DatePicker.Value.ToString("yyyy-MM-dd"), Time: TimePicker.Value.ToString("HH:mm"));
            }
            else if (DatePicker.Checked)
            {
                connections = helper.GetConnections(departure, destination, Date: DatePicker.Value.ToString("yyyy-MM-dd"));
            }
            else if (TimePicker.Checked)
            {
                connections = helper.GetConnections(departure, destination, Time: TimePicker.Value.ToString("HH:mm"));
            }
            else
            {
                connections = helper.GetConnections(departure, destination);
            }


            if (connections != null)
            {
                DataGrid.DataSource = connections;

                DataGrid.Columns[0].Width = (int)(DataGrid.Width * 0.2);
                DataGrid.Columns[1].Width = (int)(DataGrid.Width * 0.17);
                DataGrid.Columns[2].Width = (int)(DataGrid.Width * 0.2);
                DataGrid.Columns[3].Width = (int)(DataGrid.Width * 0.17);
                DataGrid.Columns[4].Width = (int)(DataGrid.Width * 0.1);
                DataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (connections == null || connections.Count == 0)
            {
                MessageBox.Show("Keine Verbindungen gefunden");
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
                Stations? stations = helper.GetStations(searchTerm);

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
                if (stations == null || stations.StationList.Count == 0)
                {
                    MessageBox.Show("Keine Stationen gefunden");
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
            List<StationboardForDisplay>? stationBoard = helper.GetStationBoard(location, StationLbl);

            if (stationBoard != null)
            {
                DataGrid.DataSource = stationBoard;

                DataGrid.Columns[0].Width = (int)(DataGrid.Width * 0.35);
                DataGrid.Columns[1].Width = (int)(DataGrid.Width * 0.3);
                DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (stationBoard.Count == 0)
                {
                    MessageBox.Show("Kein Ergebnis gefunden");
                }
            }
            else
            {
                MessageBox.Show("Kein Ergebnis");
            }
            
        }


        private void DepartureBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (departureIsBeingUpdated == false)
            {
                departureIsBeingUpdated = true;
                var txt = DepartureBox.Text;

                Stations? stations = helper.GetStations(DepartureBox.Text);

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

                Stations? stations = helper.GetStations(DestinationBox.Text);

                if (stations != null)
                {

                    List<Station> Data = new List<Station>();
                    Station MockStation = new Station();
                    MockStation.Name = DestinationBox.Text;

                    Data.Add(MockStation);
                    Data.AddRange(stations.StationList);

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
            if (DepartureBox.SelectedItem != null)
            {
                Station? selectedDeparture = DepartureBox.SelectedItem as Station;
            }

        }

        private void DestinationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DestinationBox.SelectedItem != null)
            {
                Station? selectedDestination = DestinationBox.SelectedItem as Station;
            }

        }

        private void StationsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedStation = (Station)StationsGrid.CurrentRow.DataBoundItem;
            MapBtn.Enabled = true;
            LookForStationsBtn.Enabled = true;
        }

        private void MapBtn_Click(object sender, EventArgs e)
        {
            if (SelectedStation.Coordinate != null)
            {
                if (SelectedStation.Coordinate.XCoordinate != null && SelectedStation.Coordinate.YCoordinate != null)
                {
                    Process.Start(new ProcessStartInfo("https://map.search.ch/" + SelectedStation.Coordinate.XCoordinate + "," + SelectedStation.Coordinate.YCoordinate) { UseShellExecute = true });
                }
                else { MessageBox.Show("Keine Haltestelle gefunden"); }



            }
            else { MessageBox.Show("Wählen sie eine Station aus"); }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.CurrentRow != null)
            {
                if (DataGrid.CurrentRow.DataBoundItem is ConnectionForDisplay)
                {
                    SelectedConnection = (ConnectionForDisplay)DataGrid.CurrentRow.DataBoundItem;
                    SelectedStationboardentry = null;
                }
                else if (DataGrid.CurrentRow.DataBoundItem is StationboardForDisplay)
                {
                    SelectedStationboardentry = (StationboardForDisplay)DataGrid.CurrentRow.DataBoundItem;
                    SelectedConnection = null;
                }
                MailBtn.Enabled = true;
            }

        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            if (SelectedStationboardentry != null)
            {
                var Body = StationLbl.Text +
                    "%0A" + "Ankunftsort: " + SelectedStationboardentry.Nach +
                    "%0A" + "Bezeichnung: " + SelectedStationboardentry.Bezeichnung +
                    "%0A" + "Abfahrt: " + SelectedStationboardentry.Abfahrt + "%0A %0A";

                Mail mail = new Mail(Body);

                mail.SendMail();
            }
            else if (SelectedConnection != null)
            {

                var Body = "Abfahrtsort: " + SelectedConnection.Abfahrtsort + "  Zeit: " + SelectedConnection.Abfahrt +
                "%0A" + "Ankunftsort: " + SelectedConnection.Ankunftsort + "  Zeit: " + SelectedConnection.Ankunft +
                "%0A" + "Dauer: " + SelectedConnection.Dauer + "%0A" + "Kante/Gleis: " + SelectedConnection.Kante + "%0A %0A";

                Mail mail = new Mail(Body);

                mail.SendMail();
            }
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            string temp = DepartureBox.Text;
            DepartureBox.Text = DestinationBox.Text;
            DestinationBox.Text = temp;
        }

        private void LookForStationsBtn_Click(object sender, EventArgs e)
        {
            if (SelectedStation != null && SelectedStation.Coordinate != null && SelectedStation.Coordinate.XCoordinate != null) {
                List<Station>? stations = helper.GetNearestStations(SelectedStation.Coordinate);

                if (stations != null)
                {
                    StationsGrid.DataSource = stations;
                    StationsGrid.Columns[0].Visible = false;
                    StationsGrid.Columns[2].Visible = false;
                    StationsGrid.Columns[3].Visible = false;
                    StationsGrid.Columns[4].Visible = false;
                    StationsGrid.Columns["Name"].Visible = true;
                    StationsGrid.Columns["Distance"].Visible = true;
                    StationsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                MessageBox.Show("Keine Koordinaten vorhanden");
            }
           
        }
    }
}