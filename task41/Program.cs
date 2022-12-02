
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"Кол-во элементов > 0: {CountOfElems(arr)}");

int CountOfElems(int[] array)
{
int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
count++;
}
}

return count;
}