﻿namespace SwissTransport
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public void ConnectionsWithDateTime()
        {
            DateTime comparison = new DateTime(2022, 02, 07, 08, 00, 00);

            Connections connections = this.testee.GetConnectionsWithDateTime("Sursee", "Luzern", "2022-02-07", "08:00");
            connections.Should().NotBeNull();

            foreach (Connection connection in connections.ConnectionList)
            {
                connection.To.Station.Name.Should().Be("Luzern");
                connection.From.Station.Name.Should().Be("Sursee");

                connection.From.Departure.Should().BeAfter(comparison);
            }
        }

        [Fact]
        public void GetNearestStations()
        {
            // Koordinaten von Luzern
            List<Station> stations = this.testee.GetNearestStations(47.050174, 8.310185);

            stations.Should().NotBeNull();

            foreach (Station station in stations)
            {
                station.Distance.Should().NotBeNull();
            }
        }
    }
}