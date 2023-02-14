// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sum = 0;

for (int i = 0; i < newArray.Length; i=i+2)
{
       sum = sum +newArray[i];
}
Console.WriteLine("Сумма элементов на нечётных позициях = "+ sum);