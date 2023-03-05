// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array1 = GetArray(rows, columns, 1, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns, 1, 10);
PrintArray(array2);

int[,] resultArray = new int[rows,columns];

MultArray(array1, array2, resultArray);
Console.WriteLine($"Произведение:");
PrintArray(resultArray);

void MultArray(int[,] first, int[,] second, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int mult = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        mult += first[i,k] * second[k,j];
      }
      result[i,j] = mult;
    }
  }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}