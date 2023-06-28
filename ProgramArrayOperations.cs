using System;

class ProgramArrayOperations
{
    static void Main(string[] args)
    {
        // создать двумерный массив размером 10x10
        double[,] matrix = new double[10, 10];

        // заполнить массив случайными значениями
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = random.NextDouble();
            }
        }

        // найти суммы элементов каждой строки
        double[] rowSums = new double[10];
        for (int i = 0; i < 10; i++)
        {
            double sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += matrix[i, j];
            }
            rowSums[i] = sum;
        }

        // найти произведения элементов каждого столбца
        double[] colProds = new double[10];
        for (int j = 0; j < 10; j++)
        {
            double prod = 1;
            for (int i = 0; i < 10; i++)
            {
                prod *= matrix[i, j];
            }
            colProds[j] = prod;
        }

        // найти максимальный элемент главной диагонали
        double maxDiag = double.MinValue;
        for (int i = 0; i < 10; i++)
        {
            if (matrix[i, i] > maxDiag)
            {
                maxDiag = matrix[i, i];
            }
        }

        // вывести результаты
        Console.WriteLine("Суммы элементов каждой строки:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Строка {0}: {1}", i, rowSums[i]);
        }

        Console.WriteLine("Произведения элементов каждого столбца:");
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Столбец {0}: {1}", j, colProds[j]);
        }

        Console.WriteLine("Максимальный элемент главной диагонали: {0}", maxDiag);
    }
}