// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int min = 0;
int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
       sum += myArray[0,j];
       min = sum;
    }
    
int line = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum2 = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
       sum2 += myArray[i,j];
    }
    if (sum2 < min)
    {
        min = sum2;
        line = i + 1;
    }
}
Console.WriteLine($"Строка с наименьшей суммой, равной {min}, - это {line}");