int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void InputNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count += 1;
    }
    return count;
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

void InputCoefficient(double [,] coeff)
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void Zadacha41()
{
    int size = InputMessage("Сколько будет введено чисел?---> ");
    int[] numbers = new int[size];
    InputNumbers(numbers);
    PrintArray(numbers);
    Console.WriteLine($"Введено чисел больше 0: {CountPositiveNumbers(numbers)} ");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Zadacha43()
{

    double[,] coeff = new double[2, 2];
    double[] crossPoint = new double[2];
    InputCoefficient(coeff);

    double x = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    double y = x * coeff[0, 0] + coeff[0, 1];
    
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Console.Write($"\nТочка пересечения прямых: ({x}, {y})");
    }
}

// Zadacha41();
// Zadacha43();
