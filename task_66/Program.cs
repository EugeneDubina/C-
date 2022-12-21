Console.WriteLine("Введите числа от и до которых мы считаем");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


int SumNum(int a, int b)
{
    if (a == b) return 0;
    else return a + SumNum(a + 1, b);
}

Console.Write($"Сумма чисел = {SumNum(a, b)}");