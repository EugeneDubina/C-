Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine());
int i = 1;
while (i <= num)
{
    Console.Write($"{i * i * i} ,");
    i++;
}