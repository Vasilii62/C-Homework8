
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
Console.WriteLine("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] numbers = new int[user_rows, user_columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine("Sorted Array:");
Console.WriteLine();
OrderArrayLines(numbers);
PrintArray(numbers);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine();
    }
}
Console.WriteLine();
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
Console.WriteLine("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[user_rows, user_columns];
FillArrayRandomNumbers(array);
PrintArray(array);

int minSum = 0;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumLine(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"\nString with the smallest sum ({sum}) of elements: {minSum+1}");


int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine();
    }
}
Console.WriteLine();
*/

/*
Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Input numbers of rows of first matrix: ");
int user_rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns of first matrix: ");
int user_columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of rows of second matrix: ");
int user_rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns of second matrix: ");
int user_columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (user_rows1 != user_columns2)
{
    Console.WriteLine("The number of rows of the first matrix does not match the number of columns of the second matrix");
    Console.WriteLine();
    return;
}
 
int[,] firstMartrix = new int[user_rows1, user_columns1];
FillArrayRandomNumbers(firstMartrix);
Console.WriteLine($"\nFirst matrix:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[user_rows2, user_columns2];
FillArrayRandomNumbers(secondMartrix);
Console.WriteLine($"\nSecond martrix:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[user_rows1,user_columns2];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nMultiplication of the first and second matrixes:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine();
    }
}
Console.WriteLine();