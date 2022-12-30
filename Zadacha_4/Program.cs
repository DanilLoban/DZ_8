// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите число, ");
Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
int[,] ArrayGenerated()
{
    if( a * b <= 89)
    {
        Console.Write("Генерация массива, ");
        int number;
        for(int i = 0; i < a; i++)
        {
            for(int j = 0; j < b; j++)
            {
                while(array[i, j] == 0)
                {
                    number = new Random().Next(10, 89);
                    if(!arrayContains(array, number))
                    {
                        array[i, j] = number;
                    }
                }
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        return array;
    }
    else
    {
        Console.WriteLine("Уникальных чисел меньше");
        return array;
    }
}
bool arrayContains(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number);
            {
                return true;
            }
        }
    }
    return false;  
}
void Array2DPrint(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
}
