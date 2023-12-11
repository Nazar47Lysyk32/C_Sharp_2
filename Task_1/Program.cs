using System;

// Делегат для лямбда-функції фільтрації
delegate bool FilterDelegate(int number);

class Program
{
    static void Main()
    {
        // Створюємо масив цілих чисел
        int[] numbers = { 2, 5, 12, 8, 3, 15, 7 };

        // Викликаємо метод для фільтрації та виведення результату
        FilterAndPrint(numbers, EvenFilter, "Even numbers:");
        FilterAndPrint(numbers, OddFilter, "Odd numbers:");
        FilterAndPrint(numbers, GreaterThanTenFilter, "Numbers greater than 10:");
    }

    // Лямбда-функції для фільтрації
    static FilterDelegate EvenFilter = number => number % 2 == 0;
    static FilterDelegate OddFilter = number => number % 2 != 0;
    static FilterDelegate GreaterThanTenFilter = number => number > 10;

    // Метод для фільтрації та виведення результату
    static void FilterAndPrint(int[] numbers, FilterDelegate filter, string message)
    {
        Console.WriteLine(message);
        foreach (var number in numbers)
        {
            if (filter(number))
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();
    }
}
