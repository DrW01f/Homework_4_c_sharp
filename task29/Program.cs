// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//из строки с 8 элементами разбить на 8 элементов и добавить в массив

string Input_func() //Ввод строки
{
    Console.WriteLine("Введите 8 чисел через запятую, например '1, 2, 3, 4, 5, 6, 7, 8'");
    string input_string = Console.ReadLine()!;
    return input_string;
}

int[] Magic(string string_from_input) //Преобразование строки в массив строк и преобразование в массив чисел
{
    string input_array = string_from_input.Replace(" ", ""); //убираю пробелы

    string[] array = string_from_input.Split(",");
    int[] out_array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        out_array[i] = int.Parse(array[i]);
    }
    return out_array;
}

void Print_func(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}" +  ", ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

void Main()
{
    Console.Clear();
    string entry = Input_func();
    int[] array = Magic(entry);
    Print_func(array);
}

Main();
