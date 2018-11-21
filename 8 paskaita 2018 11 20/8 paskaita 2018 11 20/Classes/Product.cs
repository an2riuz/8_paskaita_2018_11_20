using System;
using System.Collections.Generic;
using System.Text;

namespace _8_paskaita_2018_11_20.Classes
{
    class Product
    {
        // duomenys
        public string Pavadinimas;
        public int Kiekis;
        public float Svoris;
        public int galiojimoData;
        public string prekesVieta;

        // konstruktorius

        public Product(string prekesPavadinimas, int prekesKiekis, float prekesSvoris, int prekesGaliojimoData, string prekesVieta)
        {
            Pavadinimas = prekesPavadinimas;
            Kiekis = prekesKiekis;
            Svoris = prekesSvoris;
            galiojimoData = prekesGaliojimoData;
            this.prekesVieta = prekesVieta;
        }
        
        // metodai
        public void PrekesAprasymas()
        {
            Console.WriteLine("{0} yra padeta {1}, kiekis {2}, galiojimo data {3}",Pavadinimas,prekesVieta,Kiekis,galiojimoData );
        }
    }
}
