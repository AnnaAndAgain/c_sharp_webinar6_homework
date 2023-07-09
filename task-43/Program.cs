/*
Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Выводим: x = (b2-b1)/(k1-k2)
*/

// решение 1 - с переменными-ссылками
/*

double[] ReadDoubleArray(string text) 
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(", "), double.Parse);
}

void FindIntersection(double[] arr1, double[] arr2, out double X, out double Y)
{
    X = (arr2[1]-arr1[1])/(arr1[0]-arr2[0]);
    Y = arr1[0]*X + arr1[1];
}

double[] line1 = ReadDoubleArray("Введите данные для первой прямой через запятую: k1, b1.");
double[] line2 = ReadDoubleArray("Введите данные для первой прямой через запятую: k2, b2.");
FindIntersection(line1, line2, out double X, out double Y);
System.Console.WriteLine($"Пересечение в точке [{X}, {Y}]");
*/

//решение 2, с записью в массив

double[] ReadDoubleArray(string text) 
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(", "), double.Parse);
}

void PrintArray(Double[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

double[] FindIntersection(double[] arr1, double[] arr2)
{
    double[] result = new double[2];
    result[0] = Math.Round((arr2[1]-arr1[1])/(arr1[0]-arr2[0]), 3);
    result[1] = Math.Round((arr1[0]*result[0] + arr1[1]), 3);
    return result;
}

double[] line1 = ReadDoubleArray("Введите данные для первой прямой через запятую: k1, b1.");
double[] line2 = ReadDoubleArray("Введите данные для первой прямой через запятую: k2, b2.");
PrintArray (FindIntersection(line1, line2));