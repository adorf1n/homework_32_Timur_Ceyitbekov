using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };

        List<int> sortedNumbers = numbers.CustomSort();

        Console.WriteLine("Original List: " + string.Join(", ", numbers));
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedNumbers));
    }
}
