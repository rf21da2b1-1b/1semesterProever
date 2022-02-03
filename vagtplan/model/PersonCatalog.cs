using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vagtplan.model
{
    public class PersonCatalog
    {
        /*
         * instans felter -- her 1-mange relation (aggregering) til person
         */
        private List<Person> _personer;




        /*
         * Konstruktør
         */
        public PersonCatalog()
        {
            _personer = new List<Person>();
        }



        /*
         * Metoder
         */
        public void Add(Person person)
        {
            _personer.Add(person);
        }

        public void PrintAll()
        {
            Console.WriteLine(" Personer i kataloget ");
            foreach (Person p in _personer)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }

        public Person GetById(int id)
        {
            Person returværdi = null;
            
            foreach (Person p in _personer)
            {
                if (p.AnsatId == id)
                {
                    returværdi = p;
                }
            }

            if (returværdi == null)
            {
                throw new KeyNotFoundException("No person with id = " + id);
            }

            return returværdi;
        }

        public Person GetById2(int id)
        {
            Person returværdi = null;

            foreach (Person p in _personer)
            {
                if (p.AnsatId == id)
                {
                    return p;
                }
            }
            
            throw new KeyNotFoundException("No person with id = " + id);
            
        }

        public List<Person> GetByName(String name)
        {
            List<Person> returVærdi = new List<Person>();

            foreach (Person p in _personer)
            {
                if (p.Navn == name)
                {
                    returVærdi.Add(p);
                }
            }

            if (returVærdi.Count == 0)
            {
                throw new ArgumentException("No persons with name = " + name);
            }

            return returVærdi;
        }


        /*
         * ToString
         */
        // todo

    }
}
