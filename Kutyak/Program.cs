using System;
using System.Collections.Generic;
using Kutyak.FileKezeles;
using Kutyak.Feladatok;
using Kutyak.Objektumok;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
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


            Console.ReadKey(true);
        }
    }
}
