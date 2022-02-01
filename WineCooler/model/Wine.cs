using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCooler.model
{
    public class Wine
    {
        /*
         * instans felter (attributter)
         */
        private String _wineType; // kunne være en enum -- men i opgaven står der at den er string
        private String _navn;
        private double _price;
        

        /*
         * Properties
         */
        public string WineType
        {
            get => _wineType;
            set => _wineType = value;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }


        /*
         * Konstruktører
         */
        public Wine():this("","",0)
        {
        }

        public Wine(string wineType, string navn, double price)
        {
            _wineType = wineType;
            _navn = navn;
            _price = price;
        }


        /*
         * Tostring
         */
        public override string ToString()
        {
            return $"{nameof(WineType)}: {WineType}, {nameof(Navn)}: {Navn}, {nameof(Price)}: {Price}";
        }
    }
}
