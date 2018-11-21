using System;
using System.Collections.Generic;
using System.Text;

namespace _8_paskaita_2018_11_20.Classes
{
    class Yamaha
    {
        // duomenys
        private string Model;
        private int Year;
        private string Color;
        private bool Immobilizer;

        // konstruktorius
        public Yamaha(string bikeModel, int yearMade, string mainColor, bool hasImmobilizer)
        {
            Model = bikeModel;
            Year = yearMade;
            Color = mainColor;
            Immobilizer = hasImmobilizer;
        }


        //metodai
        public void Review()
        {
            if (Immobilizer == true)
            {
                Console.WriteLine("{0} has been made {1}, painted in {2}. It has security feature Immobilizer.", Model, Year, Color, Immobilizer);
            }
            else
            {
                Console.WriteLine("{0} has been made {1}, painted in {2}.", Model, Year, Color);
            }

        }
        public void StartingEngine()
        {

        }

        private void HowToWheelie()
        {

        }
    }
}
