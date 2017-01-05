using System;
using System.Linq;

namespace Implementation
{
    public static class JumpingOnTheCloudsRevisited
    {
        public static void Solve()
        {
            var tockens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var n = tockens[0];
            var k = tockens[1];

            var clouds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var index = 0;
            var energy = 100;

            do
            {
                index = (index + k) % n;
                energy -= clouds[index] == 1 ? 3 : 1;

            } while (index != 0);

            Console.WriteLine(energy);
        }
    }
}
