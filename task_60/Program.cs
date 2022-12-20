Console.Write("Задайте высоту массива ");
int m = int.Parse(Console.ReadLine());

Console.Write("Задайте ширину массива ");
int n = int.Parse(Console.ReadLine());

Console.Write("Задайте глубину массива ");
int k = int.Parse(Console.ReadLine());

int[,,] array = new int[m,n,k]; 

int[,,] newArray = NewArray(array);


int[,,] NewArray(int[,,] array)
{
for (int ind1 = 0; ind1 < m; ind1++)
{
    for (int ind2 = 0; ind2 < n; ind2++)
   {
    for (int ind3 = 0; ind3 < k; ind3++)
    {
    array[ind1,ind2,ind3] = new Random().Next(0,9);
    }
    }
}
return array;
}

void PrintArray(int[,,] inArray)
{
    for (int ind1 = 0; ind1 < m; ind1++)
    {
        for (int ind2 = 0; ind2 < n; ind2++)
        {
            for (int ind3 = 0; ind3 < k; ind3++)
        {
            Console.Write($" {inArray[ind1,ind2,ind3]} ({ind1}, {ind2}, {ind3}) ");
        }
        }
        Console.WriteLine();
    }
}
PrintArray(newArray);

Console.WriteLine();