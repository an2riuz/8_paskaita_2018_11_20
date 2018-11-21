using _8_paskaita_2018_11_20.Classes;
using System;
using System.Collections.Generic;

namespace _8_paskaita_2018_11_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Ducati Ducati1 = new Ducati("Monster", 2010, "Red", true);
            Ducati Ducati2 = new Ducati("Panigale", 2018, "Ducati Red", true);

            Honda Honda1 = new Honda("CBR650F", 2017, "Black", true);
            Yamaha Yamaha1 = new Yamaha("R1", 1999, "Blue", false);
            Kawasaki Kawasaki1 = new Kawasaki("ZX10R", 2012, "Green", true);
            Suzuki Suzuki1 = new Suzuki("Bandit", 1998, "Yellow", false);

            Console.WriteLine(Ducati1.Color + Honda1.Model + Ducati2.Model);
            Console.ReadKey();
        }
    }
}
