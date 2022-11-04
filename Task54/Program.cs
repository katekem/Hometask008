// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
            matrix[i, j] = new Random().Next(0, 10);
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

int[,] myArray = FillArray(row, col);
PrintArray(myArray);


for (int j = 0; j < myArray.GetLength(1) - 1; j++)
{
    int temp = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        if (myArray[i, j] < myArray[i, j + 1])
        {
        temp = myArray[i, j];
        myArray[i, j] = myArray[i, j + 1];
        myArray[i, j + 1] = temp;
        }
    }
}

PrintArray(myArray);

