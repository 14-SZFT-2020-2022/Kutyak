using System;
using System.Collections.Generic;
using Kutyak.Objektumok;
using Kutyak.FileKezeles;
using System.Linq;

namespace Kutyak.Feladatok
{
    class TizedikFeladat
    {
        static public void Megoldas(List<Kutya> kutyaLista, List<KutyaNev> kutyaNevLista)
        {
            Console.WriteLine("10. Feladat: nevstatisztika.txt");

            Dictionary<int, int> konyvtar = new Dictionary<int, int>();

            foreach (Kutya elem in kutyaLista)
            {
                bool vanE = true;

                foreach (KeyValuePair<int, int> item in konyvtar)
                {
                    if (item.Key == elem.NevId)
                    {
                        int adat = item.Value;
                        vanE = false;
                        konyvtar.Remove(item.Key);
                        konyvtar.Add(elem.NevId, ++adat);
                        break;
                    }
                }

                if (vanE)
                {
                    konyvtar.Add(elem.NevId, 1);
                }
            }

            IEnumerable<KeyValuePair<int, int>> sorbaRak =
                from elem in konyvtar
                orderby elem.Value descending
                select elem;

            string kiir = "";

            foreach (KeyValuePair<int, int> elem in sorbaRak)
            {
                foreach (KutyaNev item in kutyaNevLista)
                {
                    if (elem.Key == item.Azonosito)
                    {
                        kiir += $"{item.Nev}: {elem.Value}\n";
                    }
                }
            }

            FileKiir kiiras = new FileKiir("nevstatisztika.txt");
            kiiras.Kiiras(kiir);
        }
    }
}
