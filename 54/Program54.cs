// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void sortFromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int max = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = max;
                }
            }
        }
    }
}

sortFromMaxToMin(myMatrix);
Console.WriteLine("");
printMatrix(myMatrix);