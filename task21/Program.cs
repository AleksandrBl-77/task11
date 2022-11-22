Console.WriteLine("Введите координату точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Double Find3ddistance(int xA, int yA, int xB, int yB, int zA, int zB)
{
double A = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
return A;
}
Double result = Find3ddistance( x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);