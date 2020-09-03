using System;

namespace Howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning!");
            Console.WriteLine("What is your name?");
            String name;
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("What is your year of birth");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to intager (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You are" + Age + "old.");

         
        






        }
    }
}
