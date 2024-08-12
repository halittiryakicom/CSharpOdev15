using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev15
{
    internal class Car
    {
        //Özellikler
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        private int _kapiSayisi;

        //encapsulation
        public int KapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                if (!(value==2 || value==4))
                {
                    Console.WriteLine("Arabalarımız da sadece 2 veya 4 kapı bulunur.");
                    _kapiSayisi = -1;
                }
                else
                    _kapiSayisi=value;
            }
        }

        // Constructor (Yapıcı Metot)
        public Car(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }

        //arabanın özelliklerini çağırma
        public void ArabaBilgileriniGoster()
        {
            Console.WriteLine($"Araba: Marka: {Marka}\n, Model: {Model}\n, Renk: {Renk}\n, Kapı Sayısı: {_kapiSayisi}");
        }

    }
}
