using System;

namespace somestuf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {100, -25, 3, 4, 5, 6, 7, 8, -90, 9};
            int[] b = new int[] {10, -1, -9, 2, 8, 3, 7, 4, 6, 5};

            Mas1(a);
            Mas1(b);
        }


        public static void Mas1(int[] array)
        {
            int count = 0;
             try
                {
                    foreach(int i in array)
                    {
                        int krat = i % 5;
                        if(krat == 0)
                        {
                            count++;
                            System.Console.WriteLine($"element {i} kraten 5");
                        }
                    }  
                    System.Console.WriteLine($"V massive {count} elem. kratnuh 5");
                }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Ошибочка {0}", e.Message);
            }      
            catch (ArgumentException e)
            {
                Console.WriteLine("Ошибочка1 {0}", e.Message);
            }       
        }            

    }
}
