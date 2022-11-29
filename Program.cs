
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
/*
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
*/

/*
Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
Console.WriteLine($"\nEnter the size of the 3D pattern:");
int x = InputNumbers("Enter x: ");
int y = InputNumbers("Enter y: ");
int z = InputNumbers("Enter z: ");
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    
  }
}
Console.WriteLine();
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine($"\nEnter the size of the matrix: ");
int user_matrix = Convert.ToInt32(Console.ReadLine());
int[,] squareMatrix = new int[user_matrix, user_matrix];

int temp = 1;
int i = 0;
int j = 0;
Console.WriteLine();

while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
  squareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(squareMatrix);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine();