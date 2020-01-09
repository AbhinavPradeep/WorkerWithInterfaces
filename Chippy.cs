namespace Work
{
    public class Chippy : IWorker
    {
        public string name { get; set; }
        public string work { get {return "Working on carpentry";}}

        public string Work()
        {
            System.Console.WriteLine(work);
            return work;
        }
    }
}