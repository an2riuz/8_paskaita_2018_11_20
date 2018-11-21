using System;
using System.Collections.Generic;

namespace _8_paskaita_2018_11_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pakartokime list
            List<string> zodziai = new List<string>() {"vienas", "du", "trys"};

            zodziai.Add("testas");
            zodziai.Insert(2, "kart du");

            Console.WriteLine(" " + zodziai);
            Console.ReadKey();
        }
    }
}
