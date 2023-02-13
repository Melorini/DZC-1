// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число a: "); 
int A = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число b: "); 
int B = Convert.ToInt32(Console.ReadLine()); 

 int step = 1 ;

for (int i=1; i<= B; i++)
{
    step = step * A ; 
}

System.Console.WriteLine("A в степени В = " +step);