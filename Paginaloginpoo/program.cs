using System;

namespace Paginaloginpoo
{
    public class Program
    {
       public static List<User> users = new List<User>();

        public static void Main(string[] args)
        {
            Console.Clear();
            myMenu startMenu = new myMenu();
            startMenu.MenuShow();
        }
    }
}