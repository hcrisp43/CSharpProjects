using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;

namespace GameDataParser.App;

public class GameDataParserApp
{
    /*This breaks the Single Responsibility Principle, 
     *so create classes/interfaces so each handle a single responsibility
    public void Run()
    {
        string fileName = ReadValidFilePathFromUser();
        var fileContents = File.ReadAllText(fileName);
        var videoGames = DeserializeVideoGamesFrom(fileName, fileContents);
        PrintGames(videoGames);
    }*/

    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _reader;
    

    public GameDataParserApp(IUserInteractor userInteractor, IGamesPrinter gamesPrinter,
        IVideoGamesDeserializer videoGamesDeserializer, IFileReader reader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _reader = reader;
    }

    public void Run()
    {
        string fileName = _userInteractor.ReadValidFilePath();
        var fileContents = _reader.Read(fileName);
        var videoGames = _videoGamesDeserializer.DeserializeFrom(fileName, fileContents);
        _gamesPrinter.Print(videoGames);
    }
}
