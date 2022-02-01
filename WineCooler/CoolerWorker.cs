using System;
using System.Collections.Generic;
using WineCooler.model;

namespace WineCooler
{
    public class CoolerWorker
    {
        public CoolerWorker()
        {
        }

        public void Start()
        {
            Wine w1 = new Wine("Rød", "Caix", 98);
            Wine w2 = new Wine("Hvid", "Loire", 114);
            Wine w3 = new Wine("Rose", "Provance", 85);
            Wine w4 = new Wine();

            Console.WriteLine("Udskriver de tre vine");
            Console.WriteLine(w1.ToString());   // eksplicit kald af Tostring
            Console.WriteLine(w2);              // implicit kald af ToString
            Console.WriteLine(w3);
            Console.WriteLine(w4);


            model.WineCooler cooler = new model.WineCooler(6, 15.5, 7);
            cooler.PrintAll();

            cooler.Add(w1);
            cooler.Add(w2);
            cooler.Add(w3);
            cooler.Add(w4);
            cooler.Add(w1);
            cooler.PrintAll();


            Console.WriteLine("Hvid vine");
            cooler.Add(w2); 
            cooler.Add(w2);
            List<Wine> hvidvine = cooler.GetWhiteWine();
            foreach (Wine hvid in hvidvine)
            {
                Console.WriteLine(hvid);
            }


            // Exceptions

            try
            {
                cooler.Add(w1);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("Fejl: " + ae.Message);
            }

            /*
             * fyldt
             */
            model.WineCooler cooler2 = new model.WineCooler(1, 12, 10);

            for (int i = 0; i < 11; i++)
            {
                try
                {
                    String farve = cooler2.Add(w1);
                    Console.WriteLine($"flaske {i+1} farve {farve}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Skabet er fyldt");
                }
            }


        }
    }
}