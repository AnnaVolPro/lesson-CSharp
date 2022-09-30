void TaskFriendsDog()
{
    double distance = 10000;
    double time = 0;
    double FFSpeed = 1;
    double SFSpeed = 2;
    double DogSpeed = 5;
    double count = 0;
    int Friend = 2;

    while (distance > 10)
    {
        if (Friend == 1)
        {
            time = distance / (FFSpeed + DogSpeed);
            Friend = 2;
        }

        if (Friend == 2)
        {
            time = distance / (SFSpeed + DogSpeed);
            Friend = 1;
        }

        distance = distance - (FFSpeed + SFSpeed) * time;
        count = count + 1;

    }
    Console.WriteLine(count);

}

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

int Random(int MinValue, int MaxValue)
{
    Random random = new Random();
    return random.Next(MinValue, MaxValue);
}

double CoordDistance(int a, int b, int a1, int b1)
{
    return Math.Round(Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2)), 2);
}



void Task2()
{
    //Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    int num = Random(100, 1000);
    Console.WriteLine(num);
    int hundred = num / 100;
    int tens = (num % 100) / 10;
    int ones = num % 10;
    if ((hundred + tens + ones) % 3 == 0) Console.Write("Кратно");
    else Console.Write("Не кратно");
}

void Task3()
{
    // Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    int num = Random(100, 1000);
    Console.WriteLine(num);
    if (num / 100 == 7 || (num % 100) / 10 == 7 || num % 10 == 7) Console.WriteLine("В числе еcть цифра 7");
    else Console.WriteLine("Вчисле НЕТ цифры 7");
    if (num / 100 == 4 || (num % 100) / 10 == 4 || num % 10 == 4) Console.WriteLine("В числе еcть цифра 4");
    else Console.WriteLine("Вчисле НЕТ цифры 4");
}

void Task4()
{
    // Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
}

void Zadacha1() //ДОРАБОТАТЬ
{
    // На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
    // Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
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


void Zadacha2()
{
    //Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. Размер массива должен совпадать с квадратом количества единиц в нём.

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

// TaskFriendsDog();
// Task2();
// Task3();
// Task4();
// Zadacha1();
