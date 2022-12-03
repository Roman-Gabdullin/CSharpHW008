// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int lines = DataEntry("Введите количество строк матрицы: ");
int columns = DataEntry("Введите количество столбцов матрицы: ");
int depth = DataEntry("Введите количество элементов глубины матрицы: ");
int minvalue = DataEntry("Введите минимальное значение элементов матрицы: ");
int maxvalue = DataEntry("Введите максимальное значение элементов матрицы: ");
int[] tempArray = ArrayOfUnequalNumbers(lines*columns*depth, minvalue, maxvalue);
int[,,] matrix = FillMatrix(tempArray, lines, columns, depth);
PrintMatrix(matrix);



int DataEntry(string data)
{
    Console.Write(data);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] ArrayOfUnequalNumbers(int quant, int minvalue, int maxvalue)
{
    int[] tempArray = new int[quant];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(minvalue, maxvalue+1);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(minvalue, maxvalue+1);
                    j = 0;
                }
            }
        }
    }
    return tempArray;
}

int[,,] FillMatrix(int[] array, int lines, int columns, int depth)
{
    int[,,] tempMatrix = new int[lines, columns, depth];
    int count = 0;
    for (int x = 0; x < tempMatrix.GetLength(0); x++)
    {
        for (int y = 0; y < tempMatrix.GetLength(1); y++)
        {
            for (int z = 0; z < tempMatrix.GetLength(2); z++)
            {
                tempMatrix[x, y, z] = array[count];
                count++;
            }
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i} ,{j} ,{k}) ");
            }
            Console.WriteLine();
        }
    }
}