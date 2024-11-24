using System;

class Program
{
    static void Main()
    {
        int size = 20; // Размер массива
        int[] array = new int[size];
        Random random = new Random();

        // Заполнение массива случайными числами от 1 до 100
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101); // Случайные числа от 1 до 100
        }

        // Вывод массива на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Поиск максимального нечетного элемента на четных позициях
        int maxOdd = int.MinValue;
        bool found = false;

        for (int i = 0; i < size; i += 2) // Проверяем только четные позиции (0, 2, 4, ...)
        {
            if (array[i] % 2 != 0) // Проверяем, является ли элемент нечетным
            {
                if (array[i] > maxOdd) // Сравниваем с текущим максимумом
                {
                    maxOdd = array[i];
                    found = true;
                }
            }
        }

        // Вывод результата
        if (found)
        {
            Console.WriteLine($"Максимальный нечетный элемент на четных позициях: {maxOdd}");
        }
        else
        {
            Console.WriteLine("Нет нечетных элементов на четных позициях.");
        }
    }
}