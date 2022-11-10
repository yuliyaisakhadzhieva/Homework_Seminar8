// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива l: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] Fillarray(int m, int n, int l)
{
    int[,,] mat = new int[m, n, l];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                mat[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    Console.WriteLine();
    return mat;
}

void Printarray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}, {(i, j, k)} \t");
            }
            Console.WriteLine();
        }
    }
}
int[,,] mas = Fillarray(m, n, l);
Printarray(mas);

