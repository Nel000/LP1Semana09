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
            string currentPlayerName = "";
            int currentPlayerScore;

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
                    "-(S)how players with score greater than given value");
                Console.WriteLine("-(E)nd application");

                option = Console.ReadLine();

                switch (option)
                {
                    case "I":
                        Console.Write("Insert new player name: ");
                        currentPlayerName = Console.ReadLine();

                        Console.Write("Insert new player score: ");
                        currentPlayerScore = Convert.ToInt32(Console.ReadLine());

                        players.Add(
                            new Player(currentPlayerName, currentPlayerScore));

                        Console.WriteLine();
                        break;
                    case "L":

                        break;
                    case "S":

                        break;
                    case "E":
                        hasEnded = true;
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
