using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace WeekOneChallenges
{
    [TestClass]
    public class Week1Challanges
    {
        [TestMethod]
        public void Week1Challenges()
        {
            string firstName = "Adam";
            string lastName = "Reuter";
            int age = 46;

            string[] favBooks = { "Dune", "The Mote in God's Eye", "Barrayar", "A Ring of Endless Light" };

            List<DateTime> listOfDates = new List<DateTime>();
            DateTime now = DateTime.Now;
            listOfDates.Add(DateTime.Now);
            DateTime bday = new DateTime(1974, 03, 23);
            listOfDates.Add(bday);

            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age % 7);

            int sleep = 7;

            if (sleep >= 10)
            {
                Console.WriteLine("Wow! That's a lot of sleep!");
            }
            else if (sleep > 8)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (sleep > 4)
            {
                Console.WriteLine("Bummer.");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string day = ":(";

            switch (day)
            {
                case "Great":
                    Console.WriteLine("Excellent!");
                    break;
                case "Good":
                    Console.WriteLine("That's nice.");
                    break;
                case "Okay":
                    Console.WriteLine("Okay.");
                    break;
                case "Bad":
                    Console.WriteLine("Bummer.");
                    break;
                case ":(":
                    Console.WriteLine("I am so sorry!");
                    break;
            }

        }
    }
}
