/*
Author: Fernando Pesantes
Date: 1/27/2019
Description: This is the Arrays class project for ISM 4300
it is due on the 31st.

*/

using System;

namespace Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("25 integers: ");

            // I am manually inputing 25 consecutive numbers 1 - 25
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // iterate through the aray with a foreach loop
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            foreach(int i in numbers)
            {
                Console.WriteLine("Element Value = " + i);

            }

            Console.ReadKey(true);
        } // End of main
    } // End of class
} // End of namespace
