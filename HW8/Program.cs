void FillArray(int[,] numbers, int MinValue = 0, int MaxValue = 100)
{
    MaxValue++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(MinValue, MaxValue);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();

    }
}

void PrintOneDimensionalArray(int[] numbers) // Печать массива
{
    Console.WriteLine("Массив сумм элементов в строке ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "\t");
    }
    Console.WriteLine();
}

void SortElementsRows(int[,] numbers, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
}

int MinSumInRows(int[,] numbers, int rows, int columns)
{
    int[] sumInRows = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumInRows[i] = sumInRows[i] + numbers[i, j];
        }
    }
    int min = sumInRows[0];
    int indexMin = 0;
    for (int i = 0; i < sumInRows.Length; i++)
    {
        if (sumInRows[i] < min)
        {
            min = sumInRows[i];
            indexMin = i;
        }
    }
    return indexMin;
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void Zadacha54()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    SortElementsRows(numbers, rows, columns);
    PrintArray(numbers);
}
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Zadacha56()
{
    var random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(6, 10);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine();
    int indexMin = MinSumInRows(numbers, rows, columns);
    Console.WriteLine($"Cтрока с наименьшей суммой элементов: {indexMin + 1} строка (счет идет от 1)");
}

// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Zadacha58()
{
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    int count = 1;
    PrintArray(numbers);
    Console.WriteLine();

    for (int j = 0, i = 0; j < columns; j++, count++) numbers[i, j] = count;

    for (int j = columns - 1, i = 1; i < rows; i++, count++) numbers[i, j] = count;

    for (int j = columns - 2, i = rows - 1; j >= 0; j--, count++) numbers[i, j] = count;

    for (int j = 0, i = rows - 2; i > 0; i--, count++) numbers[i, j] = count;

    for (int j = 1, i = rows - 3; j < columns - 1; j++, count++) numbers[i, j] = count;

    for (int j = columns - 2, i = rows - 2; j > 0; j--, count++) numbers[i, j] = count;

    PrintArray(numbers);
}

// Zadacha54();
// Zadacha56();
 Zadacha58();

