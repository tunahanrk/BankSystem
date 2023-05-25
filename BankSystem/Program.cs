using System;
using System.Collections.Generic;

namespace BankSystem
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccNo { get; set; }
    }

    class Program
    {
        static string CreateAccNo()
        {
            Random random = new Random();
            string accNo = "";
            for (int i = 0; i < 10; i++)
            {
                accNo += random.Next(0, 10);
            }
            return accNo;
        }

        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            do
            {
                User user = new User();

                Console.Write("Name: ");
                user.Name = Console.ReadLine();

                Console.Write("Surname: ");
                user.Surname = Console.ReadLine();

                user.AccNo = CreateAccNo();

                users.Add(user);

                Console.Write("Do you want to add another user? (y/n): ");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("\nUsers and account numbers:");
            foreach (var user in users)
            {
                Console.WriteLine("Name: " + user.Name);
                Console.WriteLine("Surname: " + user.Surname);
                Console.WriteLine("Account Number: " + user.AccNo);
                Console.WriteLine("--------------------");
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
