using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Second Number = ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Greatest of two: " + GetMax(first, second));
        }

        public static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }

            else if (first < second)
            {
                return second;
            }
            else
            {
                // ??????
            }
        }