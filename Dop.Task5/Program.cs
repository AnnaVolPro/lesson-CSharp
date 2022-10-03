// Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, 
// которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет
void Zadacha1()
{

}

// Задача 2 На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.
// 24, 132 -> {2, 6, 4, 4, 12, 8}
void Zadacha2()
{

}

// Задача 3 Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. Подсчитайте их количество.
void Zadacha3()
{

}

// Задача 1*. Дан массив массивов, состоящих из натуральных чисел, размер которого 5. Для каждого элемента-массива требуется найти сумму его элементов и вывести массив с наибольшей суммой. Если таких массивов несколько, вывести массив с наименьшим индексом.
// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/jagged-arrays
void Zadacha11()
{

}

// Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha11();



                                    int Input()  // Функция ввода чисел
                                    {
                                        Console.Write("Введите  число: ");
                                        return Convert.ToInt32(Console.ReadLine());
                                    }

                                    void FullArray(int[] numbers, int MinValue = 0, int MaxValue = 100) // Придав значения мин и макс по умолчанию, мы можем не заполнять в вызове функции параметры,они будут в диапозоне по умолчанию (от 0 до 100)
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

                                    int Random(int MinValue, int MaxValue)
                                    {
                                        Random random = new Random();
                                        return random.Next(MinValue, MaxValue);
                                    }

                                    double CoordDistance(int a, int b, int a1, int b1)
                                    {
                                        return Math.Round(Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2)), 2);
                                    }


