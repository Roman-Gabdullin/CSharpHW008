// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество минимальное значение: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество максимальное значение: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[lines, columns];
int[,] matrix = new int[lines, columns];
matrix = FillMatrix(minvalue, maxvalue);
int[] arraySum = new int[0];
arraySum = SumOfLineElements(matrix);
Console.WriteLine("Массив: ");
PrintMatrix(matrix);
Console.WriteLine("Сумма элементов строк массива: ");
PrintArray(arraySum);
LineSmallAmount(arraySum);




int[] SumOfLineElements (int[,] matrix)
{
    int[] array = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[i] = sum;
    }
    return array;

}

void LineSmallAmount(int[] array)
{
    int min = array[0];
    Console.Write("Строки с наименьшей суммой элементов: ");
    for (int i = 0; i < array.Length-1; i++)
    {
        if (min > array[i+1]) min = array[i+1];           
    }
    for (int z = 0; z < array.Length; z++)
    {
        if (min == array[z]) Console.Write($" {z+1}");
    }
}

int[,] FillMatrix(int minvalue,int maxvalue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minvalue, maxvalue+1);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}