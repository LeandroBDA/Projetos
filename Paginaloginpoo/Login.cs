using System;
using System.Collections.Generic;

namespace UserLoginSystem
{
    class LoginSystem
    {
        private Dictionary<string, string> users;

        public LoginSystem()
        {
            users = new Dictionary<string, string>();
        }

        public void Run()
        {
            bool loggedIn = false;

            while (!loggedIn)
            {
                Console.WriteLine("---- Login System ----");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Signin");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        loggedIn = true;
                        break;
                    case "2":
                        Signin();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }

            // Rest of the program logic after successful login...
            Console.WriteLine("Logged in successfully!");
            Console.WriteLine("Rest of the program logic goes here...");
        }

        private void Login()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No user found. Please create an account first.");
                return;
            }

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }

        private void Signin()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("Username already exists. Please choose a different username.");
            }
            else
            {
                users.Add(username, password);
                Console.WriteLine("Account created successfully!");
            }
        }
    }
}
