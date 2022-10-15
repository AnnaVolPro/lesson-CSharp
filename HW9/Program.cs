int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Multiple(int from, int to)
{
    if (from > to) return;
    if (from % 3 == 0) Console.Write(from + "\t");
    from++;
    Multiple(from, to);
}

int SumNatural(int from, int to, int sum = 0)
{
    if (from > to) return sum;
    sum = sum + from;
    from++;
    return SumNatural(from, to, sum);
}

int Accerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Accerman(m - 1, 1);
        }
        else 
        {
            return Accerman(m - 1, Accerman(m, n - 1));
        }
    }
    
// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64()
{
    int m = InputMessage("Введите число m: ");
    int n = InputMessage("Введите число n: ");
    Console.Write($"Числа в промежутке от  {m} до {n} кратные 3 ----->  ");
    Multiple(m, n);
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Zadacha66()
{
    int m = InputMessage("Введите число m: ");
    int n = InputMessage("Введите число n: ");
    int sum = SumNatural(m, n);
    Console.Write($"Сумма натуральных чисел в промежутке от  {m} до {n}  -----> {sum} ");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Zadacha68()
{
    int m = InputMessage("Введите число m: ");
    int n = InputMessage("Введите число n: ");
    int acc = Accerman(m, n);
    Console.Write(acc);
}

// Zadacha64();
// Zadacha66();
// Zadacha68();