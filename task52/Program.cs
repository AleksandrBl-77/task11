Console.WriteLine("Введите колличество строк ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[num1, num2];
var random = new Random();

ArrayTable(num1, num2);
void ArrayTable(int num1, int num2)
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

FindAverage(array);

void FindAverage(int[,] matrix)
{
double summa = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
summa = 0;
for (int j = 0; j < matrix.GetLength(0); j++)
{
summa += array[j, i];
}
summa /= matrix.GetLength(0);
Console.WriteLine("Среднее арифметическое столбца равно: " + Math.Round(summa, 2));
}
}








