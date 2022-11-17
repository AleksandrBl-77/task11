Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

void knowdayOff()

{
    if (number <= 5 && number > 0)
    {
        Console.WriteLine("нет");
    }
    if (number > 5 && number <= 7)
    {
        Console.WriteLine("да");
    }
    if (number > 7)
    {
        Console.WriteLine($"{number} это некорректные данные ");
    }
}
knowdayOff();