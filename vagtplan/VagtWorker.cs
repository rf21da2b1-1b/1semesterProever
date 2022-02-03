using System;
using System.Collections.Generic;
using vagtplan.model;

namespace vagtplan
{
    public class VagtWorker
    {
        public VagtWorker()
        {
        }

        public void Start()
        {
            Person p1 = new Person(1, "peter", "22334455");
            Person p2 = new Person(2, "jakob", "11223344");
            Person p3 = new Person(3, "charlotte", "12345678");
            Person p4 = new Person();

            Console.WriteLine("Udskriver de tre personer");
            Console.WriteLine(p1.ToString()); // kalder ToString eksplicit
            Console.WriteLine(p2);            // kalder ToString implicit
            Console.WriteLine($"Person id={p3.AnsatId} navn={p3.Navn} tlf ({p3.Telefon})"); // udskriver selv properties
            Console.WriteLine(p4);

            PersonCatalog katalog = new PersonCatalog();

            katalog.Add(p1);
            katalog.Add(p2);
            katalog.Add(p3);
            katalog.Add(p4);

            katalog.PrintAll();

            // ID
            Person personFundet = katalog.GetById(3);
            Console.WriteLine("Fundet ved id 3 = ");
            Console.WriteLine(personFundet);



            // Navn
            List<Person> personerFundet = katalog.GetByName("peter");
            Console.WriteLine("Personer med navn peter (1 forekomst)");
            foreach (Person p in personerFundet)
            {
                Console.WriteLine(p);
            }


            // to med samme navn
            katalog.Add(p1); // peter tilføjes anden gang
            personerFundet = katalog.GetByName("peter");
            Console.WriteLine("Personer med navn peter (2 forekomster)");
            foreach (Person p in personerFundet)
            {
                Console.WriteLine(p);
            }


            // Planner
            Planner pl1 = new Planner(6, "anders", "66778899", "Roskilde");
            katalog.Add(pl1);
            katalog.PrintAll();



            // ID findes ikke

            try
            {
                personFundet = katalog.GetById(33);
                Console.WriteLine("Fundet ved id 33 = ");
                Console.WriteLine(personFundet);
            }
            catch (KeyNotFoundException knfe)
            {
                Console.WriteLine("FEJL: " + knfe.Message);
            }


            // Navn findes ikke

            try
            {
                personerFundet = katalog.GetByName("retep");
                Console.WriteLine("Personer med navn peter (1 forekomst)");
                foreach (Person p in personerFundet)
                {
                    Console.WriteLine(p);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("FEJL: " + ae.Message);
            }
            catch (Exception e)
            {
                // for alle sikkerheds skyld
                Console.WriteLine(e.Message);
            }



        }
    }
}