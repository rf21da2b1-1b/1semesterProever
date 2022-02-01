using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCooler.model
{
    public class WineCooler
    {
        /*
         * instans felter -- her properties
         */
        private int _coolerId;
        private double _temperature;
        private int _capacity;



        /*
         * instans felter -- her 1-mange relation (aggregering) til Wine
         */
        private List<Wine> _wines;


        /*
         * Konstruktør
         */
        public WineCooler(int id, double temperature, int capacity)
        {
            _coolerId = id;
            _temperature = temperature;
            _capacity = capacity;


            _wines = new List<Wine>();
        }



        /*
         * Metoder
         */
        public string Add(Wine nyVin)
        {
            string returVærdi = "";

            int pladserTilbage = _capacity - _wines.Count;

            if (pladserTilbage == 0)
            {
                throw new ArgumentOutOfRangeException("Cooler er allered fyldt");
            }


            _wines.Add(nyVin);

            // hvor fyldt er skabet
            pladserTilbage--;

            double procent = pladserTilbage * 100.0 / _capacity;

            if (procent < 20)
            {
                returVærdi = "rød";
            }
            else if (procent < 50)
            {
                returVærdi = "gul";
            }
            else
            {
                returVærdi = "grøn";
            }

            
            return returVærdi;
        }


        public void PrintAll()
        {
            Console.WriteLine("Vine i Vin køleskabet");
            foreach (Wine w in _wines)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine();
        }


        public List<Wine> GetWhiteWine()
        {
            List<Wine> returVærdi = new List<Wine>();

            foreach (Wine w in _wines)
            {
                if (w.WineType.ToLower() == "hvid")
                {
                    returVærdi.Add(w);

                }
            }
            

            return returVærdi;
        }



        /*
         * ToString
         */
    }
}
