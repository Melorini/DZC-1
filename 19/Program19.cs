// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n/10000 < 10 && n/10000 >= 1)
{
    if (n/10000 == n%10 && (n/1000)%10 == (n%100)/10)
    {
        System.Console.WriteLine("да");
    }
else
System.Console.WriteLine("нет");
}
else
System.Console.WriteLine("это не пятизначное число");


