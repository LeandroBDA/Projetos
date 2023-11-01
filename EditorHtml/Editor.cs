using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("-----------");
            start();
        }

        public static void start()
        {
            var file = new StringBuilder();
            {
                do
                {
                    file.Append(Console.ReadLine());
                    file.Append(Environment.NewLine);
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
                
                Console.WriteLine("-----------");
                Console.WriteLine("Deseja salvar o arquivo?");
                Viewer.show(file.ToString());
            }   
        }
    }
}