// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using System.Linq;
using static System.Console;

Clear();
int[] array = askNumbers();
int count = countAboveZero(array);
WriteLine("чисел больше 0 - " +count);

int[] askNumbers() {
    Write("Введите числа через пробел: ");
    return ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int countAboveZero(int[] array) {
    return array.Where(x => x > 0).Count();
}
