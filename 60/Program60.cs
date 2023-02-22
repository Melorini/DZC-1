// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int readInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int rows, int cols, int layers, int leftLimit, int rightLimit)
{
    Random rand = new Random();
   int[,,] matrix = new int [rows, cols, layers];
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
             for( int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = rand.Next(leftLimit, rightLimit+1);
        }
        }
    }
    return matrix;
}

void printMatrix(int[,,] matrix)
{
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
         for( int k = 0; k < matrix.GetLength(2); k++)
        {
            System.Console.Write($" {matrix[i, j, k] } ({i},{j},{k}) ");
        }
        System.Console.WriteLine();
        }
    }
}

int rows = readInt("Введите количество строк в массиве: ");
int cols = readInt("Введите количество столбцов в массиве: ");
int layers = readInt("Введите количество слоев в массиве: ");
int leftLimit = readInt("Введите левую границу промежутка для выборки: "); 
int rightLimit = readInt("Введите правую границу промежутка для выборки: "); 

var myMatrix = GenerateMatrix(rows, cols, layers, leftLimit, rightLimit);

printMatrix(myMatrix);

