// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество минимальное значение: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество максимальное значение: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[lines, columns];
matrix = FillMatrix(matrix, minvalue, maxvalue);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
matrix = DecreasingMatrix(matrix);
Console.WriteLine("Отсортированный массив: ");
PrintMatrix(matrix);


int[,] DecreasingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1])
                {
                    int temporary = 0;
                    temporary = matrix[i, z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = temporary;
                }
            }
        }
    }
    return matrix;
}

int[,] FillMatrix(int[,] matrix, int minvalue, int maxvalue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minvalue, maxvalue+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}