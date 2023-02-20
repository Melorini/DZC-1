// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int rowNumber = readInt("Введите номер строки: ");
int colNumber = readInt("Введите номер столбца: ");

if (rowNumber > myMatrix.GetLength(0) || colNumber > myMatrix.GetLength(1))
{
    Console.WriteLine("Такого позиции в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента в {rowNumber} строке {colNumber} столбца - {myMatrix[rowNumber-1,colNumber-1]}");
}

