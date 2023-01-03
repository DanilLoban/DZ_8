﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите чмсло, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чмсло, ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
void FillArray(int[,] arr)
{
    if (a * b <= 99)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int element = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                while (array[i, j] == 0)
                {
                    element = new Random().Next(10, 99);
                    if (!arrayContains(array, element))
                    {
                        array[i, j] = element;
                    }
                }
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool arrayContains(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                return true;
            }
        }
    }
    return false;
}

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();