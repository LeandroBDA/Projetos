using System;

namespace UserLoginSystem
{
    class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("---- Login System ----");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Signin");
            Console.WriteLine("3. Exit");
        }

        public static string GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}