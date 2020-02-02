using System;

namespace somestuf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {100, -25, 3, 4, 5, 6, 7, 8, -90, 10};
            int[] b = new int[] {10, -1, -9, 2, 8, 3, 7, 4, 6, 5};

            //System.Console.WriteLine(a);
            //System.Console.WriteLine(b);
            //Mas1(a);
            //Mas1(b);
            Mas2(a); 
            Mas2(b);
            Mas3(a, b);
            /*PrintResult(50, 1);
            PrintResult(-50, 2);
            PrintResult(Double.MinValue, 12);
            PrintResult(Double.NaN, 1);
            PrintResult(Double.MaxValue, 3);*/
        }


        public static void Mas1(int[] array)
        {
            int count = 0;
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
        //Знайти кількість додатних елементів, індекс яких кратний 4

        public static void Mas2(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++){
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



        /*Задано масиви А(n) та В(n). Сформувати масив С(n) у наступний спосіб: елемент
масиву С дорівнює сумі відповідних елементів масивів А і В, якщо обидва
елементи додатні; елемент масиву С дорівнює добутку відповідних елементів
масивів А і В, якщо обидва елементи від’ємні; елемент масиву С дорівнює нулю в
усіх інших випадках.*/
        public static void Mas3(int[] array1, int[] array2)
        {
            int[] array3 = new int[] {};
            for(int x = 0; x < array1.Length; x++)
            {
                if(array1[x] > 0 || array2[x] > 0)
                {
                    array3[x] = array1[x] + array2[x];
                }
                else if(array1[x] < 0 || array2[x] < 0){
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

    }
}
