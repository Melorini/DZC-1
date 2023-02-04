// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
System.Console.Write(str);
return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату x первой точки: ");
int y1 = InputNumber("Введите координату y первой точки: ");
int z1 = InputNumber("Введите координату z первой точки: ");
int x2 = InputNumber("Введите координату x второй точки: ");
int y2 = InputNumber("Введите координату y второй точки: ");
int z2 = InputNumber("Введите координату z второй точки: ");

double result = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2)), 2);

System.Console.WriteLine($"Расстояние = {result}");
