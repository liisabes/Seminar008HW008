//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
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
            arr[i, j] = random.Next(2, 5);
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




int rows = InputRows();
int colums = InputCol();
int[,] resultArr = new int[rows, colums];
int[,] firstArr = new int[rows, colums];
int[,] secondArr = new int[rows, colums];


Console.WriteLine("Первая матрица: ");
FillArr(firstArr);
PrintArr(firstArr);

Console.WriteLine("Вторая матрица: ");
FillArr(secondArr);
PrintArr(secondArr);

Console.WriteLine("Результат: ");
void ResultArr()
{
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            resultArr[i, j] = 0;
            for (int k = 0; k < firstArr.GetLength(1); k++)
            {
                resultArr[i, j] += firstArr[i, k] * secondArr[k, j];
            }
        }
    }
}
ResultArr();
PrintArr(resultArr);