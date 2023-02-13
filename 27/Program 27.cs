// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num)
  {
    int count = Convert.ToString(num).Length;
    int next = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      next = num - (num % 10);
      result = result + (num - next);
      num = num / 10;
    }
   return result;
  }

int Sum = SumNum(num);
Console.WriteLine("Сумма цифр в числе = " + Sum);