using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vagtplan.model
{
    public class Person
    {
        /*
        * instans felter (attributter)
        */
        private int _ansatId;
        private String _navn;
        private String _telefon;

        /*
        * properties
        */
        public int AnsatId
        {
            get => _ansatId;
            //set => _ansatId = value; - Skal kun kunne læse AnsatId - kan ikke ændre det efter objektet er oprettet
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Telefon
        {
            get => _telefon;
            set => _telefon = value;
        }

        /*
         * Konstruktører, benyttes når der oprettes et objekt (dvs. new Person(...))
         */
        public Person():this(0,"","")
        {
        }

        public Person(int ansatId, string navn, string telefon)
        {
            _ansatId = ansatId;
            _navn = navn;
            _telefon = telefon;
        }

        /*
        * To string, samler objektes informationer (properties) i en tekst streng / string) 
        */
        public override string ToString()
        {
            return $"{nameof(AnsatId)}: {AnsatId}, {nameof(Navn)}: {Navn}, {nameof(Telefon)}: {Telefon}";
        }
    }
}
