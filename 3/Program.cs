/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
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
Console.WriteLine("Введите размер массива: ");
Console.Write("Количество строк: ");
int sizei = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int sizej = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(sizei, sizej);
PrintArray(array);
double summary = 0;
void MathArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summary = summary + array[j, i];
        }
        double result = summary / sizei;
        Console.Write("{0:0.0 }",result);
        result = 0;
        summary = 0;
    }
}
Console.WriteLine("Среднее арифметическое столбцов:");
MathArray(array);