// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());


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
Console.WriteLine();
Console.WriteLine("Первая матрица");
PrintArray(mas);
Console.WriteLine();

int[,] FillArrayTwo(int p, int s)
{
    int[,] array = new int[p, s];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArrayTwo(int[,] arr)
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
int[,] mat = FillArrayTwo(p, s);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArrayTwo(mat);

Console.WriteLine();

int Xmatrix(int[,] mas, int[,] mat, int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < mas.GetLength(1); j++)
            {
                sum += mas[i, k] * mat[k, j];
            }
            resMatrix[i, j] = sum;
        }
    }
    return resMatrix;
}
Xmatrix(mas, mat, resMatrix);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(resMatrix);





