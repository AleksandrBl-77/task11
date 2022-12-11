Console.Clear();
Console.WriteLine($"\nВведите размер массива от M до N и диапазон случайных значений:");
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}







// class Program
//     {
//         //Вызов метода создания новой матрицы[5,10]
//         public static void CreateArray(int[,] myArray)
//         {
//             Random rnd = new Random();
//             /* 
//                ---Заполнение массива рандомными числами (-10,10)--- 
//                ---вывод его на консоль---
//             */
//             for(int i = 0; i < 10; i++) //Проходим по циклу строк
//             {
//                 Console.Write("\n{0}:", i);
//                 for(int j = 0; j < 20; j++) //Проходим по циклу столбцов
//                 {
//                     myArray[i, j] = rnd.Next(10, 99); //Заполняем текущий элемент
//                     Console.Write("{0}  ", myArray[i, j]);
//                 }
//             }
//         }
 
//         static void Main(string[] args)
//         {
//             int[,] myArray = new int[10,20];
//             int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
//             CreateArray(myArray);
 
//             for(int i = 0; i < 10; i++) //Проходим по циклу строк
//             {
//                 Sum2 = 0;
//                 for(int j = 0; j < 20; j++) //Проходим по циклу столбцов
//                 {   Sum2 += myArray[i, j];  } //Сумма всех членов 1ой строки.
//                 if(Sum2 < Sum1)
//                 {   Sum = Sum2; Row = i;    }
//                 Sum1 = Sum2;
//             }
//             Console.WriteLine("\n\t Наименьшаяя сумма = {0}",Sum);
//             Console.WriteLine("\n\t Номер строки = {0}", Row);
 
//             Console.ReadKey();
//         }
//     }