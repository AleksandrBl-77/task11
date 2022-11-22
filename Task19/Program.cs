int input = new Random().Next(10000, 100000);

Console.WriteLine(input);

int FindPalindrom(int number)
{
	int rev_num = 0;
	int origin_num = number;
	while(origin_num > 0)
	{
		rev_num = (rev_num *10) + origin_num % 10;
		origin_num = origin_num / 10;

	}
	return rev_num;
}

int Reverse = FindPalindrom(input);
if(Reverse == input)
{
	Console.Write("Palindrom");
}
else
{
	Console.Write("Not Palindrom");
}