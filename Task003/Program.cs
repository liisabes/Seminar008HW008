// Задача 60.
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Clear();

int size = 2;
int[,,] arr = new int[size, size, size];
int min = 10;
int max = 99;
FillArr(arr);
PrintArr(arr);

void FillArr(int[,,] arr)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                while (arr[i, j, k] == 0)
                {
                    Random random = new Random();
                    int number = random.Next(min, max-1);
                    if (NumberInArr(arr, number) == false)
                    {
                        arr[i, j, k] = number;
                    }
                }
            }
        }
    }
}

bool NumberInArr(int[,,] arr, int number)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                if (arr[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArr(int[,,] arr)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                Console.Write($"({i},{j},{k}) {arr[i, j, k]} "+ " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}










