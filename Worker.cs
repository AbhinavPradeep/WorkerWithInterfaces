namespace Work
{
    public interface IWorker
    {
        public string name{get;set;}
        public string work{get;}

        public string Work()
        {
            return work;
        }
    }
}