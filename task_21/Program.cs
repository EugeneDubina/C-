Console.WriteLine ("Enter X1 : ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y1 : ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Z1 : ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter X2 : ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y2 : ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Z2 : ");
int Zb = int.Parse(Console.ReadLine());

double Distance = Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2);

double result = Math.Sqrt(Distance);

Console.WriteLine(result);