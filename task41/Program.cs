﻿/* 
Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5, 0, 7, 8, -2, -2 -> 2

5, 1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int length = int.Parse(Console.ReadLine()!);

int[] array = HandleFillArray(length);
int amount = FindCountPositiveDigit(array);

PrintResult(array, amount);


int[] HandleFillArray(int length) {
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

int FindCountPositiveDigit(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintResult (int[] array, int amount) {
    for (int i = 0; i < array.Length; i++)
    {   
        if (i == array.Length - 1) {
         Console.Write($"{array[i]}");       
        } else {
        Console.Write($"{array[i]}, ");
        }
    }
    Console.Write($" -> {amount}");
}