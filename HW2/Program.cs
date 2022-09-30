                        int Input()
                        {
                            Console.Write("Введите число: ");
                            return Convert.ToInt32(Console.ReadLine());
                        }
                        
                        
                        void Zadacha10()
                        {
                            //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

                            Console.Write("Введите трёхзначное  число: ");
                            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                            
                            if(num/100<=9 && num/100>=1)  // Здесь проверяем трехзначное ли число, по условиям задачи можно и без проверки, но решила оставить для отработки сложных условий
                            {
                                int num2 = (num %100)/10;
                                Console.Write(num2);
                            }
                            else
                            Console.Write("Не корректный ввод, необходимо ввести трёхзначное число.");
                        }

                        void Zadacha13() 
                        {
                            //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
                            int num=Math.Abs(Input()); 

                            if(num/100<1) Console.Write("В этом числе нет третьей цифры"); 
                            else
                            {
                                int result=num;
                                while(result/100>9) // этим циклом мы приводим число к трехзначному виду
                                {
                                    result=result/10; // каждый цикл уменьшаем число на один разряд
                                }
                                result=(result%100)%10; 
                            Console.Write(result);
                            }
                        }

                        void Zadacha15()
                        {
                            // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
                            Console.Write("Ведите число от 1 до 7: ");
                            int num=Convert.ToInt32(Console.ReadLine());
                            string[] week={"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

                            if(num==6 || num==7) Console.Write($"{week[num-1]} - выходной день!");
                            else Console.Write(week[num-1]);
                        }



 // Zadacha10();
 // Zadacha13(); 
 // Zadacha15();
