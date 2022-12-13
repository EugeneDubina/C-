Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;


for (int temp = 0; num > 0; num /= 10)
{
    temp = num % 10;
    sum = sum + temp;
}
Console.WriteLine(sum);