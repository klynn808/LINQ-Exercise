using System;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Crash Bandakoot", "Harry Potter", 
                "Sack Boy", "Sims", "Red Redemption", "Mario Kart"};

            var wordsByLength = videoGames.OrderBy(word => word.Length).ToList();

            foreach (var word in wordsByLength)
            {
                Console.WriteLine(word);
            }

            var twoWordsInTitle = videoGames.Where(word => word.Contains(" ")).ToList();

            foreach (var word in twoWordsInTitle)
            {
                Console.WriteLine(word);
            }

            var wordLengths = videoGames.Select(word => word.Length).ToList();

            foreach (var length in wordLengths)
            {
                Console.WriteLine(length); 
            }

            int initialSum = videoGames.Sum(word => word.Length);

            videoGames = videoGames.Append("Barbie").ToList();

            int newSum = videoGames.Sum(word => word.Length);

            double averageLength = videoGames.Average(word => word.Length);

            Console.WriteLine($"Initial sum of Lengths: {initialSum}");
            Console.WriteLine($"New sum of Lengths: {newSum}");
            Console.WriteLine($"Current Average Length: {averageLength}");

            int currentCount = videoGames.Count();
            Console.WriteLine(currentCount);

            int minWordGame = videoGames.Min(word => word.Length);
            int maxWordGame = videoGames.Max(word => word.Length);

            var firstThree = videoGames.Take(3).ToList();
            foreach (var word in  firstThree)
            {
                Console.WriteLine(word);
            }
            var wordsInOrder = firstThree
                .OrderBy(word => word.Length)
                .ThenBy(word => word)
                .ToList();

            Console.WriteLine("First three games sorted by length and then alphabetically:");

            foreach (var word in wordsInOrder)
            {
                Console.WriteLine(word);
            }
        }

    }


}

