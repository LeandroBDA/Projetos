using System.Collections.Generic;

namespace POOPra.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}

