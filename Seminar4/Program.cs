void Zadacha24()
{
    //Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    Console.Write("Введите число: ");
    int num =Convert.ToInt32(Console.ReadLine());
    int sum=0;
    for(int i=1;i<=num;i++)
    {
        sum=sum+i;
    }
    Console.Write($"{sum}");
}

void Zadacha26()
{
    // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Console.Write("Введите число: ");
    int num =Convert.ToInt32(Console.ReadLine());
    int i=1;
    while (num>=10)
    {
        num=num/10;
        i++;
    }
    Console.Write(i);

    // Вариант решения через массив 7894561

    // Console.Write("Введите число: ");
    // string array=Console.ReadLine();
    // Console.Write(array.Length);

    // Вариант чере логарифм


}

void Zadacha28()
{
    //Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
    Console.Write("Введите число: ");
    int num =Convert.ToInt32(Console.ReadLine());
    double product=1;
    for(int i=1;i<=num;i++)
    {
        product=product*i;
    }
    Console.Write(product);
}


void Zadacha30()
{
    // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    int [] numbers=new int [8];
    Random random=new Random();
    FullArray(numbers);
    PrintArray(numbers);
    
}

void FullArray(int [] num) //метод для заполнения массива
{
    Random random=new Random();
    for(int i=0;i<num.Length;i++)
    {
        num[i]=random.Next(0,2);
    }
}

void PrintArray(int[] num) // метод печати массива
{
    for(int i=0;i<num.Length;i++)
    {
        Console.Write(num[i]+"  " );
    }
    Console.WriteLine();
}
// Zadacha24();
// Zadacha26();
// Zadacha28();
// Zadacha30();

