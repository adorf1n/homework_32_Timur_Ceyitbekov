using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        if (input.MyIsNullOrEmptyWhiteSpace())
        {
            Console.WriteLine("Строка пуста или состоит только из пробелов.");
            return;
        }

        input = input.MyTrim();

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Привести в верхний регистр");
        Console.WriteLine("2. Привести в нижний регистр");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Верхний регистр - " + input.MyToUpper());
                break;
            case "2":
                Console.WriteLine("Нижний регистр - " + input.MyToLower());
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }
}
