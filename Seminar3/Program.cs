int Input()  // Функция ввода чисел
{
    Console.Write("Введите  число: ");
    return Convert.ToInt32(Console.ReadLine());
}


void Zadacha17()
{
    //Напишите программу, которая принимает на вход координаты точки (X и Y), 
    //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
    Random random = new Random();
    int x = random.Next(-10, 10);
    int y = random.Next(-10, 10);
    Console.WriteLine($"Координаты точки A({x} , {y})");
    CoordCheck(x, y);
}
void CoordCheck(int x, int y) // метод проверки координат
{
    if (x > 0 && y > 0) Console.Write("Данная точка находится в 1 четверти");
    else if (x < 0 && y > 0) Console.Write("Данная точка находится во 2 четверти");
    else if (x < 0 && y < 0) Console.Write("Данная точка находится во 3 четверти");
    else if (x > 0 && y < 0) Console.Write("Данная точка находится во 4 четверти");
    else Console.WriteLine("Точка лежит на одной из осей");
}

void Zadacha18()
{
    // Напишите программу, которая по заданному номеру четверти, 
    // показывает диапазон возможных координат точек в этой четверти (x и y).
    Console.Write("Ведите номер четверти: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1) Console.Write("Диапазон х(0,+ ∞) и y (0,+ ∞)");
    else if (num == 2) Console.Write("Диапазон х(- ∞, 0)  и y (0,+ ∞)");
    else if (num == 3) Console.Write("Диапазон х(- ∞, 0)  и y (- ∞, 0)");
    else if (num == 4) Console.Write("Диапазон х(0,+ ∞)  и y (- ∞, 0)");
    else Console.Write("Такой четверти не существует");
}

void Zadacha21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и
    // находит расстояние между ними в 2D пространстве.
    double Distance(int x, int x1, int y, int y1)
    {
        // Math.Pow(x-x1, 2); // Math.Pow() функция возведения в квадрат, в скобках то ,что возводим в квадрат и степень
        double dist = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2)); // функция извлечения квадратного корня
        dist = Math.Round(dist, 2); //округление до 2х знаков после запятой
        return dist;
    }

    Random random = new Random();
    int x = random.Next(-100, 100);
    int y = random.Next(-100, 100);
    int x1 = random.Next(-100, 100);
    int y1 = random.Next(-100, 100);
    Console.WriteLine($"({x};{y}) ({x1};{y1})");
    Console.Write(Distance(x, y, x1, y1));
}

void Zadacha22()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    int num = Input();
    int count = 1;
    while (count <= num)
    {
        double square = Math.Pow(count, 2);
        if (count == num) Console.WriteLine($"{count}*{count}={square}. ");
        else Console.WriteLine($"{count}*{count}={square}, ");
        count++;
    }
}

// Zadacha17();
// Zadacha18();
// Zadacha21();
// Zadacha22();
