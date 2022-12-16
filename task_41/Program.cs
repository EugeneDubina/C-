Console.WriteLine("Кол-во вводимых чисел");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите {n} чисел(-а) через Enter" );

int count = 0;
for (int i=0; i<n; i++)
{
if (int.Parse(Console.ReadLine()) > 0)
    count=count+1;
}
Console.WriteLine($" Кол-во положительных чисел = {count}");