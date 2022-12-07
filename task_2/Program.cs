Console.WriteLine("Введите первое число - ");
string firstNum = Console.ReadLine();
int num1 = int.Parse(firstNum);

Console.WriteLine("Введите второе число - ");
string secondNum = Console.ReadLine();
int num2 = int.Parse(secondNum);


if (num1==num2)
{
    Console.WriteLine($"{num1} = {num2}");
}

if (num1 > num2)
{
    Console.WriteLine($"{num1} > {num2}");
}
if (num1 < num2)
{
    Console.WriteLine($"{num2} > {num1}");
}
