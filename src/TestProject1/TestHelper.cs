using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransportGui;
using SwissTransport.Models;
using NUnit.Framework;

namespace TestProject1
{
    public class TestHelper
    {
        private Helper helper;
        [SetUp]
        public void Setup()
        {
            helper = new Helper();
        }


        [TestCase("  ", "  ", ExpectedResult = true)]
        [TestCase("Luzern", " ", ExpectedResult = true)]
        [TestCase(" ", "Bern", ExpectedResult = true)]

        public bool TestGetConnections(string departure, string destination)
        {
            var result = helper.GetConnections(departure, destination);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [TestCase("Luzern", "Sursee", "2022-02-12", "09:00", ExpectedResult = true)]
        [TestCase("Luzern", "Sursee", "2022-02-12", "", ExpectedResult = true)]
        [TestCase("Luzern", "Sursee", "", "09:00", ExpectedResult = true)]
        public bool TestGetConnectionsDateTime(string departure, string destination, string date, string time)
        {

            List<ConnectionForDisplay>? results = helper.GetConnections(departure, destination, date, time);
            if (results != null)
            {
                if (results.Count != 0)
                {
                    foreach (ConnectionForDisplay result in results)
                    {
                        Console.WriteLine(result.Abfahrtsort + result.Ankunftsort);
                        if (result.Abfahrtsort == "Luzern" && result.Ankunftsort == "Sursee")
                        {
                            if (date == "") return true;
                            if (date != "")
                            {
                                StringAssert.Contains("12.02.2022", result.Abfahrt);

                            }
                            return true;
                        }
                    }
                }
            }
            return false;

        }


        [TestCase("", ExpectedResult = false)]
        [TestCase("*&/()", ExpectedResult = false)]
        [TestCase("Luz", ExpectedResult = true)]
        [TestCase("Luzern", ExpectedResult = true)]
        public bool TestGetStations(string searchTerm)
        {
            Stations? results = helper.GetStations(searchTerm);


            if (results != null && results.StationList.Count != 0)
            {
                foreach (Station station in results.StationList)
                {
                    StringAssert.Contains(searchTerm, station.Name);
                    
                }
                return true;
            }

            return false;

        }


        [TestCase("", ExpectedResult = false)]
        [TestCase("*&/()", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = false)]
        [TestCase("Lu", ExpectedResult = true)]
        [TestCase("Luzern", ExpectedResult = true)]

        public bool TestGetStationBoard(string location)
        {
            List<StationboardForDisplay>? results = helper.GetStationBoard(location);
            
            if(results !=null && results.Count > 0)
            {
                return true;
            }
            return false;

        }

        [TestCase(null, null, ExpectedResult = false)]
        [TestCase(47.050174, 8.310185, ExpectedResult = true)]
        [TestCase(null, 8.310185, ExpectedResult = false)]
        [TestCase(47.050174, null, ExpectedResult = false)]
        public bool TestGetNearestStations(double x, double y)
        {
            Coordinate coordinate = new Coordinate();
            coordinate.XCoordinate = x;
            coordinate.YCoordinate = y;

            List<Station>? results = helper.GetNearestStations(coordinate);

            if (results != null)
            {
                foreach(Station result in results)
                {
                    Assert.IsNotEmpty(result.Name);
                    Assert.IsNotNull(result.Distance);     
                }
                return true;
            }
            return false;

        }

        [TestCase("01.02.2022 09:43:23")]
        public void TestSeparateDateTime(string input)
        {
            string[] results = helper.SeparateDateTime(input);
            StringAssert.Contains(results[0], input);
            StringAssert.Contains(results[1], input);
            
        }


    }  
}
