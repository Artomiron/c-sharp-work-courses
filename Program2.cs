using System;

namespace somestuf2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(0);
            PrintResult(1);
            PrintResult(2);
            PrintResult(17);   
            PrintResult(34);
            PrintResult(-35);
            PrintResult(Double.MaxValue);
            PrintResult(Double.MinValue);
            PrintResult(Double.NaN);
        }

        static void PrintResult(double s)
        {
            Console.Write($"s:{s}  result:");
            try
                {
                    Console.WriteLine(Axx(s));
                }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }


        public static double Axx(double s)
        {
            double ans = 0;
            for(double i = 1; i < 35; i++)
            {
                /* if (s < 0 || s > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(s), s, "Invalid value");
                }*/
                ans = ans + Math.Log10(Math.Sqrt(s*(1/Math.Pow(i, 2))));
                System.Console.WriteLine(Math.Log10(Math.Sqrt(s*(1/Math.Pow(i, 2)))));
            }            
            return  ans;
        }
    }
}
