using GameDataParser.App;
using GameDataParser.UserInteraction;
using GameDataParser.Logging;
using GameDataParser.DataAccess;

var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(userInteractor, 
    new GamesPrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFileReader());

var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("The application has experienced and unexpected error.");
    logger.Log(ex);
}


Console.ReadKey();