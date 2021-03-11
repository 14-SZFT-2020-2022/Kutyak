using System;
using System.Collections.Generic;
using Kutyak.FileKezeles;
using Kutyak.Objektumok;

namespace Kutyak.Feladatok
{
    class Megoldas
    {
        static public void Feladatok()
        {
            FileBeolvas kutyaNevek = new FileBeolvas("kutyaNevek.csv");
            List<KutyaNev> kutyaNevLista = KutyaNev.KutyaNevListaLetrehozasa(kutyaNevek.ListaLetrehozas(';'));
            FileBeolvas kutyaFajtak = new FileBeolvas("kutyaFajtak.csv");
            List<KutyaFajta> kutyaFajtaLista = KutyaFajta.KutyaFajtaListaLetrehozasa(kutyaFajtak.ListaLetrehozas(';'));
            FileBeolvas kutyak = new FileBeolvas("kutyak.csv");
            List<Kutya> kutyaLista = Kutya.KutyaListaLetrehozasa(kutyak.ListaLetrehozas(';'));
            HarmadikFeladat.Megoldas(kutyaNevLista);
            HatodikFeladat.Megoldas(kutyaLista);
            HetedikFeladat.Megoldas(kutyaLista, kutyaNevLista, kutyaFajtaLista);
            NyolcadikFeladat.Megoldas(kutyaLista, kutyaFajtaLista);
            KilencedikFeladat.Megoldas(kutyaLista);
            TizedikFeladat.Megoldas(kutyaLista, kutyaNevLista);

            Console.ReadKey(true);
        }
    }
}
