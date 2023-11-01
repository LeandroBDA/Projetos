using System.ComponentModel.Design;
using POOPra.ContentContext;

namespace POOPra
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;
        
    }
}
