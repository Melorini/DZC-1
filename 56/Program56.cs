// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка


int readInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftLimit, int rightLimit)
{
    Random rand = new Random();
   int[,] matrix = new int [rows, cols];
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftLimit, rightLimit+1);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = readInt("Введите количество строк в массиве: ");
int cols = readInt("Введите количество столбцов в массиве: ");
int leftLimit = readInt("Введите левую границу промежутка для выборки: "); 
int rightLimit = readInt("Введите правую границу промежутка для выборки: "); 

var myMatrix = GenerateMatrix(rows, cols, leftLimit, rightLimit);

printMatrix(myMatrix);

    int getMinSumRowNumber (int [,] matrix)
    {
      int row = 0;
      int firstRowSum = 0;
      for (int i = 0; i < matrix.GetLength(1); i++)
      {
        firstRowSum = firstRowSum + matrix[0,i];
      }

      for (int i = 1; i < matrix.GetLength(0); i++)
      {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         rowSum = rowSum + matrix[i,j];
        }

        if (firstRowSum > rowSum)
        {
          firstRowSum = rowSum;
          row = i;
        }
      }
      return row + 1;
    }


Console.WriteLine($"Строка с наименьшей суммой элементов - {getMinSumRowNumber(myMatrix)}");

    