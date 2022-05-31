/*
Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(3, 5);
PrintArray(array);
Console.Write("Введите позицию элемента(строка):");
int possi = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента(столбец):");
int possj = Convert.ToInt32(Console.ReadLine());
int result = 0;
void FindPossArray(int[,] array)
{
    /*отсчет с 0 строки и 0 столбца
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == possi && j == possj)
            {
                result = array[i, j];
            }
        }

    }*/
    //отсчет с 1 строки и 1 стобца для большего понимания обычному пользователю
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (possi - 1) && j == (possj - 1))
            {
                result = array[i, j];
            }
        }

    }
    if (result == 0)
    {
        Console.WriteLine($"Данный элемент в массиве отсутсвует.");
    }
    else Console.WriteLine($"Найден элемент! Его значение: {result}");
}
FindPossArray(array);