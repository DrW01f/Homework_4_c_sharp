// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Input()
{
    Console.WriteLine("Введите число");
    int count = int.Parse(Console.ReadLine()!);
    return count;
}

int magic(int number)
{
    int count = 1;
    for(int del = 10; number / del > 0; del *= 10)
    {
        count ++;
    }
    return count;
}

void Main()
{
    Console.Clear();


}

Main();