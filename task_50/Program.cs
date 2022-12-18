Console.Write("Введите искомое число: ");
int num = int.Parse(Console.ReadLine());
int rows;
int columns;

int[,] array = GetArrayMatrix(rows = 4, columns = 4, 0, 100);
PrintArray(array);
CheckNum(array);

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

void CheckNum(int[,] array)
{
    bool find = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j] == num)
            {
            Console.WriteLine($"число {num}: строка {i}, столбец {j}");
            find = true;
            }               
        }
    }
    if (find == false)
    {
        Console.WriteLine($"число {num} не найдено");
    }
}