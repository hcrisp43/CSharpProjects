int firstInput, secondInput;
string userChoice;

Console.WriteLine("Please enter the first number: ");
firstInput = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number; ");
secondInput = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?\n [A]dd\n [S]ubtract\n [M]ultiply");
userChoice = Console.ReadLine();

if (choiceCompare(userChoice, "A"))
{
    Console.WriteLine($"{firstInput} + {secondInput} = {firstInput + secondInput}");
}
else if (choiceCompare(userChoice, "S"))
{
    Console.WriteLine($"{firstInput} - {secondInput} = {firstInput - secondInput}");
}
else if (choiceCompare(userChoice, "M"))
{
    Console.WriteLine($"{firstInput} * {secondInput} = {firstInput * secondInput}");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

 bool choiceCompare(string a, string b)
{
    return a.ToUpper() == b.ToUpper();
}