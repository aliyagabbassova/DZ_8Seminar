//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите количетсво a строк и b столбцов матрицы1");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[a, b];
FillArray (array); 
 
Console.WriteLine("Введите количество c строк и d столбцов матрицы2");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2 = new int[c, d];
FillArray (array2);

if (b!=c)
{Console.WriteLine("Число столбцов b матрицы1 должно совпадать c числом строк c матрицы2!");}
var result = MultiMatrix(array, array2);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(result);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j],4}");
        Console.WriteLine();
    }
}
int[,] MultiMatrix(int[,] array, int[,]array2)
{
    int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] += array[i,k]*array2[k, j];
            } 
        }
        
    }
    return array3;
}
