int Input()  // Функция ввода чисел
{
    Console.Write("Введите  число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void FullArray(int[] numbers, int MinValue = 0, int MaxValue = 100) // Придав значения мин и макс по умолчанию, мы можем не заполнять в вызове функции параметры, 
                                                                    // они будут в диапозоне по умолчанию (от 0 до 100)
{
    MaxValue++; // чтобы вручную не записывать максимальное значение на 1 больше
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(MinValue, MaxValue);
    }
}

void PrintArray(int[] numbers) // Печать массива
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

int GetSummPositive(int[] numbers) // сумма положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum = sum + numbers[i];
        }
    }
    return sum;
}

int GetSummNegative(int[] numbers) // сумма отрицательных элементов массива
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum = sum + numbers[i];
        }
    }
    return sum;
}

void FoundElements(int[] numbers, int element) // Поиск элемента в массиве
{
    bool find = false; // логическая переменная, либо ложь либо истина. Дефолтное значение-ложь.
    for (int i = 0; !find && i < numbers.Length; i++)
    {
        if (numbers[i] == element) find = true;
    }
    // int i=0;
    // while (!find && i<numbers.Length)
    // {
    //     if (numbers[i] == element) find = true;
    //     i++;
    // }
    if (find) // find сама по себе является логической переменной, она  и есть true
    {
        Console.Write($"Элемент со значением {element}  есть в данном массиве.");
    }
    else Console.Write($"Элемента со значением {element}  нет в массиве.");
}

int CountElements(int[] numbers, int minValue, int maxValue) // Подсчет количества элементов в диапозоне от мин до макс значения
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] <= maxValue && numbers[i] >= minValue) count++;
    }
    return count;
}



void Zadacha31()
{
    //Задайте массив из 12 элементов, заполненный
    // случайными числами из промежутка [-9, 9]. Найдите сумму
    // отрицательных и положительных элементов массива.
    // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
    // положительных чисел равна 29, сумма отрицательных равна -20.
    int size = 12;
    int[] numbers = new int[size];
    FullArray(numbers);
    PrintArray(numbers);
    Console.WriteLine(GetSummPositive(numbers));
    Console.WriteLine(GetSummNegative(numbers));
}

void Zadacha32()
{
    // Напишите программу замены элементов
    // массива: положительные элементы замените на
    // соответствующие отрицательные, и наоборот.
    // [-4, -8, 8, 2] -> [4, 8, -8, -2]
    int size = 10;
    int[] numbers = new int[size];
    FullArray(numbers, -9, 9);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1; // numbers[i] = numbers[i] * -1
    }
    PrintArray(numbers);
}

void Zadacha33()
{
    // Задайте массив. Напишите программу, которая
    // определяет, присутствует ли заданное число в массиве.
    // 4; массив [6, 7, 19, 345, 3] -> нет
    // 3; массив [6, 7, 19, 345, 3] -> да

    int size = 10;
    int[] numbers = new int[size];
    int num = Input();
    FullArray(numbers, 0, 10);
    PrintArray(numbers);
    FoundElements(numbers, num);
}

void Zadacha35()
{
    //Задайте одномерный массив из 10 случайных чисел.
    // Найдите количество элементов массива, значения которых лежат в
    // отрезке [10,99].
    // [5, 18, 123, 6, 2] -> 1
    // [1, 2, 3, 6, 2] -> 0
    // [10, 11, 12, 13, 14] -> 5
    int size = 10;
    int[] numbers = new int[size];
    FullArray(numbers, 0, 200);
    PrintArray(numbers);
    Console.Write(CountElements(numbers, 10, 99));
}

void Zadacha37()
{
    //Найдите произведение пар чисел в одномерном массиве.
    // Парой считаем первый и последний элемент, второй и предпоследний
    // и т.д. Результат запишите в новом массиве.
    // [1 2 3 4 5] -> 5 8 3
    // [6 7 3 6] -> 36 21
    int size = 5;
    int[] numbers = new int[size];
    FullArray(numbers, -9, 9);
    PrintArray(numbers);
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex - i]} ");
    }
    if(size%2==1)
    {
        Console.WriteLine(numbers[size/2]); // средний элемент массива в массиве с нечетным количеством элементов
    }
    Console.WriteLine();

}
// Zadacha31();
// Zadacha32();
// Zadacha33();
// Zadacha35();
// Zadacha37();