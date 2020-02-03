using System;

namespace somestuf2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(0, 0);
            PrintResult(50, 1);
            PrintResult(-50, 2);
            PrintResult(Double.MinValue, 12);
            PrintResult(Double.NaN, 1);
            PrintResult(Double.MaxValue, 3);
        }

        static void PrintResult(double t, double i)
        {
            Console.Write($"t:{t} i:{i} result:");
            try
                {
                    Console.WriteLine(Axx(t, i));
                }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }


        public static double Axx(double t, double i)
        {
            double ans = 0;
            if (i < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(i), i, "Invalid value");
                }
            else if (i == 1 || i == 2)
            {
                ans = Math.Log(t);
                return ans;
            }
            else
            {
                for(double k = 1; k < i; k++)
                {
                    ans = ans + Math.Sin(t)/k;
                }            
                return  ans;
            }

            
        }
    }
}
