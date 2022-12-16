//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//(можно использовать готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите число(кол-во строк массива)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число(кол-во столбцов массива)");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)

    {
        array2d[i, j] = new Random().Next(0, 20);
        Console.Write($"{array2d[i, j]}" + " ");
    }
    Console.WriteLine();
}

int MinSum(int[,] array2d)
{
    int minRowSum = int.MaxValue;
    for (int i = 0; i < m; i++)
    {
        int result = 0;
        for (int j = 0; j < n; j++)
            result += array2d[i, j];
        if (result < minRowSum)
            minRowSum = result;
    }
    return minRowSum;
}
Console.WriteLine($"Сумма:{MinSum(array2d)}");

