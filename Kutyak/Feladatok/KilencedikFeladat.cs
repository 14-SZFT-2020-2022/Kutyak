using System;
using System.Collections.Generic;
using Kutyak.Objektumok;

namespace Kutyak.Feladatok
{
    class KilencedikFeladat
    {
        static public void Megoldas(List<Kutya> lista)
        {   
            Dictionary<DateTime, int> konytar = new Dictionary<DateTime, int>();

            foreach (Kutya elem in lista)
            {
                bool vanE = true;

                foreach (KeyValuePair<DateTime, int> item in konytar)
                {
                    if (DateTime.Compare(elem.UtolsoVizsgalat, item.Key) == 0)
                    {
                        int adat = item.Value;
                        vanE = false;
                        konytar.Remove(item.Key);
                        konytar.Add(elem.UtolsoVizsgalat, ++adat);
                        break;
                    }
                }

                if (vanE)
                {
                    konytar.Add(elem.UtolsoVizsgalat, 1);
                }
            }

            DateTime terheltNap = new DateTime();
            int legtobb = 0;

            foreach (KeyValuePair<DateTime, int> item in konytar)
            {
                if (item.Value > legtobb)
                {
                    terheltNap = item.Key;
                    legtobb = item.Value;
                }
            }
                
            Console.WriteLine($"9. Feladat: Legjobban leterhelt nap: {terheltNap.ToShortDateString()}: {legtobb} kutya");
        }
    }
}
