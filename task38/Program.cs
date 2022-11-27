int[] d = new int[10];
Random rnd = new Random();

int max = 0, min = 100;
for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}

for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
Console.WriteLine();
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница максимального и минимального:  " + (max - min));
