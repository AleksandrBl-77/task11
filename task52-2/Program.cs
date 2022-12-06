Console.WriteLine("Введите колличество строк ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ");
int num2 = Convert.ToInt32(Console.ReadLine());
var random = new Random();
int[,] array = ArrayTable(num1, num2);

PrintArray(array);

int[,] ArrayTable (int num1, int num2)
{
int[,] array = new int[num1, num2];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = random.Next(0, 25);
}
}
return array;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}
}

Console.WriteLine("Введите координаты строки элемента");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты столбца элемента");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(ElementCoordinates(array, a, b));

int ElementCoordinates(int[,] arr, int num1, int num2)
{
if (num1 > arr.GetLength(0) || num2 > array.GetLength(1))
return 0;
else
{
return arr[num1, num2];
}
}