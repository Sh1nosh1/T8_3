using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_2
{
    internal class Program
    {
        //Task 1
        /*public static void Func()
        {
            Write('*');
        }*/

        //Task 3

        /*public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }*/

        //Task 4

        /*public static double Calculate(int x)
            {
              return (Math.Sqrt(x)+x)/2;
            }*/

        //Task 2

        /*public static void Func()
        {
            /*for(int i = 0; i < 8; i++)
            {
                for(int  j = 0; j < i; j++)
                {
                    Write("#");
                }
                WriteLine();
            }*/

            /*for (int i = 8; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("#");
                }
                WriteLine();
            }*/

            //task 4.3

        public static int Max(int a, int b, int c, int d)
        {
            
        }

        


        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Написать метод, «рисующий» на экране горизонтальную линию из 60 символов «*».

                /*for (int i = 0; i < 60; i++)
                {
                    Func();
                }*/

                //Task 4

                /*Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                int max = Max(a, b);
                Write($"Maximum value: {max}");*/

                //Task 3
                /*Write($"{Calculate(5)+Calculate(12)+Calculate(19):f2}");*/

                //Task 2

                /*Func();*/

                //samasta

                //Task 4.3

                Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                Write("Enter c: ");
                int c = Convert.ToInt32(ReadLine());
                Write("Enter d: ");
                int d = Convert.ToInt32(ReadLine());

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
