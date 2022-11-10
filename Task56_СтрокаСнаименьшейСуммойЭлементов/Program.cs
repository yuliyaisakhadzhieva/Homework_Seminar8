// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Fillarray(int m, int n)
{
    int[,] mat = new int[m, n];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
    return mat;
}

void Printarray(int[,] arr)
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

int[,] mas = Fillarray(m, n);
Printarray(mas);

int SumRowElements(int [,] mas, int i)
{
    int SumRow = mas[i, 0];
    for (int j = 1; j < mas.GetLength(1); j++)
    {
        SumRow += mas[i, j];
    }
    return SumRow;
}
int[,] arr = Fillarray(m, n);

int minSumRow = 0;
int sumRow = SumRowElements(mas, 0);
for (int i = 1; i < mas.GetLength(0); i++)
{
    int tempSum = SumRowElements(mas, i);
    if (sumRow > tempSum)
    {
        sumRow = tempSum;
        minSumRow = i;
    }
}
Console.WriteLine($"{minSumRow + 1} - строка с наименьшей суммой ({sumRow})");

