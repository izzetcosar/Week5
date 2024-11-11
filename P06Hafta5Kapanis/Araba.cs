using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Hafta5Kapanis
{
    class Araba //araba classının propertylerini ekliyoruz.
    {
        public DateTime UretimTarihi { get; private set; } 
        public string SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now; //Date kayıt anı olarak belirlendi.
        }

    }
}
