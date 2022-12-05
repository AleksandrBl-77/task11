Console.WriteLine("Введите колличество строк ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ");
int num2 = Convert.ToInt32(Console.ReadLine());

double[,] arrayTable = new double[num1, num2];
var random = new Random();

ArrayTable (num1, num2);
void ArrayTable (int num1, int num2)
{
for (int i =0; i < arrayTable.GetLength(0); i++)
    {
       for (int j =0; j < arrayTable.GetLength(1); j++) 
       {
        arrayTable[i,j] = random.NextDouble()* 10; 

            Console.Write($"{Math.Round(arrayTable[i, j], 1)}   ");
       }
       Console.WriteLine();
    }
}