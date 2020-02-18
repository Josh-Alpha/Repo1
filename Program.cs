using Eurothing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eurothing
{
    class Country
    {
        public string Name { get; set; }
        public char Vote { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the European Polling Calculator");
            Console.WriteLine("This program will allow you to input the vote for each country, then choose the rule, and calculate the final result");
            List<string> cNames = new List<string>() { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Sovlenia", "Spain", "Sweden" };
            //Console.WriteLine(cNames.Count);
            Country[] countries = new Country[cNames.Count];
            for (int i = 0; i < cNames.Count; i++)
            {
                countries[i] = new Country() { Name = cNames[i] };
            }

            int yesCount = 0;
            int noCount = 0;
            int abCount = 0;

            Console.WriteLine("Please set Y, N or A for each country");
            List<Country> countries1 = new List<Country>();
            for (int i = 0; i < cNames.Count; i++)
            {
                Console.WriteLine(countries[i].Name);
                countries[i].Vote = Console.ReadLine()[0];
                while (countries[i].Vote != 'Y' && countries[i].Vote != 'N' && countries[i].Vote != 'A')
                {
                    Console.WriteLine("Wrong input, try again: ");
                    countries[i].Vote = Console.ReadLine()[0];
                }

                if (countries[i].Vote == 'Y')
                {
                    yesCount++;
                }
                else if (countries[i].Vote == 'N')
                {
                    noCount++;
                }
                else if (countries[i].Vote == 'A')
                {
                    abCount++;
                }

            }

            for (int i = 0; i < countries1.Count; i++)
            {
                Console.WriteLine(countries1[i].Name + ": " + countries1[i].Vote);
            }

            Console.WriteLine($"These are the responses. Yes: {yesCount}, No: {noCount}, Abstain: {abCount}");
            float percentage = ((yesCount * 100) / (cNames.Count - abCount));
            //Console.WriteLine(percentage);
            Console.WriteLine("What rule would you like to use? Qualified Majority (QM), Reinforced Qualified Majority (RQM), Simple Majority (SM) or Unanimity (U)");
            string input = Console.ReadLine();
            if (input == "QM")
            {
                if (percentage > 54)
                {
                    Console.WriteLine($"Result: Approved, at {percentage}%");
                }
                else
                {
                    Console.WriteLine($"Result: Rejected, at {percentage}%");
                }
            }
            if (input == "RQM")
            {
                if (percentage > 71)
                {
                    Console.WriteLine($"Result: Approved, at {percentage}%");
                }
                else
                {
                    Console.WriteLine($"Result: Rejected, at {percentage}%");
                }
            }
            if (input == "SM")
            {
                if (percentage > 50)
                {
                    Console.WriteLine($"Result: Approved, at {percentage}%");
                }
                else
                {
                    Console.WriteLine($"Result: Rejected, at {percentage}%");
                }
            }
            if (input == "U")
            {
                if (percentage == 100)
                {
                    Console.WriteLine($"Result: Approved, at {percentage}%");
                }
                else
                {
                    Console.WriteLine($"Result: Rejected, at {percentage}%");
                }
            }
        }
    }
}