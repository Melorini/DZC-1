// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int readInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Restart:
int left = readInt("Введите левую границу промежутка: ");
int right = readInt("Введите правую границу промежутка: ");

if (right <= left)
{
    System.Console.WriteLine("Промежуток задан некорректно: левая граница должна быть меньше правой. Повторите ввод.");
    goto Restart;
}
System.Console.Write("Числа в промежутке: ");
numsFromTo(left, right);
System.Console.WriteLine(" ");

void numsFromTo(int left, int right)
{
    if (right < left)
    {
        return;
    }
    numsFromTo(left, right - 1);
    System.Console.Write(right + " ");
}

System.Console.Write("Сумма чисел в промежутке:");
sumFromTo(left, right);

void sumFromTo(int left, int right, int sum = 0)
{
    sum = sum + right;
    if (right <= left)
    {
        Console.Write(" " + sum);
        return;
    }
    sumFromTo(left, right - 1, sum);
}

System.Console.WriteLine(" ");
