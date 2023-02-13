// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandArray (int size, int left, int right)
{
int[] array = new int[size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(left, right + 1);
}
return array;
}

void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

Console.Write("Введите paзмер массива: "); 
int S = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую границу: "); 
int L = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу: "); 
int R = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandArray( S, L, R);

PrintArray(newArray);