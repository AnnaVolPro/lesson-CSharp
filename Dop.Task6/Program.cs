// Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.
void Zadacha1()
{

}
// Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
void Zadacha2()
{
    Console.Clear();
    string phrase = "без труда не выловишь и рыбку из пруда";
    char[] alphabet = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

    // int count = 0;
    // foreach (char letter in phrase)
    // {
    // bool contain = alphabet.Contains(letter);
    // if (contain) count++;
    // Console.WriteLine($"буква {letter} гласная: {contain}");
    // }
    // Console.WriteLine($"В поговорке {count} гласных букв");
    int CountOfVowelLetters(
                            string phrase,
                            char[] alphabet,
                            int count = 0,
                            int index = 0)
    {
        if (index == phrase.Length) return count;
        bool contain = alphabet.Contains(phrase[index]);
        if (contain) count++;
        index++;
        return CountOfVowelLetters(phrase, alphabet, count, index);

    }
    Console.WriteLine($"В поговорке {CountOfVowelLetters(phrase, alphabet)} гласных букв");
}
// Задача 3. Дано число N. Используя только операцию деления и рекурсию, определите, что оно является степенью числа 3.
void Zadacha3()
{

}

// Задача 1*. Создайте программу, показывающую текущее время. Для вывода чисел используйте двумерные массивы.
// https://docs.microsoft.com/ru-ru/dotnet/api/system.datetime?view=net-6.0
void Zadacha11()
{

}

// Zadacha1();
// Zadacha2();
// Zadacha3();
// Zadacha11();
