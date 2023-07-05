using Calculator;

Console.WriteLine("Hello dear friend!\n---");
Console.WriteLine("We present you a simple calculator. " +
    "You need to sequentially, at the request of the program,\nenter two numbers and one of the possible mathematical operations, namely +, -, *, /\n" +
    "If you want to exit press \"e\" enywhere...\n---\n");

string inputStr, inputMathOperator;
double a, b, result;
string[] mathOperators = { "+", "-", "*", "/" };

// first number
do
{
    Console.Write("Enter first number:  ");
    inputStr = Console.ReadLine()!;
    if (inputStr == "e")
        return;

    if (double.TryParse(inputStr, out a))
        break;
    
    Console.WriteLine("\tUnable to parse '{0}'.", inputStr);
} while (true);

// operations
do
{
    Console.Write("Enter math operator: ");
    inputStr = Console.ReadLine()!;
    if (inputStr == "e")
        return;

    if (mathOperators.Any(x => x.Equals(inputStr)))
    {
        inputMathOperator = inputStr;
        break;
    }
    Console.WriteLine("\tUnknown math operator '{0}'.", inputStr);
} while (true);


// second number
do
{
    Console.Write("Enter second number: ");
    inputStr = Console.ReadLine()!;
    if (inputStr == "e")
        return;

    if (double.TryParse(inputStr, out b))
        break;

    Console.WriteLine("\tUnable to parse '{0}'.", inputStr);
} while (true);

Console.WriteLine();

//Result
var context = new Context();
switch (inputMathOperator)
{
    case "+":
        context.SetStrategy(new Add());
        break;
    case "-":
        context.SetStrategy(new Sub());
        break;
    case "*":
        context.SetStrategy(new Mult());
        break;
    case "/":
        context.SetStrategy(new Div());
        break;
}
try
{
    result = context.DoMathOperation(a, b);
    Console.WriteLine("Result: {0}", result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();