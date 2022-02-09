using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwissTransportGui
{
    public class Mail
    {
        public string Body { get; set; }
        private string subject = "ÖV- Verbindung";

        public Mail(string body)
        {

            Body = body;
        }

        public void SendMail()
        {
            Process.Start(new ProcessStartInfo("mailto:" + "" + "?subject=" + subject + "&body="
            + Body) { UseShellExecute = true });
        }
    }
}
