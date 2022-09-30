
                void Zadacha19()
                {
                    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                    Console.Write("Введите число: ");
                    string array = Console.ReadLine()!;
                    if (array.Length == 5)
                    {
                        if (array[0] == array[4] && array[1] == array[3])
                        {
                            Console.Write($"Число  {array}  является палиндромом");
                        }
                        else Console.Write($"Число  {array}  НЕ является палиндромом");
                    }
                    else Console.Write("ОШИБКА! Введите пятизначное число.");
                }

                void Zadacha19SecondVar() // второй вариант решения задачи 19
                {
                    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 9999 && num < 100000)
                    {
                        if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
                        {
                            Console.Write($"Число  {num}  является палиндромом");
                        }
                        else Console.Write($"Число  {num}  НЕ является палиндромом");
                    }
                    else Console.Write("ОШИБКА! Введите пятизначное число.");
                }

                void Zadacha21()
                {
                    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                    Random random=new Random();
                    int x1=random.Next(-10,10);
                    int y1=random.Next(-10,10);
                    int z1=random.Next(-10,10);
                    int x2=random.Next(-10,10);
                    int y2=random.Next(-10,10);
                    int z2=random.Next(-10,10);
                    
                    Console.WriteLine($"A({x1};{y1};{z1})\t B({x2};{y2};{z2})");
                    double distance=Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
                    Console.WriteLine($"Расстрояние между точками A и B =  {Math.Round(distance,2)}");

                }


                void Zadacha23()
                {
                    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int n = 1;
                    Console.WriteLine("Число\tЧисло в кубе");
                    while (n <= num)
                    {
                        Console.WriteLine($"{n}\t{Math.Pow(n, 3)}");
                        n++;
                    }
                }



// Zadacha19();
// Zadacha19SecondVar();
// Zadacha21();
// Zadacha23();
