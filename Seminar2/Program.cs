// Методы: процедуры(void, не возвращает результат своей работы) и функции(return, возвращает результат своей работы)
//void-пустота, не надо указывать тип данных, тк процедура ничего не возвращает

int a = 5;
int b = 15;
int c =20;

                        void Zadacha2()
                        {
                            if (a > b)
                            {
                                Console.Write($"Первое число больше второго  {a}>{b}");
                            }
                            else
                            {
                                Console.Write($"Второе число число больше первого  {b}>{a}");
                            }
                        }

                        void Zadacha4()
                        {
                            //     Console.WriteLine("Введите первое число: ");
                            // int a = Convert.ToInt32(Console.ReadLine());
                            // Console.WriteLine("Введите второе число: ");
                            // int b = Convert.ToInt32(Console.ReadLine());
                            // Console.WriteLine("Введите третье число: ");
                            // int c = Convert.ToInt32(Console.ReadLine());
                            int max=a;

                            if (b > max)
                            {
                                max = b;
                                if (c > max)
                                {
                                    max = c;
                                }
                            }
                            if (c > max)
                            {
                                max = c;
                            }
                            Console.WriteLine("max= " + max);
                        }


                        void Zadacha6()
                        {
                            //     Console.WriteLine("Введите число: ");
                            // int num=Convert.ToInt32(Console.ReadLine());

                            if (a % 2 == 0)
                            {
                                Console.WriteLine("Это число четное =)");
                            }
                            else
                            {
                                Console.WriteLine("Это число НЕчетное =( ");
                            }
                        }

                        void Zadacha8()
                        {
                            //     Console.WriteLine("Введите число больше 0: ");
                            // int n=Convert.ToInt32(Console.ReadLine());
                            int count = 2;

                            if (a > 0)
                            {
                                while (count <= a)
                                {
                                    Console.Write(count + ", ");
                                    count = count + 2;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода!");
                            }
                            Console.WriteLine();
                        }

                        void Zadacha9()
                        {
                            //Напишите программу, которая выводит случайное число из отрезка [10, 99] 
                            //и показывает наибольшую цифру числа
                            Random random = new Random(); //создание обьекта типа Random
                            int number = random.Next(10,100);
                            Console.WriteLine(number);
                            int tens = number / 10;
                            int ones = number % 10;
                            Console.WriteLine(tens);
                            Console.WriteLine(ones);

                            if (tens > ones)
                            {
                                Console.Write($"Первое число больше второго  {tens}>{ones}");
                            }
                            else
                            {
                                Console.Write($"Второе число число больше первого  {ones}>{tens}");
                            }
                        }

                        void Zadacha11()
                        {
                            //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
                            Random random = new Random();
                            int number = random.Next(100,1000);
                            Console.WriteLine(number);
                            int hundred = number / 100;
                            //int tens = (number  % 100)/10;  //можно не вычислять, в условиях задачи нет
                            int ones = number % 10;
                            Console.Write($"{hundred}{ones}");
                        }

                        void Zadacha13()
                        {
                            //Напишите программу, которая будет принимать на вход два числа и выводить, 
                            //является ли второе число кратным первому. Если число 2 не кратно числу 1, 
                            //то программа выводит остаток от деления.
                            Console.Write("Введите первое число: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите второе число: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            if(num1 % num2 ==0) 
                            {
                                Console.Write($"Число {num2} является кратным {num1}");
                            }
                            else
                            {
                                Console.Write($"Остаток от деления: {num1 % num2}");
                            }
                        }

                        void Zadacha14()
                        {
                            // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
                            Console.Write("Введите первое число: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            if (num1 % 7== 0 && num1 % 23 ==0) //if(num1 % (7*23) ==0)
                            {
                                Console.Write($"Число {num1} является кратным 7 и 23");
                            }
                            else 
                            {
                                Console.Write("Число не кратно ни 7, ни 23");
                            }
                        }

                        int Input()  // Функция ввода чисел
                        {
                            Console.Write("Введите  число: ");   
                            return Convert.ToInt32(Console.ReadLine());
                        }

                        void Zadacha16()
                        {
                            // Напишите программу, которая принимает на вход два числа 
                            // и проверяет, является ли одно число квадратом другого.

                            
                            int num1 = Input();
                            int num2 = Input();

                            if(num1==num2*num2 || num2==num1*num1)  // || - или 
                            { // num1==Math.Pow(num2, 2)-функция возведения числа в степень, где 2 это степень
                                Console.Write("Да");
                            }
                            else
                            {
                                Console.Write("Нет");
                            }

                        }

                        
                



                
                        




// Zadacha2();
// Zadacha4();
// Zadacha6();
// Zadacha8();
// Zadacha9();
// Zadacha11();
// Zadacha13();
// Zadacha14();
//Zadacha16();