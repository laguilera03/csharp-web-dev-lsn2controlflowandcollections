using System;
using System.Runtime.InteropServices.ComTypes;

namespace ListExercises
{
    class Program
    {
        static int SumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        //static string[] PrintWord(string[] array)
        //{
        //    string[] words;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].Length == 5)
        //        {
        //            words += array[i];
        //        }
        //    }
        //    return words;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SumEven(values));


            Console.WriteLine("Enter your students (or ENTER to finish):");

        }
    }
}
