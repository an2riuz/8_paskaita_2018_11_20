using System;
using System.Collections.Generic;
using System.Text;

namespace _8_paskaita_2018_11_20.Classes
{
    class Suzuki
    {
        // duomenys
        public string Model;
        private int Year;
        public string Color;
        private bool Immobilizer;

        // konstruktorius
        public Suzuki(string bikeModel, int yearMade, string mainColor, bool hasImmobilizer)
        {
            Model = bikeModel;
            Year = yearMade;
            Color = mainColor;
            Immobilizer = hasImmobilizer;
        }


        //metodai
        public void StartingEngine()
        {

        }

        private void HowToWheelie()
        {

        }
    }
}
