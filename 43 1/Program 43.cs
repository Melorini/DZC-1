// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using System.Linq;
using static System.Console;

Clear();
WriteLine("y = k1 * x + b1");
WriteLine("y = k2 * x + b2");
printResult(askNumbers());

int[] askNumbers() {
    Write("Введите b1, k1, b2, k2 по порядку через пробел: ");
    return ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

void printResult(int[] array) {
    double x = ((double) array[2] - array[0]) / ((double) array[1] - array[3]);
    double y = array[3] * x + array[2];
    WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({x}; {y})");
}
