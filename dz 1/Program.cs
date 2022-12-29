// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите нужное количество чисел -> ");
string[] stringNum = Console.ReadLine()!.Split(' ');
int count = 0;

for (int i = 0; i < stringNum.Length-1; i++)
{
    string Q = Convert.ToString(stringNum[i]);
    int W = Convert.ToInt32(Q);
    if (W > 0) count++;
}
Console.Write(count);