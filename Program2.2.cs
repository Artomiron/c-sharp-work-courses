using System;

namespace somestuf2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(0, 0);
            PrintResult(3, 3);
            PrintResult(-50, 2);
            PrintResult(Double.MinValue, 12);
            PrintResult(Double.NaN, 1);
            PrintResult(Double.MaxValue, 7);
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
                for(double k = 0; k < i; k++)
                {
                    ans = ans + Math.Pow(-2, i)/Factorial(i) * (i + 1);
                }            
                return  ans;
            }

            
        }
        public static double Factorial(double f)
        {
            double n = 1;
            while (f > 0){
                n = n * f; 
                f--;
                
            }
            return n;

        }
    }
}
