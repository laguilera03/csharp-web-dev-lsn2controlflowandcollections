using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] anArray = {1, 1, 2, 3, 5, 8};
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.WriteLine(anArray[i]);
            }
        }
    }
}
