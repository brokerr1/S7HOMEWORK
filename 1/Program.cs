/*
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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