//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//Console.WriteLine("Hello, World!");
Console.Clear();
int InputRows()
{
    Console.Write("Введите количество строк: ");
    int rows = 1;
    while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
    {
        Console.Write("Введите количество строк: ");
    }
    return rows;
}

int InputCol()
{
    Console.Write("Введите количество столбцов: ");
    int colums = 1;
    while (!int.TryParse(Console.ReadLine(), out colums) || colums <= 0)
    {
        Console.Write("Введите количество столбцов: ");
    }
    return colums;
}

void FillArr(int[,] arr)
{
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10);
        }
    }
}

void PrintArr(int[,] arr)
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

void MinSummInRows(int[,] arr)
{
    int minRow = 0;//первая строка минимальная
    int minSumInRow = 0;
    int sumInRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minRow += arr[0, i];
    }
    Console.WriteLine($"Сумма элементов первой строки:  {minRow}");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumInRow += arr[i, j];
        }
        
        if (sumInRow < minRow)
        {
            minRow = sumInRow;
            minSumInRow = i;
        }
        sumInRow = 0;
    }
    Console.Write($"Минимальная сумма находится в строке: {minSumInRow + 1}");
}

int rows = InputRows();
int colums = InputCol();
int[,] arr = new int[rows, colums];
FillArr(arr);
PrintArr(arr);
MinSummInRows(arr);