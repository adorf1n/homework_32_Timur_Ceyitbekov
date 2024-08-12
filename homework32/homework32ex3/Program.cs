using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { -4, -3, -2, 1, 2, -6, 7, 8 };
        List<int> evenNegatives = SequenceOperations.Method1(numbers);
        Console.WriteLine("Method1 - Чётные отрицательные числа: " + string.Join(", ", evenNegatives));

        int minPositive = SequenceOperations.Method2(numbers);
        Console.WriteLine("Method2 - Минимальный положительный элемент или 0: " + minPositive);

        List<int> positiveNumbers = new List<int> { 3, 7, 11, 8, 15 };
        List<string> sortedOddStrings = SequenceOperations.Method3(positiveNumbers);
        Console.WriteLine("Method3 - Отсортированные строки из нечётных чисел: " + string.Join(", ", sortedOddStrings));

        List<int> uniqueEndWithDigit = SequenceOperations.Method4(positiveNumbers, 5);
        Console.WriteLine("Method4 - Уникальные числа, оканчивающиеся на 5: " + string.Join(", ", uniqueEndWithDigit));

        List<string> strings = new List<string> { "Apple", "banana", "Cherry", "date", "Elderberry" };
        List<string> oddLengthCaps = SequenceOperations.Method5(strings, 4);
        Console.WriteLine("Method5 - Строки нечётной длины, начинающиеся с заглавной буквы до индекса 4: " + string.Join(", ", oddLengthCaps));

        List<int> sequence = new List<int> { 1, 2, 3, 4, 5, 10, 15 };
        List<int> twoDigitProducts = SequenceOperations.Method6(sequence);
        Console.WriteLine("Method6 - Двузначные произведения с обратным порядком: " + string.Join(", ", twoDigitProducts));
    }
}
