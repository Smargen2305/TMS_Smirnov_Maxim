using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Выберите кол-во строк в массиве");
            int userRows = int.Parse(Console.ReadLine());

            Console.WriteLine(" Выберите кол-во столбцов в массиве");
            int userColumns = int.Parse(Console.ReadLine());

            int[,] userArray = new int[userRows, userColumns];

            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    Console.WriteLine($" Введите значение для элемента [{i},{j}]:");
                    userArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" Ваш массив:");
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    Console.Write(userArray[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();

            int countPlus = 0;
            int countMinus = 0;

            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    if (userArray[i, j] > 0) 
                    {
                        countPlus++;
                    }
                    if (userArray[i, j] < 0)
                    {
                        countMinus++;
                    }
                }
            }
            Console.WriteLine($" Кол-во положительных элементов = {countPlus} \n Кол-во отрицательных элементов = {countMinus}");
            Console.WriteLine();

            Console.WriteLine(" Инверсия массива");
            Console.WriteLine();

            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    userArray[i, j] = -userArray[i, j];
                    Console.Write(userArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" Сортировка массива от большего к меньшему:");
            Console.WriteLine();

            int[] flatArray2 = new int[userRows * userColumns];
            int index2 = 0;
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    flatArray2[index2++] = userArray[i, j];
                }
            }

            // Сортировка одномерного массива
            Array.Sort(flatArray2);
            Array.Reverse(flatArray2);

            // Обратное преобразование в двумерный массив
            index2 = 0;
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    userArray[i, j] = flatArray2[index2++];
                }
            }

            // Вывод отсортированного массива
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    Console.Write(userArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" Сортировка массива от меньшего к большему:");
            Console.WriteLine();

            int[] flatArray = new int[userRows * userColumns];
            int index = 0;
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    flatArray[index++] = userArray[i, j];
                }
            }

            // Сортировка одномерного массива
            Array.Sort(flatArray);

            // Обратное преобразование в двумерный массив
            index = 0;
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    userArray[i, j] = flatArray[index++];
                }
            }

            // Вывод отсортированного массива
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    Console.Write(userArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
   






















        //int sumEvenNumbers = 0;
        //int[] numbers = new [] { 1, 2, 3, 4, 5 ,6 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 0)
        //    {
        //        sumEvenNumbers += numbers[i];                    
        //    }
        //}
        //Console.WriteLine(sumEvenNumbers);

        //int[] numbers = { 10, 20, 50, 40, 30 };

        //int max = numbers[0];
        //int indexOfMax = numbers[0];

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > max)
        //    {
        //        max = numbers[i];
        //        indexOfMax = i;
        //    }
        //}
        //Console.WriteLine($"Макс число = {max}, индекс Макс числа = {indexOfMax}");

        //Console.WriteLine("Введите число для поиска в массиве: ");
        //int userChoice = int.Parse(Console.ReadLine());
        //int[] numbers = { 10, 20, 30, 40, 50 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] == userChoice)
        //    {
        //        Console.WriteLine($"Число {userChoice} есть в массиве");
        //        return;
        //    }   
        //}
        //Console.WriteLine($"Числа {userChoice} нет в массиве");

        //Console.WriteLine("Введите длину массива: ");
        //int userLengthArray = int.Parse(Console.ReadLine());
        //int[] Array = new int[userLengthArray];


        //for (int i = 0; i < userLengthArray; i++)
        //{
        //    Console.WriteLine($"Введите элемент {i + 1}:");
        //    Array[i] = int.Parse(Console.ReadLine());

        //}
        //Console.WriteLine($"Массив в обратном порядке: ");
        //for (int i = Array.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(Array[i] + " ");
        //}
        //int[] Array = new int[] { 1, 2, 1, 1 };
        //int count = 0;
        //int userChoice = int.Parse(Console.ReadLine());
        //foreach (var item in Array)
        //{
        //    if (item == userChoice)
        //    {
        //        count = count + 1;
        //    }

        //}
        //Console.WriteLine(count);
    }
        }
    
 

