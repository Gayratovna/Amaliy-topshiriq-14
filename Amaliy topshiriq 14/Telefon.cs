using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq_14
{
    public class Telefon
    {
        public string Raqam { get; set; }
        public string EgalIsmi { get; set; }
        public string SozlashuvVaqt { get; set; }

        public Telefon(string raqam, string egalIsmi, string sozlashuvVaqt)
        {
            Raqam = raqam;
            EgalIsmi = egalIsmi;
            SozlashuvVaqt = sozlashuvVaqt;
        }
    }
}
