int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
void Zadacha1()
{
    int a=InputMessage("Ведите первую сторону: ");
    int b=InputMessage("Ведите вторую сторону: ");
    int c=InputMessage("Ведите третью сторону: ");
    if (a==b|| b==c||a==c) Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} ---> равнобедренный");
    else Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} ---> имеет разные стороны");
}

// Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.
void Zadacha2()
{

}

// Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.
void Zadacha3()
{

}

// Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
void Zadacha4()
{

}

 Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha4();


