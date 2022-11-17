System.Console.Write("Введите число: ");
void determinesThird()
{
    string num = Console.ReadLine();
    char result = num[2];
    if(num == null) {
        Console.WriteLine("нет числа");
    }
    else
    {
      Console.WriteLine(result);  
    }
}
determinesThird();