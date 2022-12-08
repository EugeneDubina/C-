Console.WriteLine("Введите любое число - ");
string enterNum = Console.ReadLine();

int Length = enterNum.Length;
if (Length < 3)
{
    Console.WriteLine($"Число меньше 100");
}
else
{
    Console.Write($"Третья по счету цифра - ");
    Console.WriteLine(enterNum.Substring(2, 1));
}
