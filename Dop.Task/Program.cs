// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
// N = 4 -> 1, 1, 1, 1
// N = 2 -> 1, 1
void Zadacha1()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int count = 0; count < num; count++)
    {
        Console.Write(1 + " ");
    }
}

// Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.
void Zadacha2()
{
    Random random = new Random();
    int a = random.Next(1, 11);
    int b = random.Next(20, 100);
    Console.Write($"Число {a} поместится в числе {b} ---> {b / a} раз ");
}

// Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.
void Zadacha3()
{
    Random random = new Random();
    int[] state = new int[3];
    state[0] = random.Next(150, 230);
    state[1] = random.Next(150, 230);
    state[2] = random.Next(150, 230);
    Console.WriteLine($"Рост первого:{state[0]} \t Рост второго:{state[1]} \t Рост третьего:{state[2]}");
    for (int i = 0; i < state.Length - 1; i++)
    {
        int maxState = i;
        for (int j = i + 1; j < state.Length; j++)
        {
            if (state[j] > state[maxState]) maxState = j;
        }
        int temporary = state[i];
        state[i] = state[maxState];
        state[maxState] = temporary;
    }
    Console.Write($"Рост самого высокого:{state[0]} \t Рост среднего:{state[1]} \t Рост самого низкого:{state[2]}");
}

// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
// N = 72334 -> 20:5:34 
void Zadacha4()
{
    Console.WriteLine("Введите количество секнд: ");
    int time=Convert.ToInt32(Console.ReadLine());
    
    int hours=time/3600;
    int minuts=(time%360)/60;
    int seconds=(time%360)%60;
    Console.WriteLine($"Время----->  {hours}:{minuts}:{seconds} ");
}

// Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha4();

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


