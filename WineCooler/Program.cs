using System;

namespace WineCooler
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolerWorker worker = new CoolerWorker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
