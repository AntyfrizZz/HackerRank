using System;

namespace Implementation
{
    public static class FindDigits
    {
        public static void Solve()
        {
            var numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                var number = int.Parse(Console.ReadLine());
                var savedNumber = number;
                var result = 0;

                do
                {
                    var digit = number % 10;

                    if (digit != 0 && savedNumber % digit == 0)
                    {
                        result++;
                    }

                    number /= 10;
                } while (number != 0);

                Console.WriteLine(result);
            }
        }
    }
}
