namespace SwissTransport.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using SwissTransport.Models;

    public class Transport : ITransport, IDisposable
    {
        private const string WebApiHost = "https://transport.opendata.ch/v1/";

        private readonly HttpClient httpClient = new HttpClient();

        public Stations GetStations(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var uri = new Uri($"{WebApiHost}locations?query={query}&type=station");
            return this.GetObject<Stations>(uri);
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }

            

            string adress = $"{WebApiHost}stationboard?station={station}";
            if (id != null)
            {
                adress += ($"&id={id}");
            }

            var uri = new Uri(adress);
            return this.GetObject<StationBoardRoot>(uri);
        }

        public Connections GetConnections(string fromStation, string toStation)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}");
            return this.GetObject<Connections>(uri);
        }

        public Connections GetConnectionsWithDateTime(string fromStation, string toStation, string date, string time)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&date={date}&time={time}");
            return this.GetObject<Connections>(uri);
        }

        public List<Station> GetNearestStations(double? xCoordinate, double? yCoordinate)
        {
            var uri = new Uri($"https://fahrplan.search.ch/api/completion.json?latlon={xCoordinate},{yCoordinate}&accuracy=10&show_coordinates=1");
            


            HttpResponseMessage response = this.httpClient
                .GetAsync(uri)
                .GetAwaiter()
                .GetResult();
            string content = response.Content
                .ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            List<NearStation> nearStations = JsonConvert.DeserializeObject<List<NearStation>>(content);
            List<Station> stations = new List<Station>();

            foreach (NearStation nearStation in nearStations)
            {
                Station station = new Station();
                station.Name = nearStation.label;
                station.Coordinate = new Coordinate();
                station.Coordinate.XCoordinate = nearStation.lat;
                station.Coordinate.YCoordinate = nearStation.lon;
                station.Distance = nearStation.dist;

                Console.WriteLine(station.Name);
                Console.WriteLine(station.Coordinate.XCoordinate);
                Console.WriteLine(station.Coordinate.YCoordinate);
                Console.WriteLine(station.Distance);

                stations.Add(station);
            }

            return stations;
        }

      //  http://transport.opendata.ch/v1/connections?from=bern&to=luzern&date=2022-07-02&time=06:50

        public void Dispose()
        {
            this.httpClient?.Dispose();
        }

        private T GetObject<T>(Uri uri)
        {
            HttpResponseMessage response = this.httpClient
                .GetAsync(uri)
                .GetAwaiter()
                .GetResult();
            string content = response.Content
                .ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}