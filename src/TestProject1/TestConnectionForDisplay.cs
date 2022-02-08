using NUnit.Framework;
using SwissTransportGui;

namespace TestProject1
{
    public class TestConnectionForDisplay
    {
        private ConnectionForDisplay connectionForDisplay;
        [SetUp]
        public void Setup()
        {
            
            connectionForDisplay = new ConnectionForDisplay();

            connectionForDisplay.Dauer = "00:00:01";
            connectionForDisplay.Kante = "Kante 1";
            connectionForDisplay.Abfahrtsort = "Beinwil";
            connectionForDisplay.Abfahrt = "15:40";
            connectionForDisplay.Ankunftsort = "Beromünster";
            connectionForDisplay.Ankunft = "16:30";
        }

        [Test]
        public void CheckConnectionForDisplay()
        {

            Assert.IsTrue(connectionForDisplay.Dauer == "00:00:01");
            Assert.IsTrue(connectionForDisplay.Kante == "Kante 1");
            Assert.IsTrue(connectionForDisplay.Abfahrtsort == "Beinwil");
            Assert.IsTrue(connectionForDisplay.Abfahrt == "15:40");
            Assert.IsTrue(connectionForDisplay.Ankunftsort == "Beromünster");
            Assert.IsTrue(connectionForDisplay.Ankunft == "16:30");



        }
    }
}