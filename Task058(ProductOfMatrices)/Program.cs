// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int lines1 = DataEntry("Введите количество строк 1 матрицы: ");
int columns1 = DataEntry("Введите количество столбцов 1 матрицы: ");
int minvalue1 = DataEntry("Введите минимальное значение элементов 1 матрицы: ");
int maxvalue1 = DataEntry("Введите максимальное значение элементов 1 матрицы: ");
int lines2 = DataEntry("Введите количество строк 2 матрицы: ");
int columns2 = DataEntry("Введите количество столбцов 2 матрицы: ");
int minvalue2 = DataEntry("Введите минимальное значение элементов 2 матрицы: ");
int maxvalue2 = DataEntry("Введите максимальное значение элементов 2 матрицы: ");
int[,] matrix1 = new int[lines1, columns1];
int[,] matrix2 = new int[lines2, columns2];
FillMatrix(matrix1, minvalue1, maxvalue1);
FillMatrix(matrix2, minvalue2, maxvalue2);
if (lines1 == columns2 || lines2 == columns1)
{
    int[,] resultMatrix = ProductOfMatrices(matrix1, matrix2);
    Console.WriteLine("Исходные матрицы: ");
    PrintMatrix(matrix1);
    Console.WriteLine();
    PrintMatrix(matrix2);
    Console.WriteLine("Призведение 2 матрицы: ");
    PrintMatrix(resultMatrix);
}
else Console.Write("Ошибка.Количество столбцов одной из матрицы не совпадает с количеством строк другой матрицы.");




int DataEntry(string data)
{
    Console.Write(data);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] ProductOfMatrices(int[,] matrix1, int[,] matrix2)
{
    var result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                    result[i, j] += matrix1[i, n] * matrix2[n, j];
            }
         }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix, int minvalue, int maxvalue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minvalue, maxvalue+1);
        }
    }
}