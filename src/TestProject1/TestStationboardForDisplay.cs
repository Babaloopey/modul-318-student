using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwissTransportGui;

namespace TestProject1
{
    internal class TestStationboardForDisplay
    {
        private StationboardForDisplay stationBoardForDisplay;
        [SetUp]
        public void Setup()
        {

            stationBoardForDisplay = new StationboardForDisplay();

            stationBoardForDisplay.Nach = "Luzern, Bahnhof";
            stationBoardForDisplay.Bezeichnung = "S24";
            stationBoardForDisplay.Abfahrt = "17:00";
    
        }

        [Test]
        public void CheckStationBoardForDisplay()
        {

            Assert.IsTrue(stationBoardForDisplay.Nach == "Luzern, Bahnhof");
            Assert.IsTrue(stationBoardForDisplay.Bezeichnung == "S24");
            Assert.IsTrue(stationBoardForDisplay.Abfahrt == "17:00");



        }
    }
}
    

