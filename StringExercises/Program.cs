﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");
            string practice = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] anArray = practice.Split(" ");
            Console.WriteLine(string.Join(" ", anArray));
            anArray = practice.Split(".");
            Console.WriteLine(string.Join(".\n", anArray));
        }
    }
}
