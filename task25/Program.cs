Console.Write("Введите число:  ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень:  ");
int y = Convert.ToInt32(Console.ReadLine());

double FindDegree(int x, int y)
{
    double degree = Math.Pow(x , y);

   return degree;
}
double result = FindDegree(x,y);
Console.WriteLine(result);