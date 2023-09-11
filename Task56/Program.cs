﻿//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");

    }
}


int SumRowElements(int[,] matrix, int iRow)
{
    int sumElements = matrix[iRow,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumElements += matrix[iRow, j];
        }
    return sumElements;
}


int[,] array2d = CreateMatrixRndInt(4, 3, -9, 5);
PrintMatrix(array2d);
int minSumRow = 0;
int sumRowElements = SumRowElements(array2d, 0);
for (int i = 1; i < array2d.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(array2d, i);
  if (sumRowElements > tempSumRow)
  {
    sumRowElements = tempSumRow;
    minSumRow = i;
  }
}
Console.WriteLine($"\n{minSumRow+1} - строкa с наименьшей суммой элементов ");
// Console.Write("Сумма элементов по строкам: ");