Console.WriteLine("=== Calculator App ===");

Console.WriteLine("Enter first number:");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose the operator: +, -, *, /");
string op = Console.ReadLine();

Console.WriteLine("Enter second number:");
double secondNumber = Convert.ToDouble(Console.ReadLine());


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
        if(secondNumber == 0)
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

Console.WriteLine("Program ended. Click any key to close.");
Console.ReadKey();