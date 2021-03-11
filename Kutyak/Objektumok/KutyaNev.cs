using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak.Objektumok
{
    class KutyaNev
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }

        public KutyaNev(string azonosito, string nev)
        {
            this.Azonosito = Int32.Parse(azonosito);
            this.Nev = nev;
        }

        static public List<KutyaNev> KutyaNevListaLetrehozasa(List<string[]> lista)
        {
            List<KutyaNev> kutyaNevlista = new List<KutyaNev>();

            foreach (string[] elem in lista)
            {
                KutyaNev kn = new KutyaNev(elem[0], elem[1]);
                kutyaNevlista.Add(kn);
            }

            return kutyaNevlista;
        }
    }
}
