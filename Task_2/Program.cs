/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Исходный массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Результат:
1-строка
 */

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

int MinSumLine = 0;
int SumLine = SumRows(array1, 0);
for (int i = 1; i < array1.GetLength(0); i++)
{
  int temp = SumRows(array1, i);
  if (SumLine > temp)
  {
    SumLine = temp;
    MinSumLine = i;
  }
}
WriteLine($"\n{MinSumLine+1} - строкa с наименьшей суммой");

int SumRows (int [,] array, int i)
{
int sum = array[i,0];
for(int j=0; j<array.GetLength(1); j++)
{
sum +=array[i,j];
}
return sum;
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