namespace Work
{
    public class Plumby: IWorker
    {
        public string name { get; set; }
        public string work { get {return "Working on piping";}}
        
        public string Work()
        {
            System.Console.WriteLine(work);
            return work;
        }
    }
}