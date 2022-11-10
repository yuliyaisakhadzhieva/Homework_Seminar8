// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] mas = FillArray(m, n);
PrintArray(mas);

Console.WriteLine();

void RangeArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(1) - 1; k++)
            {
                if (mas[i, k] < mas[i, k + 1])
                {
                    int temp = mas[i, k + 1];
                    mas[i, k + 1] = mas[i, k];
                    mas[i, k] = temp;
                }
            }
        }
    }
    PrintArray(mas);
}
RangeArray(mas);




