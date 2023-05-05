List<string> record = new List<string>();

void startGame()
{
    Console.WriteLine();
    Console.WriteLine("----- Math Game -----");
    Console.WriteLine("Write 'help' to see all commands");
    Console.Write("First number: ");
    string firstNumber = Console.ReadLine()!;
    checkInput(firstNumber);

    Console.Write("Second number: ");
    string secondNumber = Console.ReadLine()!;
    checkInput(secondNumber);

    Console.Write("Arithmetic operation (+,-,*,/): ");
    string operation = Console.ReadLine()!;

    switch (operation)
    {
        case ("+"):
            Console.WriteLine("The sum is " + (int.Parse(firstNumber) + int.Parse(secondNumber)));
            record.Add($"The sum of {int.Parse(firstNumber)} and {int.Parse(secondNumber)} is " + (int.Parse(firstNumber) + int.Parse(secondNumber)) + ".");
            break;
        case ("-"):
            Console.WriteLine("The difference is " + (int.Parse(firstNumber) - int.Parse(secondNumber)));
            record.Add($"The difference of {int.Parse(firstNumber)} and {int.Parse(secondNumber)} is " + (int.Parse(firstNumber) - int.Parse(secondNumber)) + ".");
            break;
        case ("*"):
            Console.WriteLine("The product is " + (int.Parse(firstNumber) * int.Parse(secondNumber)));
            record.Add($"The product of {int.Parse(firstNumber)} and {int.Parse(secondNumber)} is " + (int.Parse(firstNumber) * int.Parse(secondNumber)) + ".");
            break;
        case ("/"):
            Console.WriteLine("The quotient is " + (int.Parse(firstNumber) / int.Parse(secondNumber)));
            record.Add($"The quotient of {int.Parse(firstNumber)} and {int.Parse(secondNumber)} is " + (int.Parse(firstNumber) / int.Parse(secondNumber)) + ".");
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
    startGame();
}

void checkInput(string input)
{
    if (input == "help")
    {
        getHelp();
    }
    else if (input == "history")
    {
        foreach (string game in record)
        {
            Console.WriteLine(game);
        }
    }
    else if (int.TryParse(input, out int n) == false)
    {
        wrongInput();
    }
}

void wrongInput()
{
    Console.WriteLine("Your input is not a number!");
    Console.WriteLine("The app has been restarted.");
    startGame();
}

startGame();

void getHelp()
{
    Console.WriteLine("---- Help ----");
    Console.WriteLine("A number is expected in 'First number'");
    Console.WriteLine("A number is expected in 'Second number'");
    Console.WriteLine("A arithmetic operator (+,-,*,/) is expected in 'Arithmetic operation'");
    Console.WriteLine("Write 'help' to see this output.");
    Console.WriteLine("write 'history' to see your previous calculations.");
    startGame();
}
