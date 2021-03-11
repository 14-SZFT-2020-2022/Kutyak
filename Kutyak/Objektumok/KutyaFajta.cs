using System;
using System.Collections.Generic;

namespace Kutyak.Objektumok
{
    class KutyaFajta
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public string EredetiNev { get; set; }

        public KutyaFajta(string azonosito, string nev, string eredetiNev)
        {
            this.Azonosito = Int32.Parse(azonosito);
            this.Nev = nev;
            this.EredetiNev = eredetiNev;
        }

        static public List<KutyaFajta> KutyaFajtaListaLetrehozasa(List<string[]> lista)
        {
            List<KutyaFajta> kutyaFajtalista = new List<KutyaFajta>();

            foreach (string[] elem in lista)
            {
                KutyaFajta kn = new KutyaFajta(elem[0], elem[1], elem[2]);
                kutyaFajtalista.Add(kn);
            }

            return kutyaFajtalista;
        }
    }
}
