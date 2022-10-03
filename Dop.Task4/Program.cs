// Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.
void Zadacha1()
{

}

//Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. Размер массива должен совпадать с квадратом количества единиц в нём.
void Zadacha2()
{
    Random random = new Random();
    int countOnes = random.Next(1, 11);
    Console.WriteLine("Количество единиц " + countOnes);
    int size = countOnes * countOnes;
    int[] numbers = new int[size];

    for (int i = 0; i < countOnes; i++)
    {
        int randomIndex = random.Next(0, size);
        while (numbers[randomIndex] == 1)
        {
            Console.WriteLine($"Элемент {randomIndex + 1} уже равен 1, ищем следующий");
            randomIndex = random.Next(0, size);
        }
        numbers[randomIndex] = 1;
        Console.WriteLine($"Элемент {randomIndex + 1} стал 1");
    }
    PrintArray(numbers);
}

// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. Определите самый часто встречающийся элемент в массиве. 
// Если таких элементов несколько, вывести их все.
void Zadacha3()
{
    
}

/////////////////////// Создание игры: ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 1*. С помощью команд очистки консоли и печати реализовать игру-бродилку в консоли.
// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.clear?view=net-6.0
// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposition?view=net-6.0
// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.readkey?view=net-6.0
// https://docs.microsoft.com/ru-ru/dotnet/api/system.consolekey?view=net-6.0
void Zadacha11()
{

}

// Задача 2*. Создать игру лабиринт.
void Zadacha12()
{
    
}

// Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha11();
// Zadacha12();



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

