// *Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Введите количество строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
Console.WriteLine();
if (b == a)
{ Console.WriteLine("Количество столбцов должно быть не равно количеству строк!"); }
Console.WriteLine();
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
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
}
int[] CountArray(int[,] array)
{
    int[] sumarray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        int res = sum;
        sumarray[i] = res;
        Console.Write($"{res,4}; ");
    }
    return sumarray;
}


void Findstr()
{
    int[] result = CountArray(array);
    int temp = 0;
    int help = result[0];
    for (int i = 0; i < result.Length-1; i++)
    {
         if (result[i] < help)
        {
            help = result[i];
            temp = i;
        }
    }
Console.WriteLine($"номер строки с наименьшей суммой элементов:{temp+1}");
}
FillArray(array);
PrintArray(array);
Findstr();