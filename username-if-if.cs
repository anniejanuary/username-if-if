using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username");

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = ""; //"leaving it empty" -> so when the user writes nothing and clicks enter
                                  //it's treated as empty

            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");

                Console.WriteLine($"Hi there, {userName}");

                Console.WriteLine("Hi there, Admin");

            }

            if(isAdmin || isRegistered) // if either one or the other is true
            {
                Console.WriteLine("You are logged in");
            }

                Console.ReadLine();
            
        }
    }
}
