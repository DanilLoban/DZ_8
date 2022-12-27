// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[a, b];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = array[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
void Print(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
}
    PrintArray(arr);
    FillArray(arr);
    Print(arr);