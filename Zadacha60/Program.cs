//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размер массива: m, n, p");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[m, n, p];
int count = 10;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int s = 0; s < p; s++)
        {
            array3d[i, j, s] += count;
            count ++;
            Console.Write($"{array3d[i, j, s]}({i},{j},{s}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}