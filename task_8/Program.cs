Console.Clear();
Console.WriteLine("Введите число");
string enterNum = Console.ReadLine();
int num = int.Parse(enterNum);

int temp_num = 0;
int array_length = num/2;

if (num%2 == 0) 
    {
    temp_num = num;  
    array_length = num/2-1;
    }

if (num%2 != 0) temp_num = num+1;
  
int index_array = array_length;
int[] array = new int[array_length];

while (index_array >= 0)
    {
    index_array = index_array-1;  
    array[index_array] = temp_num-2;
    temp_num = temp_num-2;
    Console.WriteLine($"Четные = {array[index_array]}");   
    }
