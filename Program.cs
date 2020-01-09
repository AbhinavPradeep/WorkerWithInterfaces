using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IWorker worker = null;

            System.Console.WriteLine("Who do you need");
            string need = Console.ReadLine();

            worker = SelectWorker(need);
            MakeSelectedWorkerWork(worker);   
            
        }

        private static void MakeSelectedWorkerWork(IWorker worker)
        {
            System.Console.WriteLine($"We have {worker.name} on hold");
            worker.Work();
        }

        private static IWorker SelectWorker(string need)
        {
            IWorker worker = null;

            if(need == "Chippy" || need == "Carpenter" )
            {
                //simulating work
                worker = new Chippy();
                worker.name = "HelpfulHarry";                
            }
            if(need == "Plumby" || need == "Plumber")
            {
                //simulating work
                worker = new Plumby();
                worker.name = "HelpfulHarry";               
            }
            if(need == "Sparky" || need == "Electrition")
            {
                //simulating work
                worker  = new Sparky();
                worker.name = "HelpfulHarry";               
            }

            return worker;
        }
    }
}
