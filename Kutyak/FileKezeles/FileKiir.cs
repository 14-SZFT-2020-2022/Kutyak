using System.Text;
using System.IO;

namespace Kutyak.FileKezeles
{
    class FileKiir
    {
        public string FileNev { get; set; }

        public FileKiir(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public void Kiiras(string kiir)
        {
            using (StreamWriter sw = new StreamWriter(this.FileNev, false, Encoding.UTF8))
            {
                sw.Write(kiir);
            }
        }
    }
}
