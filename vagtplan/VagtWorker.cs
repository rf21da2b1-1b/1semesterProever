using System;
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

            Console.WriteLine("Udskriver de tre personer");
            Console.WriteLine(p1.ToString()); // kalder ToString eksplicit
            Console.WriteLine(p2);            // kalder ToString implicit
            Console.WriteLine($"Person id={p3.AnsatId} navn={p3.Navn} tlf ({p3.Telefon})"); // udskriver selv properties






        }
    }
}