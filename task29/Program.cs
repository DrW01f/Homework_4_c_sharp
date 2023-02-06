// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//из строки с 8 элементами разбить на 8 элементов и добавить в массив

//1 функция ввода в виде строки
//2 Разбиение строки на части по запятой и сохранение в массив
//3 перевод массива в число

string Input_func()
{
    Console.WriteLine("Введите 8 чисел через запятую, например '1, 2, 3, 4, 5, 6, 7, 8'");
    string input_string = Console.ReadLine()!; 
    int[] input_array = int.Parse(input_string.Split(' '));


    // while (input.Length == 0)
    // {
    //     Console.WriteLine("Введите 8 чисел через запятую, например '1, 2, 3, 4, 5, 6, 7, 8'");
    //     input = Console.ReadLine()!;    
    // }
    

    return input_array;
}

void Main()
{
    Console.Clear();
    int[] entry = Input_func();


}

