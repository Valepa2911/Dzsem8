//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
//(можно использовать готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] array2d = new int[4, 4];
ArrayRandom(array2d);
Sortirovka(array2d);
Console.WriteLine();
PrintArray(array2d);
Random random = new Random();

void ArrayRandom(int[,] array2d)
{
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)

    {
        array2d[i, j] = new Random().Next(-20, 20);
        Console.Write($"{array2d[i, j]}" + " ");
    }
    Console.WriteLine();
}
}

void Sortirovka(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write($"{array2d[i, j]} ");
        }
        Console.WriteLine();
    }
}
