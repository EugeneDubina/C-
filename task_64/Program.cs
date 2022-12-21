Console.WriteLine("Стартовое число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(NumbersRec(num));

string NumbersRec(int num)
{
    if (num >= 1) return $"{num}," + NumbersRec(num - 1);
    else return String.Empty;
}