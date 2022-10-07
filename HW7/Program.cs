int Random(int MinValue, int MaxValue)
{
    MaxValue++;
    Random random = new Random();
    return random.Next(MinValue, MaxValue);
}

void FillArrayDouble(double[,] numbers, int rounding) // rounding-аргумент отвечающий за округление до определенного количества знаков после запятой
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round((random.NextDouble() * 100 - 50), rounding);
        }
    }
}

void PrintArrayDouble(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers, int MinValue = 0, int MaxValue = 10)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Random(MinValue, MaxValue);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowElementsToArray(int[,] numbers, int i, int j)
{
    if (i >= numbers.GetLength(0) || j >= numbers.GetLength(1))
    {
        Console.WriteLine("Элемента с таким адресом нет в массиве.");
    }
    else Console.WriteLine($"Элемент с индексами [{i};{j}]----> {numbers[i, j]}");
}

void AverageColumns(int[,] numbers)
{
    
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        int amount = numbers.GetLength(0);
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = average + numbers[i, j];
        }
        Console.WriteLine($"Среднее арифметическое всех элементов {j+1} столбца = {Math.Round((average / amount), 1)}");
    }
}

// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Zadacha47()
{
    int rows = Random(4, 8);
    int columns = Random(4, 8);
    double[,] doubleNumbers = new double[rows, columns];
    FillArrayDouble(doubleNumbers, 1);
    PrintArrayDouble(doubleNumbers);
}

// Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Zadacha50()
{
    int rows = Random(4, 8);
    int columns = Random(4, 8);
    int[,] numbers = new int[rows, columns];

    FillArray(numbers, 0, 100);
    PrintArray(numbers);
    Console.WriteLine();

    int i = InputMessage($"Введите номер строки от 0 до {rows - 1}:\n");
    int j = InputMessage($"Введите номер столбца от 0 до {columns - 1}:\n");
    ShowElementsToArray(numbers, i, j);
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Zadacha52()
{
    int rows = Random(8, 10);
    int columns = Random(8, 10);
    int[,] numbers = new int[rows, columns];

    FillArray(numbers, 0, 40);
    PrintArray(numbers);
    Console.WriteLine();
    AverageColumns(numbers);
}

// Zadacha47();
// Zadacha50();
// Zadacha52();