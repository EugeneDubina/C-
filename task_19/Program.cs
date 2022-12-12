
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int numRevers = 0;

if(num < 0 || (num % 10 == 0 && num != 0))
{
    Console.WriteLine("No!");
    return;
}
while (num > numRevers)
{
    numRevers = numRevers * 10 + num % 10;
    num /= 10;
}
if (num == numRevers || num == numRevers/10)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("Нет");
}