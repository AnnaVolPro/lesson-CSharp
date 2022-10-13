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

void PrintOneDimensionalArray(int[] num) // метод печати массива
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "  ");
    }
    Console.WriteLine();
}

void ChangeArray(int[,] numbers, int rows, int columns)
{
    int maxIndex = rows - 1;
    int maxColumns = numbers.GetLength(1);
    for (int j = 0; j < maxColumns; j++)
    {
        (numbers[0, j], numbers[maxIndex, j]) = (numbers[maxIndex, j], numbers[0, j]); // метод кортежей
    }
}


// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

void Zadacha53()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    ChangeArray(numbers, rows, columns);
    PrintArray(numbers);
}


// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
void Zadacha55()
{
    var random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    if (rows == columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
            }
        }
        PrintArray(numbers);
    }
    else Console.WriteLine("Невозможно заменить строки на столбцы");
}
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
void Zadacha57()
{
    var random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 9);
    PrintArray(numbers);
    Console.WriteLine();
    int[] dictionary = new int[10]; // по методу словаря еще можно решить!
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dictionary[numbers[i, j]]++;
        }
    }
    for (int i = 0; i < dictionary.Length; i++)
    {
        Console.WriteLine($"Эллемент {i} встречается {dictionary[i]} раз");
    }
}

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива
void Zadacha59()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -100, 100);
    PrintArray(numbers);
    Console.WriteLine();

    int min = numbers[0, 0];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    Console.WriteLine($"N[{iMin+1},{jMin+1}]={min}");
    int rowsResult=rows-1;
    int columnsResult=columns-1;
    int [,] result=new int [rowsResult,columnsResult];
    int biasI=0;
    int biasJ=0;
    for (int i = 0; i < rowsResult; i++)
    {
        if(i==iMin) biasI++;
        biasJ=0;
        for (int j = 0; j < columnsResult; j++)
        {
            if(j==jMin) biasJ++;
            result[i,j]=numbers[i+biasI,j+biasJ];
        }
    }
    PrintArray(result);
}

// Zadacha53();
// Zadacha55();
// Zadacha57();
Zadacha59();
