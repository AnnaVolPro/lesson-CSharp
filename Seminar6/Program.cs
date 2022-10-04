int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] numbers, int MinValue = 0, int MaxValue = 100) // Придав значения мин и макс по умолчанию, мы можем не заполнять в вызове функции параметры, 
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

void PrintArrayDouble(double[] numbers) // Печать массива
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

void ReverseArray(int[] numbers) // разворот массива c использованием кортежа
{
    int maxIndex = numbers.Length - 1;
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        //метод кортежа может принимать несколько значений 
        // и позволяет менять местами элементы без использования дополнительных переменных
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}

void ConverBinarSystem(int number)
{
    int num = number;
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    Console.Write($"Число {number} в двоичном виде --> {result}");
}

void ConvertSustem(int num, int value = 2) // где 2 это система счисления
{
    string result = Convert.ToString(num, value);
    Console.WriteLine(result);
}

void CopyArray(int [] num, int[] num2)
{
    for(int i=0;i<num.Length;i++)
    {
        num2[i]=num[i];
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
void Zadacha39()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers); // с помощью кортежей
    PrintArray(numbers);
}

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
void Zadacha40()
{
    int a = InputMessage("Введите первое число: ");
    int b = InputMessage("Введите второе число: ");
    int c = InputMessage("Введите третье число: ");
    Console.WriteLine($"Первая сторона: {a}, вторая сторона: {b}, третья сторона: {c}.");
    if (a + b > c && a + c > b && c + b > a) Console.Write($"Треугольник со сторонами {a}, {b} и {c} существует");
    else Console.Write($"Треугольник со сторонами {a}, {b} и {c} НЕ существует");
}

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
void Zadacha42()
{
    int number = InputMessage("Введите число в десятичной записи: ");
    ConvertSustem(number, 2);
    // ConverBinarSystem(number);
}
// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void Zadacha44()
{
    int size = InputMessage("Введите число : ");;
    int a = 0;
    int b = 1;
    double [] numbers = new double[size];
    numbers[0]=a;
    numbers[1]=b;
    for (int i = 2; i < size; i++)
    {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }
    PrintArrayDouble(numbers);
}

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
void Zadacha45()
{
    int size=10;
    int [] numbers=new int[size];
    int [] other=new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.ReadKey(); //задержка вывода
    CopyArray(numbers,other);
    PrintArray(other);
    
}

// Zadacha39();
// Zadacha40();
// Zadacha42();
// Zadacha44();
 Zadacha45();
