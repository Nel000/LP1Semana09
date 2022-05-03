using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        private static List<Player> players = new List<Player>() 
        {
            new Player("João", 10),
            new Player("José", 15)
        };

        static void Main(string[] args)
        {
            bool hasEnded = false;

            string option = "";
            string currPlayerName = "";
            int currPlayerScore, minScore;

            do 
            {
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
                        currPlayerName = Console.ReadLine();

                        Console.Write("Insert new player score: ");
                        currPlayerScore = Convert.ToInt32(Console.ReadLine());

                        players.Add(
                            new Player(currPlayerName, currPlayerScore));

                        Console.WriteLine();
                        break;
                    case "L":
                        PrintPlayerList(players);
                        Console.WriteLine();
                        break;
                    case "S":
                        Console.Write("Insert value: ");
                        minScore = Convert.ToInt32(Console.ReadLine());

                        List<Player> playersS = 
                            GetPlayersWithScoreGreaterThan(minScore);

                        if (playersS.Count == 0)
                            Console.WriteLine(
                                $"No player has score greater than {minScore}");
                        else
                            PrintPlayerList(playersS);
                        Console.WriteLine();
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

        private static List<Player> GetPlayersWithScoreGreaterThan(int s)
        {
            List<Player> playersWithScoreGreaterThan = 
                new List<Player>();

            foreach(Player player in players)
            {
                if (player.Score > s)
                    playersWithScoreGreaterThan.Add(player);
            }

            return playersWithScoreGreaterThan;
        }

        private static void PrintPlayerList(List<Player> pList)
        {
            for (int i = 0; i < pList.Count; i++)
            {
                Console.WriteLine($"Player #{i + 1}");
                Console.WriteLine($"-Name: {pList[i].Name}");
                Console.WriteLine($"-Score: {pList[i].Score}");
            }
        }
    }
}
