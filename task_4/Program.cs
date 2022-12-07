Console.WriteLine("Введите первое число - ");
string firstNum = Console.ReadLine();
int num1 = int.Parse (firstNum);

Console.WriteLine("Введите второе число - ");
string secondNum = Console.ReadLine();
int num2 = int.Parse (secondNum);

Console.WriteLine("Введите третье число - ");
string thirdNum = Console.ReadLine();
int num3 = int.Parse(thirdNum);

int max = num1;

if (num2 > max)
    {
      max = num2;  
    }

if (num3 > max)
    {
      max = num3;  
    }

Console.WriteLine($"Максимальное из чисел: {max}");
