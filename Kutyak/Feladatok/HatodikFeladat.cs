using System;
using System.Collections.Generic;
using Kutyak.Objektumok;

namespace Kutyak.Feladatok
{
    class HatodikFeladat
    {
        static public void Megoldas(List<Kutya> lista)
        {
            int osszeletkor = 0;

            foreach (Kutya elem in lista)
            {
                osszeletkor += elem.Eletkor;
            }

            double atlag = (double)osszeletkor / lista.Count;

            Console.WriteLine($"6. Feladat: Kutyák átlagéletkora: {atlag:F2}");
        }
    }
}
