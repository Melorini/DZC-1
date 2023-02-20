// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

Console.WriteLine("Среднее арифмитическое:");

for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        avarage = avarage + myMatrix[i, j];
    }
    avarage = Math.Round(avarage / rows, 2);
    Console.Write(avarage + "\t");
}
Console.WriteLine("");
