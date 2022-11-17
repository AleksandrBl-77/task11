int random = new Random().Next(100, 1000);
Console.WriteLine(random);

int NumberTwo(int ran)
{
    int number2 = ((random / 10) % 10);
    return number2;
}

int numberTwo = NumberTwo(random);

Console.WriteLine(numberTwo);