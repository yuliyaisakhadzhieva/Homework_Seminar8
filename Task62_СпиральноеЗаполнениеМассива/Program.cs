// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4, 4];
int x = 1;
int i = 0;
int j = 0;

void NewArray (int [,] spiralArray)
{
while (x <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = x;
    x++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1) j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1) i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1) j--;
    else i--;
}
}
NewArray (spiralArray);

void PrintArray(int[,] spiralArray)
{
    for (int i = 0; i < spiralArray.GetLength(0); i++)
    {
        for (int j = 0; j < spiralArray.GetLength(1); j++)
        {
            Console.Write($"{spiralArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
PrintArray (spiralArray);


