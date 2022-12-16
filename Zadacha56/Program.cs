//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//(можно использовать готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

int m;
int n;
int[,] mass2d;
Console.Write("Введите кол-во строк в массиве: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
n = Convert.ToInt32(Console.ReadLine());
mass2d = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        mass2d[i, j] = rnd.Next(-10, 11);

for (int i = 0; i < m; i++, Console.WriteLine())
    for (int j = 0; j < n; j++)
        Console.Write(mass2d[i, j] + "\t");

int minSum = int.MaxValue;
int index = 0;
for (int i = 0; i < m; i++)
{
    int rowSum = 0;
    for (int j = 0; j < n; j++)
        rowSum += mass2d[i, j];

    if (rowSum < minSum)
    {
        minSum = rowSum;
        index = i;
    }
}

Console.WriteLine("Строка с мин. суммой элементов: ");
for (int j = 0; j < n; j++)
    Console.Write(mass2d[index, j] + "\t");
Console.WriteLine();
Console.WriteLine($"Сумма этой строки:{minSum}");