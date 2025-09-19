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

            int[] myArray = new int[number];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите [{i}] элемент массива:  ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }

            System.Console.WriteLine();
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }

                int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sum += myArray[i];
                }
            }
            System.Console.WriteLine($"\nСумма четных чисел массива = {sum}");


            int min = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            System.Console.WriteLine($"\nНаименьший элемент массива: {min}");
        }
    }
}