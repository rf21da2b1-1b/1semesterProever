using System;

namespace vagtplan
{
    class Program
    {
        static void Main(string[] args)
        {
            VagtWorker worker = new VagtWorker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
