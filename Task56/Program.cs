// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
int min = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLine(array, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    min = i;
  }
}
Console.WriteLine($"{min+1} - строкa с наименьшей суммой элементов. Сумма эллементов данной строки равна {sumLine} ");

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

int SumLine(int[,] inArray, int i)
{
  int sum = inArray[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += inArray[i,j];
  }
  return sum;
}