// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//2 4 | 3 4 2
//3 2 | 3 3 1
//Результирующая матрица будет:
//18 20 8
//15 18 7

//int ReadInt(string massage)
////{
//System.Console.WriteLine(massage);
//return Convert.ToInt32(Console.ReadLine());
//}

int[,] GenerateArray2d(int rows, int columns)
{
    int[,] number1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < number1.GetLength(0); i++)
    {
        for (int j = 0; j < number1.GetLength(1); j++)
        {
            number1[i, j] = rnd.Next(1, 10);
        }
    }
    return number1;
}

void PrintArray2d(int[,] number1)
{
    for (int i = 0; i < number1.GetLength(0); i++)
    {
        for (int j = 0; j < number1.GetLength(1); j++)
        {
            System.Console.Write($"{number1[i, j]}  |");
        }
        System.Console.WriteLine();

    }
}
int[,] GenerateArray1d(int low, int lew)
{
    int[,] numbers2 = new int[low, lew];
    Random rnd = new Random();
    for (int i = 0; i < numbers2.GetLength(0); i++)
    {
        for (int j = 0; j < numbers2.GetLength(1); j++)
        {
            numbers2[i, j] = rnd.Next(1, 10);
        }
    }
    return numbers2;
}

void PrintArray1d(int[,] numbers2)
{
    for (int i = 0; i < numbers2.GetLength(0); i++)
    {
        for (int j = 0; j < numbers2.GetLength(1); j++)
        {
            System.Console.Write($"{numbers2[i, j]}  |");
        }
        System.Console.WriteLine();

    }
}


void sumMatrix(int[,] number1, int[,]numbers2)
{
    int aRows = number1.Length[0]; 
    int aCols = number1[1].Length;
    int bRows = numbers2.Length[0]; 
    int bCols = numbers2[1].Length;
    if (aCols != bRows);
    double[][] result = MatrixCreate(aRows, bCols);
    for (int i = 0; i < numbers2.GetLength(0); i++)
    {
        for (int j = 0; j < numbers2.GetLength(1); j++)
        {
        for (int k = 0; result[i][j] += number1[i][k] * numbers2[k][j];);
        }
    }
    return result;
}



int[,] array = GenerateArray2d(2, 3);
PrintArray2d(array);
System.Console.WriteLine();

int[,] array1 = GenerateArray2d(3, 3);
PrintArray2d(array1);
sumMatrix();

