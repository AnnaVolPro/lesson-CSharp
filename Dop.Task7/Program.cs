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

// Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4,
// заполнены числами от -9 до 9. Выполните умножение матриц.
void Zadacha1()
{

    Random random = new Random();
    int rows = 3;//random.Next(3, 5);
    int columns = 4; //random.Next(3, 5);
    int[,] arrayOne = new int[rows, columns];
    FillArray(arrayOne, 1, 9);
    PrintArray(arrayOne);
    Console.WriteLine();

    rows = 4;//random.Next(3, 5);
    columns = 4;//random.Next(3, 5);
    int[,] arrayTwo = new int[rows, columns];
    FillArray(arrayTwo, 1, 9);
    PrintArray(arrayTwo);

    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0) || arrayOne.GetLength(0) == arrayTwo.GetLength(1))
    {
        rows = arrayOne.GetLength(0);
        columns = arrayTwo.GetLength(1);
        int[,] arrayProduct = new int[rows, columns];
        Console.WriteLine();
        for (int k = 0; k < arrayProduct.GetLength(0); k++)
        {
            for (int m = 0; m < arrayProduct.GetLength(1); m++)
            {
                for (int j = 0; j < arrayTwo.GetLength(0); j++)
                {
                    Console.WriteLine($"{arrayOne[k, j]} * {arrayTwo[j, m]} \t{arrayProduct[k, m] + arrayOne[k, j] * arrayTwo[j, m]}");
                    arrayProduct[k, m] = arrayProduct[k, m] + arrayOne[k, j] * arrayTwo[j, m];
                }
            }
        }
        Console.WriteLine();
        PrintArray(arrayProduct);
    }
    else Console.WriteLine("Данные матрицы невозможно перемножить");
}

// Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999. 
// Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения. 
// Выведите оба массива.
void Zadacha2()
{

}

// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами. 
// Игрок может ходить только по полям, заполненным единицами. 
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).
void Zadacha3()
{

}

Zadacha1();
// Zadacha2();
// Zadacha3();