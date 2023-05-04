List<String> record;

void startGame()
{

    Console.WriteLine("----- Math Game -----");
    Console.WriteLine("Write 'help' to see all commands");
    Console.Write("First number: ");
    var firstNumber = Console.ReadLine()!;
    if (firstNumber == "help")
    {
        getHelp();
    }

    Console.Write("Second number: ");
    var secondNumber = Console.ReadLine()!;
    if (secondNumber == "help")
    {
        getHelp();
    }

    Console.Write("Arithmetic operation (+,-,*,/): ");
    string operation = Console.ReadLine()!;
    if (operation == "help")
    {
        getHelp();
    }

    switch (operation)
    {
        case ("+"):
            Console.WriteLine("The sum is " + (int.Parse(firstNumber) + int.Parse(secondNumber)));
            record.Add("The sum is " + (int.Parse(firstNumber) + int.Parse(secondNumber)));
            break;
        case ("-"):
            Console.WriteLine("The difference is " + (int.Parse(firstNumber) - int.Parse(secondNumber)));
            record.Add("The sum is " + (int.Parse(firstNumber) - int.Parse(secondNumber)));
            break;
        case ("*"):
            Console.WriteLine("The product is " + (int.Parse(firstNumber) * int.Parse(secondNumber)));
            record.Add("The sum is " + (int.Parse(firstNumber) * int.Parse(secondNumber)));
            break;
        case ("/"):
            Console.WriteLine("The quotient is " + (int.Parse(firstNumber) / int.Parse(secondNumber)));
            record.Add("The sum is " + (int.Parse(firstNumber) / int.Parse(secondNumber)));
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

//startGame();

void getHelp()
{
    Console.WriteLine("---- Help ----");
    Console.WriteLine("A number is expected in 'First number'");
    Console.WriteLine("A number is expected in 'Second number'");
    Console.WriteLine("A arithmetic operator (+,-,*,/) is expected in 'Arithmetic operation'");
    Console.WriteLine();
    startGame();
}
