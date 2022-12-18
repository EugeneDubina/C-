Console.Write("Количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArrayMatrix(rows, columns, 0, 10);
PrintArray(array);
GetAverage(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverage(int[,] array)
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum = sum + array[i, j];
            average = sum / rows;  
        }
        Console.WriteLine($"{Math.Round(average, 2)}; ");
        sum = 0;
    }
}