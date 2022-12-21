Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int Akk(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
      if ((a != 0) && (b == 0))
        return Akk(a - 1, 1);
    else
        return Akk(a - 1, Akk(a, b - 1));
}
 
Console.WriteLine(Akk(a, b));