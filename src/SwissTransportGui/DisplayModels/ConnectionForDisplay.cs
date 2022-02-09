using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGui
{
    public class ConnectionForDisplay
    {
        public string Abfahrtsort { get; set; }
        public string Abfahrt { get; set; }

        public string Ankunftsort { get; set; }
        public string Ankunft { get; set; }

        public string Dauer { get; set; }
        public string Kante { get; set; }

        public ConnectionForDisplay()
        {
            Abfahrtsort = "";
            Abfahrt = "";
            Ankunftsort = "";
            Ankunft = "";
            Dauer = "";
            Kante = "";
        }

       

    }
}
