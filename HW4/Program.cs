                                void FullArray(int[] num) //метод для заполнения массива
                                {
                                    Random random = new Random();
                                    for (int i = 0; i < num.Length; i++)
                                    {
                                        num[i] = random.Next(-10, 10);
                                    }
                                }

                                void PrintArray(int[] num) // метод печати массива
                                {
                                    for (int i = 0; i < num.Length; i++)
                                    {
                                        Console.Write(num[i] + "  ");
                                    }
                                    Console.WriteLine();
                                }

                                int Random(int MinValue, int MaxValue)
                                {
                                    Random random = new Random();
                                    return random.Next(MinValue, MaxValue);
                                }

                                void SortArrayAbs(int[] numbers) // сортировка массива от мин до макс по модулю числа
                                {
                                    for (int i = 1; i < numbers.Length; i++)
                                    {
                                        for (int j = 0; j < numbers.Length - i; j++)
                                        {
                                            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
                                            {
                                                int tmp = numbers[j];
                                                numbers[j] = numbers[j + 1];
                                                numbers[j + 1] = tmp;
                                            }
                                        }

                                    }
                                }


void Zadacha25()
{
    //  Используя определение степени числа, напишите цикл, 
    // который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    int a = Random(1, 11);
    int b = Random(1, 11);

    Console.Write($"{a} в {b} степени = ");
    int result = 1;
    for (int count = 1; count <= b; count++)
    {
        result = result * a;
    }
    Console.Write(result);
}

void Zadacha27()
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма всех цифр в числе {num} = ");
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    Console.Write(sum);
}

void Zadacha29()
{
    //  Напишите программу, которая задаёт массив из 8 случайных целых чисел 
    // и выводит отсортированный по модулю массив.
    int[] numbers = new int[8];
    FullArray(numbers);
    PrintArray(numbers);
    SortArrayAbs(numbers);
    PrintArray(numbers);
}




// Zadacha25();
// Zadacha27();
// Zadacha29();
