// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!

long Exponentiation(int count, int rank)
{
    int i = 1;
    while (i <= rank)
    {
        count *= count;
        i++;
    }
 
    return count;
}


void Main()
{
    Console.WriteLine("Введите число");
    int count = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите степерь");
    int rank = int.Parse(Console.ReadLine()!);
     Console.WriteLine(Exponentiation(count, rank));
}

Main();
