int firstInput, secondInput;
string userChoice;

Console.WriteLine("Please enter the first number: ");
firstInput = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number; ");
secondInput = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?\n [A]dd\n [S]ubtract\n [M]ultiply");
userChoice = Console.ReadLine();

calculate(userChoice);

Console.WriteLine("Press any key to close");
Console.ReadKey();

void calculate(string choice)
{
    if(choice == "a" || choice == "A")
    {
        Console.WriteLine(firstInput + " " + secondInput + " = " + (firstInput + secondInput));
    }
    else if(choice == "s" || choice == "S")
    {
        Console.WriteLine(firstInput + " - " + secondInput + " = " + (firstInput - secondInput));
    }
    else if(choice == "m" || choice == "M")
    {
        Console.WriteLine(firstInput + " * " + secondInput + " = " + (firstInput * secondInput));
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}