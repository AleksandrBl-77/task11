int[] arr = new int[4];
int k = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 4; i++)
{
    arr[i] = rnd.Next(99, 1000);
    Console.Write("{0} ", arr[i]);
}
int NumberEven(int k)
{
foreach (int element in arr)
{
    if (element % 2 == 0)
    {
        k++;
    }
}
return k;
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов {(NumberEven(k))}  "  );
