// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int readInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int rows, int cols, int leftLimit, int rightLimit)
{
    Random rand = new Random();
    double[,] matrix = new double [rows, cols];
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rand.Next(leftLimit, rightLimit) + rand.NextDouble(),2);
        }
    }
    return matrix;
}

void printMatrix(double[,] matrix)
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