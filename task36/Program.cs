int[] arr = new int[4];

Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 4; i++)
{
    arr[i] = rnd.Next(-99, 100);
    Console.Write("{0} ", arr[i]);
}

var even = arr.Where((element, index) => index % 2 != 0);
Console.WriteLine("Сумма четных: {1}.", even.Count(), even.Sum());
