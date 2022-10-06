/* 
Задача 2*. Написать программу, которая принимает от пользователя положительные числа и считает среднее значение этих чисел.
Ввод числе осуществляется до тех пор, пока пользовател не введёт -1. Ввод чисел и расчёт должен происходит в рекурсии
1
2
3
4
-1
-> 2,5
*/
Console.Clear();
Console.WriteLine("Введите через Enter положительные числа для расчета среднего арифметического: ");

int[] array = new int[2];
double FindSumAndCount(double sum = 0, double count = 1) {
    int number = int.Parse(Console.ReadLine()!);
    if (number != -1) {
        sum = sum + number;
        return FindSumAndCount(sum, ++count);
    }
    else {
        count--;
        return sum / count;
    }
}
double sum = FindSumAndCount();
Console.WriteLine($"{sum}");