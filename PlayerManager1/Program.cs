using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasEnded = false;

            string option = "";

            List<Player> players = new List<Player>() 
            {
                new Player("João", 10),
                new Player("José", 15)
            };

            do 
            {
                // Show options
                Console.WriteLine("Options");
                Console.WriteLine("-(I)nsert new player");
                Console.WriteLine("-(L)ist all players");
                Console.WriteLine(
                    "-(S)how player with score greater than given value");

                option = Console.ReadLine();

                switch (option)
                {
                    case "I":

                        break;
                    case "L":

                        break;
                    case "S":

                        break;
                    default:
                        Console.WriteLine("ERROR: Not a valid option");
                        break;
                }
            }
            while (!hasEnded);
        }
    }
}
