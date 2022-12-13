Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int num2 = int.Parse(Console.ReadLine());
int pow = num1;

for(int i = 1; i < num2; i++)
{
    pow = pow * num1;
}
Console.WriteLine(pow);