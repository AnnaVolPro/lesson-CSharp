                        void Zadacha1()
                        {
                            //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

                            Console.WriteLine("Введите первое число: ");
                            int a=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            int b=Convert.ToInt32(Console.ReadLine());

                            if(a>b)
                            {
                                Console.Write($"Первое число больше второго  {a}>{b}");
                            }
                            else
                            {
                                Console.Write($"Второе число число больше первого  {b}>{a}");
                            }
                        }

                        void Zadacha2()
                        {
                            // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

                            Console.WriteLine("Введите первое число: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите третье число: ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            int max=a;

                            if(b>max)
                            {
                                max=b;
                                if(c>max)
                                {
                                    max=c;
                                } 
                            }
                            if(c>max)
                            {
                                max=c;
                            }
                            Console.WriteLine("max= " + max);
                        }

                        void Zadacha3()
                        {
                            //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

                            Console.WriteLine("Введите число: ");
                            int num=Convert.ToInt32(Console.ReadLine());

                            if(num%2==0)
                            {
                                Console.WriteLine("Это число четное =)");
                            }
                            else
                            {
                                Console.WriteLine("Это число НЕчетное =( ");
                            }
                        }

                        void Zadacha4()
                        {
                            //Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

                            Console.WriteLine("Введите число больше 0: ");
                            int n=Convert.ToInt32(Console.ReadLine());
                            int count=2;

                            if(n>0)
                            {
                                while(count<=n)
                                {
                                    Console.Write(count + ", ");
                                count=count+2;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода!");
                            }
                            Console.WriteLine();
                        }

// Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha4();
