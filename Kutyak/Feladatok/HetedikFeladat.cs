using System;
using System.Collections.Generic;
using Kutyak.Objektumok;

namespace Kutyak.Feladatok
{
    class HetedikFeladat
    {
        static public void Megoldas(List<Kutya> kutyaLista, List<KutyaNev> kutyaNevLista, List<KutyaFajta> kutyaFajtaLista)
        {
            int legidosebb = 0;
            int kutyaNevId = 0;
            string nev = "";
            int kutyaFajtaId = 0;
            string fajta = "";

            foreach (Kutya elem in kutyaLista)
            {
                if (elem.Eletkor > legidosebb)
                {
                    legidosebb = elem.Eletkor;
                    kutyaNevId = elem.NevId;
                    kutyaFajtaId = elem.FajtaId;
                }
            }

            foreach (KutyaNev elem in kutyaNevLista)
            {
                if (elem.Azonosito == kutyaNevId)
                {
                    nev = elem.Nev;
                }
            }

            foreach (KutyaFajta elem in kutyaFajtaLista)
            {
                if (elem.Azonosito == kutyaFajtaId)
                {
                    fajta = elem.Nev;
                }
            }


            Console.WriteLine($"7. Feladat: A legidősebb kutya neve és fajtája: {nev}, {fajta}");
        }
    }
}
