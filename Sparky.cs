namespace Work
{
    public class Sparky : IWorker
    {
        public string name { get; set; }
        public string work { get { return "Working on circuit"; } }

        public string Work()
        {
            System.Console.WriteLine(work);
            return work;
        }
    }
}