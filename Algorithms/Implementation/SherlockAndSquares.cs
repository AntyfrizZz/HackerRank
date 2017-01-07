using System;
using System.Linq;
using System.Text;

namespace Implementation
{
    public static class SherlockAndSquares
    {
        public static void Solve()
        {
            int numberOfTest = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            for (int i = 0; i < numberOfTest; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int a = tokens[0];
                int b = tokens[1];

                int minNumber = a;
                int maxNumber = b;

                bool hasSquare = false;

                while (a <= b)
                {
                    if (Math.Sqrt(a) == (int)Math.Sqrt(a))
                    {
                        hasSquare = true;
                        break;
                    }

                    a++;
                }

                if (!hasSquare)
                {
                    result.AppendLine("0");
                    continue;
                }

                while (b >= a)
                {
                    if (Math.Sqrt(b) == (int)Math.Sqrt(b))
                    {
                        break;

                    }

                    b--;
                }

                result.AppendLine($"{Math.Sqrt(b) - Math.Sqrt(a) + 1}");
            }

            Console.WriteLine(result);
        }
    }
}
