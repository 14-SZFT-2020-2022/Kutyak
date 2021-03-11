using System;
using System.Collections.Generic;
using Kutyak.Objektumok;

namespace Kutyak.Feladatok
{
    class NyolcadikFeladat
    {
        static public void Megoldas(List<Kutya> kutyaLista, List<KutyaFajta> kutyaFajtaLista)
        {
            Console.WriteLine("8. Feladat: 2018 Január 10.-én vizsgált kutya fajták: ");

            Dictionary<int, int> konyvtar = new Dictionary<int, int>();

            foreach (Kutya elem in kutyaLista)
            {
                if (DateTime.Compare(elem.UtolsoVizsgalat, new DateTime(2018,01,10)) == 0)
                {
                    bool vanE = true;

                    foreach (KeyValuePair<int, int> item in konyvtar)
                    {
                        if (item.Key == elem.FajtaId)
                        {
                            int adat = item.Value;
                            vanE = false;
                            konyvtar.Remove(item.Key);
                            konyvtar.Add(elem.FajtaId, ++adat);
                            break;
                        }
                    }

                    if (vanE)
                    {
                        konyvtar.Add(elem.FajtaId, 1);
                    }
                }
            }

            foreach (KeyValuePair<int, int> elem in konyvtar)
            {
                foreach (KutyaFajta item in kutyaFajtaLista)
                {
                    if (elem.Key == item.Azonosito)
                    {
                        Console.WriteLine($"\t{item.Nev}: {elem.Value} kutya");
                    }
                }
            }
        }
    }
}
