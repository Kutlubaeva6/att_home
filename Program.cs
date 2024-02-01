using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи (от 1 до 3)");
        int task_number = Convert.ToInt16(Console.ReadLine());
        switch (task_number)
        {
            case 1: task_1(); break;
            case 2: task_2(); break;
            case 3: task_3(); break;

            default: Console.WriteLine("нет такой задачи"); break;
        } 
        Console.ReadKey();
    }

    // Задача 1: 
    // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
    // в промежутке от M до N. Использовать рекурсию, не использовать циклы.
    public static void task_1()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:"); 
        PrintNaturalNumbers(m, n);
    }

    public static void PrintNaturalNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.WriteLine(current);
            PrintNaturalNumbers(current + 1, end);
        }
    }    

    // Задача 2: 
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    public static void task_2()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
        int result = Ackermann(m, n);

        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}");
    }

    public static int Ackermann(int m, int n)
    {
        if (m == 0)
            return (n + 1);
        else if (m != 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    // Задача 3:
    // Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
    public static void task_3()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    public static void PrintArrayReverse(int[] array, int index)
    {
        // Базовый случай: если индекс выходит за пределы массива, завершаем рекурсию
        if (index < 0)
            return;

        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}
