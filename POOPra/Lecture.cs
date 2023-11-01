using System.Collections.Generic;
using POOPra.ContentContext.Enum;

namespace POOPra
{
    public class Lecture : Base
    {
        public class Lectures
        {
            public int Ordem { get; set; }
            public string Title { get; set; }
            public double DurationInMinutes { get; set; }
            public EContentLevel Level { get; set; }
        }
        
    }
}

