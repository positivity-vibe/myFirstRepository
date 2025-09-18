using System;
using System.ComponentModel.DataAnnotations;

namespace myFirstRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int number = int.Parse(Console.ReadLine());

            int[] myArray = new int [number];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите [{i}] элемент массива:  ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++) {
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }
        }
    }
}