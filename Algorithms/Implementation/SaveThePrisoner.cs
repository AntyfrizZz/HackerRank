using System;
using System.Linq;

namespace Implementation
{
    public static class SaveThePrisoner
    {
        public static void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                int numberOfPrisoners = tokens[0];
                int numberOfCandies = tokens[1];
                int prisonerId = tokens[2];

                numberOfCandies %= numberOfPrisoners;
                numberOfCandies--;

                var result = prisonerId + numberOfCandies;
                result %= numberOfPrisoners;

                result = result == 0 ? numberOfPrisoners : result;
                
                Console.WriteLine(result);
            }
        }
    }
}
