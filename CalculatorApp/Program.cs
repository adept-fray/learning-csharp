Console.WriteLine("=== Calculator App ===");


double GetNumber()
{
    return Convert.ToDouble(Console.ReadLine());
}

while (true)
{
    Console.WriteLine("Enter first number:");
    double firstNumber = 0;
    try
    {
        firstNumber = GetNumber();
    }
    catch
    {
        Console.WriteLine("Not a number.");
        continue;
    }

    Console.WriteLine("Choose the operator: +, -, *, /");
    string op = Console.ReadLine();
    var operators = new string[] {"+", "-", "*", "/"};
    if(!operators.Contains(op))
    {
        Console.WriteLine("Not a valid operator.");
        continue;
    }

    Console.WriteLine("Enter second number:");
    double secondNumber = 0;
    try
    {
        secondNumber = GetNumber();
    }
    catch
    {
        Console.WriteLine("Not a number.");
        continue;
    }


    double result = 0;
    bool valid = true;

    switch (op)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;
        case "-":
            result = firstNumber - secondNumber;
            break;
        case "*":
            result = firstNumber * secondNumber;
            break;
        case "/":
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Divide by zero.");
                valid = false;
            }
            else
            {
                result = firstNumber / secondNumber;
            }
            break;
        default:
            Console.WriteLine("Invalid operator.");
            valid = false;
            break;
    }

    if (valid)
    {
        Console.WriteLine($"Result: {result}");
    }

    Console.WriteLine("Write q to exit.");
    Console.WriteLine("Or press any key to continue");

    char quit = Console.ReadKey().KeyChar;
    if (quit == 'q' || quit == 'Q')
    {
        Console.WriteLine();
        break;
    }

    Console.WriteLine();
}

Console.WriteLine("Program ended. Click any key to close.");
Console.ReadKey();