// Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
void Zadacha2()
{
    int num = Random(100, 1000);
    Console.WriteLine(num);
    int hundred = num / 100;
    int tens = (num % 100) / 10;
    int ones = num % 10;
    if ((hundred + tens + ones) % 3 == 0) Console.Write("Кратно");
    else Console.Write("Не кратно");
}

// Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
void Zadacha3()
{
    int num = Random(100, 1000);
    Console.WriteLine(num);
    if (num / 100 == 7 || (num % 100) / 10 == 7 || num % 10 == 7) Console.WriteLine("В числе еcть цифра 7");
    else Console.WriteLine("Вчисле НЕТ цифры 7");
    if (num / 100 == 4 || (num % 100) / 10 == 4 || num % 10 == 4) Console.WriteLine("В числе еcть цифра 4");
    else Console.WriteLine("Вчисле НЕТ цифры 4");
}

// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
void Zadacha4()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
}

////////////////////////////////////////////////////Задачи повышенной сложности://///////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
void Zadacha21()
{
    int num = Random(1, 5);
    Console.WriteLine(num);

    if (num == 1)
    {
        int x1 = Random(0, 101);
        int y1 = Random(0, 101);
        int x2 = Random(0, 101);
        int y2 = Random(0, 101);
        int x3 = Random(0, 101);
        int y3 = Random(0, 101);
        Console.Write($"Точка А({x1};{y1})   точка В({x2};{y2})   точка С({x3};{y3}) ");
    }
    else if (num == 2)
    {
        int x1 = Random(-100, 1);
        int y1 = Random(0, 101);
        int x2 = Random(-100, 1);
        int y2 = Random(0, 101);
        int x3 = Random(-100, 1);
        int y3 = Random(0, 101);
        Console.Write($"Точка А({x1};{y1})   точка В({x2};{y2})   точка С({x3};{y3}) ");
    }
    else if (num == 3)
    {
        int x1 = Random(-100, 1);
        int y1 = Random(-100, 1);
        int x2 = Random(-100, 1);
        int y2 = Random(-100, 1);
        int x3 = Random(-100, 1);
        int y3 = Random(-100, 1);
        Console.Write($"Точка А({x1};{y1})   точка В({x2};{y2})   точка С({x3};{y3}) ");
    }
    else if (num == 4)
    {
        int x1 = Random(0, 101);
        int y1 = Random(-100, 1);
        int x2 = Random(0, 101);
        int y2 = Random(-100, 1);
        int x3 = Random(0, 101);
        int y3 = Random(-100, 1);
        Console.Write($"Точка А({x1};{y1})   точка В({x2};{y2})   точка С({x3};{y3}) ");
    }
    int x = 0;
    int y = 0;
    double disnance1 = CoordDistance(x, y, x1, y1);

}

// Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?
void Zadacha22()
{
    
}

// Задача 3. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).
void Zadacha23()
{
    
}

// Задача 4. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начали и конца.
// Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.
void Zadacha24()
{
    
}

// Задача 5. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак.
void Zadacha25()
{
    
}

// Задача 6. Из центра координат к точке А(x, y) проведён отрезок АО. Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X.
void Zadacha26()
{
    
}

// Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. Удалить из массива все элементы, содержащие цифру 3. 
// Вывести в консоль новый массив и количество удалённых элементов.
void Zadacha27()
{
    
}

// Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.
void Zadacha28()
{
    
}

// Задача 9. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.
void Zadacha29()
{
    
}


// Zadacha2();
// Zadacha3();
// Zadacha4();
// Zadacha21();
// Zadacha22();
// Zadacha23();
// Zadacha24();
// Zadacha25();
// Zadacha26();
// Zadacha27();
// Zadacha28();
// Zadacha29();








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

