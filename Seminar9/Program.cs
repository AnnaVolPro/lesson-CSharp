int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int number, int counter = 0)
{
    Console.WriteLine(counter);
    if (counter >= number) return;
    counter++;
    Numbers(number, counter);
}

// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
void Zadacha63()
{
    int num = InputMessage("Введите число: ");
    Numbers(num, 1);
}

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 
void Zadacha65()
{
    int m = InputMessage("Введите число: ");
    int n = InputMessage("Введите число: ");
    Numbers(n, m);
}

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
void Zadacha67()
{
    int numbers = InputMessage("Введите число: ");
    int Sum(int num, int sum = 0)
    {
        if (num == 0) return sum;
        sum = sum + num % 10;
        num = num / 10;
        return Sum(num, sum);
    }
    Console.WriteLine(Sum(numbers));
}

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 
void Zadacha69()
{
    int a = InputMessage("Введите число: ");
    int b = InputMessage("Введите число: ");
    void NumSqrt(int num, int num2, int product = 1)
    {
        if (num2 == 0)
        {
            Console.WriteLine($"{product}");
            return;
        }
        product = product * num;
        num2--;
        NumSqrt(num, num2, product);
    }
    NumSqrt(a, b);
}

// Zadacha63();
// Zadacha65();
// Zadacha67();
// Zadacha69();