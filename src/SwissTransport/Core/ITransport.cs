namespace SwissTransport.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnectionsWithDateTime(string fromStation, string toStation, string date, string time);

        List<Station> GetNearestStations(double? xCoordinate, double? yCoordinate);
    }
}