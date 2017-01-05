using System;
using System.Numerics;

namespace Implementation
{
    public static class ExtraLongFactorials
    {
        public static void Solve()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            while (n != 1)
            {
                result *= n;
                n -= 1;
            }

            Console.WriteLine(result);
        }
    }
}
