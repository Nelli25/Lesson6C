// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


Console.Write("Введите количество элементов для массива: ");
int element = int.Parse(Console.ReadLine());
int[] myArray = new int[element];
for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}:\t");
        myArray[i] = int.Parse(Console.ReadLine());
    }
int res = 0;
foreach (int el in myArray)
{
    if (el > 0)
        res ++;
}
Console.WriteLine($"Количество положительных чисел в массиве: {res}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
