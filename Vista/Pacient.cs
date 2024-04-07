using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using M03.UF5._AC1._Tipus_avançats_de_dades_en_C__Requena_Eric; // Asegúrate de que esta referencia esté correctamente configurada

namespace UF5
{
    public class Program
    {
        public static void Main()
        {
            const int MAX_SCORES = 3;

            List<Score> scores = new List<Score>();

            for (int i = 0; i < MAX_SCORES; i++)
            {
                Console.WriteLine("Enter player name: ");
                string player = Console.ReadLine();
                Console.WriteLine("Enter mission name: ");
                string mission = Console.ReadLine();
                Console.WriteLine("Enter score: ");
                int score = Convert.ToInt32(Console.ReadLine());
                Score s = new Score("", "", 0);
                s.Player = player;
                s.Mission = mission;
                s.Scoring = score;
                if (s.Player == "" || s.Mission == "" || s.Scoring == 0)
                {
                    Console.WriteLine("Invalid values, try again");
                    i--;
                    continue;
                }

                scores.Add(s);
            }

            List<Score> uniqueScores = GenerateUniqueScores(scores);
            uniqueScores.Sort();
            foreach (Score s in uniqueScores)
            {
                Console.WriteLine(s);
            }
        }

        public static List<Score> GenerateUniqueScores(List<Score> scores)
        {
            var uniqueScores = from s in scores
                               group s by new { s.Player, s.Mission } into g
                               select new Score(g.Key.Player, g.Key.Mission, g.Max(x => x.Scoring));
            return uniqueScores.ToList();
        }
    }
}
