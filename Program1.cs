using System;



namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.34, b = -3.12, c = 5.45, d = 2.0;
            double Artem = Math.Cos(a);
            System.Console.WriteLine("Variant 13");
            //Task #3
            double one = Math.Pow(2 * Math.Sin(a) + Math.Cos(Math.Abs(b * Math.Sqrt(c))), d);
            Console.WriteLine("Task #3 = " + one);

            //Task #13
            double a1 = -2.86, b1 = 1.62, c1 = 10.874, d1 = -2.91;
            double two = ((Math.Log2(Math.Abs(2 * a1)) / 3 * Math.Tan(b1)) - (Math.Sqrt(c1 / Math.Sqrt(Math.Abs(d1)))));
            Console.WriteLine("Task #13 = " + two);

            //Task #23
            double a2 = -3.45, b2 = -2.34, c2 = 1.45, d2 = 0.83;
            double three = ((5 * c) / (Math.Cos(a2)) + (Math.Sqrt(Math.Sinh(Math.Abs(b2) * c2) / Math.Tan(d2))));
            Console.WriteLine("Task #23 = " + three);






            double x = 23.7, y = 8.4, z;
            z = x + y;

            double[] mass = new double [5];
            Console.WriteLine("Summ is: " + z);
            
            if(args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0] + "!");
            }
            else
            {
                Console.WriteLine("Hello Artem!");
            }
            //Console.WriteLine($"Hello {args[1]} !");
        }
    }
}
