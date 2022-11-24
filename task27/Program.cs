Console.Write("Введите целое число:  ");
var n = Convert.ToInt32(Console.ReadLine());

int SumDigitsm(int num)
{
    var sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
int result = SumDigitsm(n);

Console.WriteLine(result);
