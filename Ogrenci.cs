using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevApp
{
    public class Ogrenci
    {
        public int Nu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SinifId { get; set; } //10A --> 1, 10B --> 2
        public string Ders { get; set; }
        public string OdevKonusu { get; set; }
        public bool OdevYaptiMi { get; set; }
        public double Puan { get; set; }

        public string Bilgi
        {
            get { return $"{Nu} - {Ad} {Soyad}"; }
        }
    }
}
