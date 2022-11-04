// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int numLine, int numColumns)
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i, j] = new Random().Next(0, 5);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matr1 = FillArray(row, col);
PrintArray(matr1);
Console.WriteLine();
int[,] matr2 = FillArray(row, col);
PrintArray(matr2);
int[,] resMatr = new int[row, col];

// for (int i = 0; i < matr1.GetLength(0); i++)
// {
//     for (int j = 0; j < matr2.GetLength(1); j++)
//     {
//         resMatr[i,j] = matr1[i, j] * matr2[i, j] + matr1[i, j+1] * matr2[i+1, j];
//     }
// }
int a = matr1[0, 0] * matr2[0, 0] + matr1[0, 1] * matr2[1, 0];
int a1 = matr1[0, 0] * matr2[0, 1] + matr1[0, 1] * matr2[1, 1];
int b = matr1[1, 0] * matr2[0, 0] + matr1[1, 1] * matr2[1, 0];
int b1 = matr1[1, 0] * matr2[0, 1] + matr1[1, 1] * matr2[1, 1];
Console.WriteLine($"{a} {a1}");
Console.WriteLine($"{b} {b1}");