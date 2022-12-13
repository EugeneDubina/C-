int[] arr = new int[8];
var rnd = new Random();
for (int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next(0, 100);
}
Console.Write("[");
Console.Write(string.Join(",", arr));
Console.Write("]");