int[] array = new int[8];

int[] DefinesArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = new Random().Next(0, 100);
    }
   
    return arr;
}

void PtintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[] n = DefinesArray(array);
PtintArray(n);