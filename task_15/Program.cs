Console.WriteLine("Введите номер дня недели (от 1 до 7)");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Можешь отдохнуть");
}
else
{
    Console.WriteLine("Иди работай");
}
