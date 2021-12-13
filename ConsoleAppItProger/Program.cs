using System;

namespace ConsoleAppItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            bool isHasCar = true;
            if (a > 7) {
                Console.WriteLine("Number is > 7");
            }
            else if (a < 5) {
                Console.WriteLine("Number is < 5");
            }
            else if (a == 4) {
                Console.WriteLine("Number is 4");
            }
            // && = and
            // || = or
            else if ((a == 5 || isHasCar == true) && a > 2) {
                Console.WriteLine("Number is 5");
                Console.WriteLine("User has car");
            }
            else {
                Console.WriteLine("Number is unrecognized");
            }

            Console.WriteLine("_________________________________________");




            string role;
            Console.WriteLine("Enter name: ");
            role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.WriteLine("Enter user name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter {0} age: ", userName);
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0 || age > 99)
                {
                    Console.WriteLine("Enter {0} age: ", userName);
                    age = Convert.ToInt32(Console.ReadLine());
                }

                if (age <= 0 || age > 99)
                {
                    Console.WriteLine("Error");
                    
                }
                else { 
                    Console.WriteLine("User's age is " + age); 
                }
            }

            else {
                Console.WriteLine("You are not Admin");
            }
        }
    }
}
