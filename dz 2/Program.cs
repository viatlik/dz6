// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите координаты точки b1 -> ");
double b1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки k1 -> ");
int k1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки b2 -> ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки k2 -> ");
int k2 = int.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);

double y = (k1*x+b1);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");