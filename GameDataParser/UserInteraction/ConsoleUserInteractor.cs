namespace GameDataParser.UserInteraction;
public class ConsoleUserInteractor : IUserInteractor
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }

    public string ReadValidFilePath()
    {
        bool isFilePathValid = false;
        var fileName = default(string);

        do
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The file name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file does not exist.");
            }
            else
            {
                isFilePathValid = true;
            }

            /*These exceptions can be caught with if statements, they are unnecessary
             * try
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                fileName = Console.ReadLine();

                fileContents = File.ReadAllText(fileName);
                isFileRead = true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("The file name cannot be null.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file does not exist.");
            }*/
        }
        while (!isFilePathValid);
        return fileName;
    }
}

