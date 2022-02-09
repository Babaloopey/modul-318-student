using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGui
{
    public class StationboardForDisplay
    {
        public string Nach { get; set; }
        public string Bezeichnung { get; set; }
        public string Abfahrt { get; set; }

        public StationboardForDisplay()
        {
            Nach = "";
            Bezeichnung = "";
            Abfahrt = "";
        }
    }
}
