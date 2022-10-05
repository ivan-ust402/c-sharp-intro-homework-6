/* 
Задача 1*. Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
2 -> 10
11 -> 1011
16 -> 10000
*/

Console.Clear();
Console.WriteLine("Введите число для перевода в двоичную систему счисления: ");
int number = int.Parse(Console.ReadLine());

int doubleNumber = ToDouble(number);
Console.WriteLine($"{number} -> {doubleNumber}");

int ToDouble(int number, int degree = 0) {
    if (number / 2 != 0) {
        return number % 2 * (int)Math.Pow(10, degree) + ToDouble(number / 2, ++degree);
    }
    else {
        return number % 2 * (int)Math.Pow(10, degree);
    }
}
