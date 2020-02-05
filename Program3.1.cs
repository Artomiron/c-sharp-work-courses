using System;

namespace somestuf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {100, -25, 3, 4, 5, 6, 7, 8, -90, 9};
            int[] b = new int[] {10, -1, -9, 2, 8, 3, 7, 4, 6, 5};
            Mas2(a);
            Mas2(b);
        }


        //Знайти кількість додатних елементів, індекс яких кратний 4

        public static void Mas2(int[] array)
        {
            int count = 0;
             try
                {  
                    for(int i = 0; i < array.Length; i++)
                    {
                        if(array[i] > 0)
                        {
                            int krat = i % 4;
                            if(krat == 0)
                            {
                                count++;
                            }
                        }
                    }
                    System.Console.WriteLine($"V massive {count} polojitelnul elem. index kotoruh kratnuh 4");
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
