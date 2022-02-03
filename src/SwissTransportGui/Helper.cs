using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGui
{
    internal class Helper
    {
        private ITransport transport = new Transport();

        public List<ConnectionForDisplay> getConnections(string departure, string destination)
        {
            if (!String.IsNullOrEmpty(destination) && !String.IsNullOrEmpty(departure)){
                
                List<ConnectionForDisplay> connectionsForDisplay = new List<ConnectionForDisplay>();

                Connections connections = transport.GetConnections(departure, destination);

                foreach (Connection connection in connections.ConnectionList) {
                    
                        ConnectionForDisplay connectionForDisplay = new ConnectionForDisplay();
                        connectionForDisplay.Ankunftsort = connection.To.Station.Name;
                        connectionForDisplay.Abfahrtsort = connection.From.Station.Name;
                        connectionForDisplay.Ankunft = SeparateDateTime(connection.To.Arrival.ToString())[1];
                        connectionForDisplay.Abfahrt = SeparateDateTime(connection.From.Departure.ToString())[1];
                        connectionForDisplay.Dauer = connection.Duration.ToString();
                        if(connection.To.Platform != null) connectionForDisplay.Kante = connection.To.Platform.ToString();

                        connectionsForDisplay.Add(connectionForDisplay);                  
                }
                return connectionsForDisplay;
            }
            return null;
        }
        public Stations getStations(string searchTerm)
        {
            if (!String.IsNullOrEmpty(searchTerm))
            {
                Stations stations = transport.GetStations(searchTerm);

                //if(stations.StationList.Count == 0)
                //{
                //    MessageBox.Show("Keine Stationen mit diesem Namen gefunden");
                //    return null;
                //}

                return stations;
            }
            return null;
        }

        public List<StationboardForDisplay> getStationBoard(string location)
        {
            Console.WriteLine(location);
            if (!String.IsNullOrEmpty(location))
            {
                List<StationboardForDisplay> stationboardsForDisplay = new List<StationboardForDisplay>();
                StationBoardRoot stationboard = transport.GetStationBoard(location, null);
                
                foreach(StationBoard entry in stationboard.Entries)
                {
                    StationboardForDisplay stationboardForDisplay = new StationboardForDisplay();
                    stationboardForDisplay.Nach = entry.To;
                    stationboardForDisplay.Bezeichnung = entry.Category.ToString() + entry.Number.ToString();
                    stationboardForDisplay.Abfahrt = SeparateDateTime(entry.Stop.Departure.ToString())[1];

                    stationboardsForDisplay.Add(stationboardForDisplay);
                }

                return stationboardsForDisplay;
            }

            return null;
        }


        public string[] SeparateDateTime(string input)
        {
            string[] array = input.Split(" ");
            return array;
        }
    }
}
