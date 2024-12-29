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

    }
}



