// // Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

Console.Write("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 < 10 && number / 100 > 1)
{
    int rightNumber = (number%100)%10;
Console.WriteLine(" " + rightNumber);
}

else if (number / 10 < 10 && number / 10 > 1)
{
Console.WriteLine("третьей цифры нет");
}

else 
{
while (number / 100 >= 10)  
    {
       number = number / 10;
    }
      int rightNumber = (number%100)%10;
Console.WriteLine(" " + rightNumber);
    }
    


