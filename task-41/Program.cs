/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] ReadIntArray (string text)
{
    Console.WriteLine(text);
    int[] tmpArray = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return tmpArray;
}

int CountPositive (int[] tmpArray)
{
    int count = 0;
    foreach (int n in tmpArray) 
    {
        if (n > 0) count++;
    };
    return count;
}

int[] array = ReadIntArray("Введите целые числа через пробел:");
System.Console.WriteLine(CountPositive(array));