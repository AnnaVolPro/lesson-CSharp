int Random(int MinValue, int MaxValue)
{
    Random random = new Random();
    return random.Next(MinValue, MaxValue);
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

double FoundMaxElements(double [] numbers)
    {
        double max=numbers[0];
        for(int i=1;i<numbers.Length;i++)
        {
            if(numbers[i]>max) max=numbers[i];
        }
        return max;
    }

double FoundMinElements(double [] numbers)
    {
        double min=numbers[0];
        for(int i=1;i<numbers.Length;i++)
        {
            if(numbers[i]<min) min=numbers[i];
        }
        return min;
    }



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
void Zadacha34()
{
    int size=Random(10,21);
    int [] positiveNumbers=new int [size];
    int count=0;
    FullArray(positiveNumbers,100,999);
    PrintArray(positiveNumbers);

    for(int i=0; i<size;i++)
    {
        if(positiveNumbers[i]%2==0) count++;
    }
    Console.Write($"В массиве {count} четных элементов. ");
}

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами. 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0
void Zadacha36()
{
    int size=Random(10,21);
    int [] randomNumbers=new int [size];
    int sum=0;
    FullArray(randomNumbers,-10,20);
    PrintArray(randomNumbers);
    for(int i=1;i<size;i=i+2) sum=sum+randomNumbers[i];
    Console.Write("Сумма всех элементов с Нечетными индексами = "+ sum);
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95
void Zadacha38()
{
    int size=Random(10,21);
    double [] doubleNumbers=new double [size];
    double max;
    double min;
    double diff;
    Random random=new Random();
    for(int i=0;i<size;i++)
    {
        doubleNumbers[i]=Math.Round((random.Next(-10,10)+random.NextDouble()),2); 
        Console.Write(doubleNumbers[i] +"   ");
    }
    Console.WriteLine();
    max=FoundMaxElements(doubleNumbers);
    min=FoundMinElements(doubleNumbers);
    diff=Math.Round(max-min,2);
    Console.WriteLine($"max= {max}  min= {min}");
    Console.Write($"max > min на {diff}");
}

// Zadacha34();
// Zadacha36();
// Zadacha38();
