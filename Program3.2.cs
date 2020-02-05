using System;

namespace somestuf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {100, -25, 3, 4, 5, 6, 7, 8, -90, 9};
            int[] b = new int[] {10, -1, -9, 2, 8, 3, 7, 4, 6, 5};
            int[] d = {100, -25, 3, 4, -5, 15, 5, 6, 7, 8, -90, 9};
            int[] c = {100, -25, 3, 4, 5, 6, 7, 8, -90, 5, -7, 9};
            System.Console.WriteLine("First itterarion");
            Mas3(a, b);
            System.Console.WriteLine("Second itterarion");
            Mas3(d, c);
        }

        /*Задано масиви А(n) та В(n). Сформувати масив С(n) у наступний спосіб: елемент
масиву С дорівнює сумі відповідних елементів масивів А і В, якщо обидва
елементи додатні; елемент масиву С дорівнює добутку відповідних елементів
масивів А і В, якщо обидва елементи від’ємні; елемент масиву С дорівнює нулю в
усіх інших випадках.*/
        public static void Mas3(int[] array1, int[] array2)
        {
            int[] array3 = new int[10];
            try
                {
                    for(int x = 0; x < array1.Length; x++)
                    {
                        if(array1[x] > 0 && array2[x] > 0)
                        {
                            array3[x] = array1[x] + array2[x];
                        }
                        else if(array1[x] < 0 && array2[x] < 0){
                            array3[x] = array1[x] * array2[x];
                        }
                        else
                        {
                            array3[x] = 0;
                        }
                    }

                    foreach(int x in array3)
                    {
                        System.Console.WriteLine($"Mass {x} ");
                    }
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
