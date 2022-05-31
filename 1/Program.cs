/*
Задайте двумерный массив размером M x N, заполненный случайными вещественными числами.
*/
int [,] GetArray(int a, int b)
{
    int [,] array = new int[a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rndNum.Next(10);
        }     
    } 
    return array;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();     
    } 
}
Console.WriteLine("Введите размерность массива");
Console.Write("Количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);