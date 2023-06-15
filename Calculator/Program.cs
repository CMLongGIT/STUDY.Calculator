//Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

//Displaying a title to let the user know it's a C# calculator app.
Console.WriteLine("C# Console Calculator\r");
Console.WriteLine("-----------------------\n");

//Ask user to type the first number.
Console.WriteLine("Type a number, and then press Enter.");
num1 = Convert.ToInt32(Console.ReadLine());

//Ask user to type second number.
Console.WriteLine("Type another number, and then press Enter.");
num2 = Convert.ToInt32(Console.ReadLine());

//Ask user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option? ");

//Using a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

//Wait for the user to respond before closing.
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadKey();