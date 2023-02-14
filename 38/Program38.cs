// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
Console.Write("Массив: ");
PrintArray(newArray);

int max = newArray[0];
int min = newArray[0];

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] > max)
    {
        max = newArray[i];
    }
    if (newArray[i] < min)
    {
        min = newArray[i];
    }
}

int result = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива = "+result);
