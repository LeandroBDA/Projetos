using System.Collections.Generic;
using POOPra.ContentContext;

namespace POOPra
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre .NET", "orientacao-objetos"));
           
            // foreach (var article in articles)
            // {
                // Console.WriteLine(article.Id);
                // Console.WriteLine(article.Title);
                // Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var couseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var couseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var couseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspn");
            courses.Add(couseOOP);
            courses.Add(couseCsharp);
            courses.Add(couseAspNet);
            
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2,"Aprenda OOP","",couseOOP);
            var careerItem = new CareerItem(1,"Comece por aqui","",couseCsharp);
            var careerItem3 = new CareerItem(3,"Aprenda .NET","",couseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }
        }
    }
}

