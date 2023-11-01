using POOPra.ContentContext;

namespace POOPra.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null) throw new SystemException("O curso não pode ser nulo");
            Ordem = ordem;
            this.title = title;
            Description = description;
            Course = course;
        }
        public int Ordem { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}

