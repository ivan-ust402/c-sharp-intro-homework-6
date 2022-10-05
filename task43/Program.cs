/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("----- Программа для нахождения точки пересечения двух прямых -----");


Console.WriteLine("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine()!);

if (k1 != 0 && b1 != 0 && k2 != 0 && b2 != 0) {
    double[] array = FindIntersectionPoint(k1, b1, k2, b2);
    Console.Write("(");
    Console.Write(array[0]);
    Console.Write(", ");
    Console.Write(array[1]);
    Console.Write(")");
} else {
    Console.WriteLine("В уравнении для прямой коэффициеты k и b должны быть действительными числами и НЕ равны НУЛЮ! Попробуйте перезапустить программу и ввести коэффициеты заново!");
}



double[] FindIntersectionPoint(double k1, double b1, double k2, double b2) {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        double[] array = new double[]{x, y};
        return array;  
}

