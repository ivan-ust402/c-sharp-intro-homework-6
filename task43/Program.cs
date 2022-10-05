/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("----- Программа для нахождения точки пересечения двух прямых -----");

Console.WriteLine("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine()!);


int[] FindIntersectionPoint(int k1, int b1, int k2, int b2) {
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    int[] array = new int{x, y};
    return array;  
}
