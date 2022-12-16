Console.Write("Значение b1.  b1 = ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Значение k1.  k1 = ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Значение b2.  b2 = ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Значение k2.  k2 = ");
double k2 = double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;

Console.WriteLine($"Точка пересечения - ({x},{y})");