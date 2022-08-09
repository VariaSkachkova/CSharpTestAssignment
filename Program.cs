void Task()
{
    Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
    int size = 4;
    string[] array = new string[size];
    array = FillArray(size);
    Console.WriteLine("Вывод первоначального массива:");
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
    Console.WriteLine("Вывод отсортированного массива:");
    Console.Write("[");
    FilterArrayByStringLength(array);
}

string[] FillArray(int size)
{
    string[] fillArray = new string[size];
    for (int i = 0; i < fillArray.Length; i++)
    {
        Console.WriteLine("Введите значение элемента:");
        fillArray[i] = Console.ReadLine();

    }
    return fillArray;

}

void FilterArrayByStringLength(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + "," + "  ");
        }

    }
    Console.Write("\b" + "\b" + "\b" + "]");
}

Task();
