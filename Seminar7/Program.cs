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

// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
void Zadacha46()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    Console.WriteLine();
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
}

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.
void Zadacha48()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
    PrintArray(numbers);

}

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
void Zadacha49()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Размер массива {rows}x{columns}");
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Новый массив");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
    Console.WriteLine();
    PrintArray(array);
}

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0);
// (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
void Zadacha51()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Размер массива {rows}x{columns}");
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) sum = sum + array[i, j];
        }
    }
    Console.WriteLine($"Сумма всех элементов главной диагонали {sum}");

}

// Дан двумерный массив из двух строк и двадцати двух столбцов. В его пер-
// вой строке записано количество мячей, забитых футбольной командой в той
// или иной игре, во второй — количество пропущенных мячей в этой же игре.
// а) Для каждой проведенной игры напечатать словесный результат: "выиг-
// рыш", "ничья" или "проигрыш".
// б) Определить количество выигрышей данной команды.
// в) Определить количество выигрышей и количество проигрышей данной
// команды.
// г) Определить количество выигрышей, количество ничьих и количество про-
// игрышей данной команды.
// д) Определить, в скольких играх разность забитых и пропущенных мячей
// была большей или равной трем.
// е) Определить общее число очков, набранных командой (за выигрыш даются
// 3 очка, за ничью — 1, за проигрыш — 0).
void ZadachaDop1()
{
    int rows = 2;
    int columns = 10;
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
    int sumWin=0;
    int sumLose=0;
    int sumDraw=0;
    for (int i = 0; i <columns; i++)
    {
        if (array[0,i] > array[1,i]) 
        {
            Console.WriteLine($"Win {array[0,i]}:{array[1,i]}");
            sumWin++;
        }
        else if (array[0,i] < array[1,i]) 
        {
            Console.WriteLine($"Lose {array[0,i]}:{array[1,i]}");
            sumLose++;
        }
        else if (array[0,i] == array[1,i]) 
        {
            Console.WriteLine($"Draw {array[0,i]}:{array[1,i]}");
            sumDraw++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Команда выйграла {sumWin} раз, проиграла {sumLose}, ничья {sumDraw}");
    Console.WriteLine($"Общее количество очков {sumWin*3+sumDraw}");
}

// Zadacha46();
// Zadacha48();
// Zadacha49();
// Zadacha51();
// ZadachaDop1();