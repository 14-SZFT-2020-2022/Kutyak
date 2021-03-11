using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak.FileKezeles
{
    class FileBeolvas
    {
        public string FileNev { get; set; }

        public FileBeolvas(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public List<string[]> ListaLetrehozas(char delimiter)
        {
            List<string[]> lista = new List<string[]>();

            using (StreamReader sr = new StreamReader(this.FileNev, Encoding.UTF8))
            {
                string elsoSor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine().Trim();
                    string[] tomb = sor.Split(delimiter);

                    lista.Add(tomb);
                }
            }

            return lista;
        }
    }
}
