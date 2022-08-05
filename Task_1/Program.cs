/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Исходный массив:
1 4 7 2
5 9 2 3
8 4 2 4
Результат:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
using static System.Console;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] array1 = GetArray(rows, columns);
PrintArray(array1);
WriteLine();
array1 = SortArray(array1);
PrintArray(array1);

int [,] SortArray (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1)-1; j++)
{
for (int k = 0; k < array.GetLength(1)-1; k++)
{
    if (array[i, k] < array[i, k + 1]) 
    {
        int temp = 0;
        temp = array [i, k];
        array[i, k] = array[i, k + 1];
        array[i, k + 1] = temp;
    }
}  
}
}
return array;
}

int [,] GetArray (int m, int n)
{
int [,] result=new int [m, n];
for(int i=0; i<m; i++)
{
for(int j=0; j<n; j++)
{
result[i,j]=new Random().Next(1,11);
}
}
return result;
}

void PrintArray(int[,] result)
{
for (int i = 0; i < result.GetLength(0); i++)
{
for (int j = 0; j < result.GetLength(1); j++)
{
Write($"{result[i, j]} \t ");
}
WriteLine(); 
}
}