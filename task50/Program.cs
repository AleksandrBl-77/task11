Console.WriteLine("Введите колличество строк ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[num1, num2];
var random = new Random();

ArrayTable (num1, num2);
void ArrayTable (int num1, int num2)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 25));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}
}

ElementCoordinates(num1, num2);
void ElementCoordinates(int num1, int num2)
{
    Console.WriteLine("Введите координаты строки элемента");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты столбца элемента");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > num1 && b > num2)
        Console.WriteLine("такого числа нет");
    else
    {
        object? c = array.GetValue(a, b);
        Console.WriteLine(c);
    }
}


