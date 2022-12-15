int[] GetArray(int size, int minNum, int maxNum)
{
Console.Write("Массив ");

    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum);
        Console.Write($"{res[i]} ");
    }    
      return res;
      Console.WriteLine();
 }

   int[] res = GetArray(9,100,999);
   void PrintArray(int[] array)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (res[i]%2 == 0) count += 1;
    } 
  Console.WriteLine();
  Console.WriteLine($"Количество четных чисел в массиве = {count}");
 }

  PrintArray(res);