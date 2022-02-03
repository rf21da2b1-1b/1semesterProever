using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vagtplan.model
{
    public class Planner: Person
    {
        /*
         * instans felter (attributter)
         */
        private string _testSted;
        

        /*
         * Properties
         */
        public string TestSted
        {
            get => _testSted;
            set => _testSted = value;
        }


        /*
         * Konstruktører
         */
        public Planner():base()
        {
            _testSted = "";
        }

        public Planner(int id, string name, string telefon, string teststed):base(id,name,telefon)
        {
            _testSted = teststed;
        }




        /*
         * Tostring
         */
        public override string ToString()
        {
            return $"{base.ToString()}, TestSted={_testSted}";
        }
    }
}
