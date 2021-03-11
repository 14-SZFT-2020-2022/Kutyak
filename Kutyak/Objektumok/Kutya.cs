using System;
using System.Collections.Generic;

namespace Kutyak.Objektumok
{
    class Kutya
    {
        public int Azonosito { get; set; }
        public int FajtaId { get; set; }
        public int NevId { get; set; }
        public int Eletkor  { get; set; }
        public DateTime UtolsoVizsgalat { get; set; }

        public Kutya(string azonosito, string fajtaId, string nevId, string eletkor, string utolsoVizsgalat)
        {
            this.Azonosito = Int32.Parse(azonosito);
            this.FajtaId = Int32.Parse(fajtaId);
            this.NevId = Int32.Parse(nevId);
            this.Eletkor = Int32.Parse(eletkor);
            this.UtolsoVizsgalat = DateTime.Parse(utolsoVizsgalat);
        }

        static public List<Kutya> KutyaListaLetrehozasa(List<string[]> lista)
        {
            List<Kutya> kutyalista = new List<Kutya>();

            foreach (string[] elem in lista)
            {
                Kutya kn = new Kutya(elem[0], elem[1], elem[2], elem[3], elem[4]);
                kutyalista.Add(kn);
            }

            return kutyalista;
        }
    }
}
