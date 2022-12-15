int[] array = new int[10];
int i = 0;
int sum = 0;

for (; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    
}
Console.WriteLine(string.Join(", ", array));

for (int j = 0; j < array.Length; j++)
{
    if(j % 2 == 1)
    {
       sum = sum + array[j];
    }
}
Console.WriteLine(sum);