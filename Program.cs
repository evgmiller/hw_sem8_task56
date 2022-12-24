// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int [] ResMas (int [,] ar)
{
    int [] SumMas= new int [ar.GetLength(0)];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        SumMas[i]=0;
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            SumMas[i]+=ar[i,j];
        }
    }
    return SumMas;
}

void SearchRow (int [] ar)
{
    int min=ar[0];
    int minI=0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        if(ar[i]<min)
        {
            min=ar[i];
            minI=i;
        }
    }
Console.WriteLine($"Строка с наименьшей суммой числе= {minI}");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");

        }
        Console.WriteLine();
    }
}

void PrintArray1(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]}  ");
    }
        Console.WriteLine();
}



int[,] array= GetArray(5,4,0,5);
PrintArray(array);
Console.WriteLine();
int[]Sum= ResMas(array);
PrintArray1(Sum);
SearchRow(Sum);
