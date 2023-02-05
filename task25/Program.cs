// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!

int[] Input()
{
    Console.WriteLine("Введите число");
    int count = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите степерь");
    int rank = int.Parse(Console.ReadLine()!);
    int[] array = { count, rank };
    return array;
}

long Exponentiation(int[] array)
{
    int i = 1;
    long result = 1;

    while (i <= array[1]) // возведение в степень
    {
        result *= array[0];
        i++;
    }
    return result;
}


void Main()
{
    Console.Clear();
    int[] countRank = Input();
    Console.WriteLine(Exponentiation(countRank));
}

Main();
