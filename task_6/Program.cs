Console.WriteLine("Введите число - ");
string enterNum = Console.ReadLine();
int num = int.Parse(enterNum);

if (num%2 == 0)
    {
        Console.WriteLine($"{num} - четное");
    }
else
    {
        Console.WriteLine($"{num} - нечетное");
    }
