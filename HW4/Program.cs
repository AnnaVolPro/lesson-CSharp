                    void FullArray(int [] num) //метод для заполнения массива
                    {
                        Random random=new Random();
                        for(int i=0;i<num.Length;i++)
                        {
                            num[i]=random.Next(-10,10);
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

                    int Random(int MinValue, int MaxValue)
                    {
                        Random random = new Random();
                        return random.Next(MinValue, MaxValue);
                    }


                    void Zadacha25()
                    {
                        //  Используя определение степени числа, напишите цикл, 
                        // который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
                        int a=Random(1,11);
                        int b=Random(1,11);
                    
                        Console.Write($"{a} в {b} степени = ");
                        int result=a;
                        for(int count=2;count<=b;count++)
                        {
                            result=result*a;
                        }
                        Console.Write(result);
                    }

                    void Zadacha27()
                    {
                        // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                        Console.Write("Введите число: ");
                        int num=Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Сумма всех цифр в числе {num} = ");
                        int sum=0;
                        while(num>0)
                        {
                            sum=sum+(num%10);
                            num=num/10;
                        }
                        Console.Write(sum);
                    }

                    void Zadacha29()
                    {
                        //  Напишите программу, которая задаёт массив из 8 случайных целых чисел 
                        // и выводит отсортированный по модулю массив.
                        int[] numbers=new int [8];
                        FullArray(numbers);
                        PrintArray(numbers);
                        int size=numbers.Length;
                        for(int i=0; i<size-1;i++)
                        {
                            int minNumberIndex=i;
                            for(int j=i+1; j<size;j++)
                            {
                                if(Math.Abs(numbers[j])<Math.Abs(numbers[minNumberIndex])) 
                                {
                                    minNumberIndex=j;
                                }
                            }
                            int tmp=numbers[i];
                            numbers[i]=numbers[minNumberIndex];
                            numbers[minNumberIndex]=tmp;
                        }
                        PrintArray(numbers);
                    }




// Zadacha25();
// Zadacha27();
// Zadacha29();
