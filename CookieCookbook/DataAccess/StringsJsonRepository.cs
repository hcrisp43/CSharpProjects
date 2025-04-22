
using System.Text.Json;

namespace CookieCookbook.DataAccess;

public class StringsJsonRepository : StringsRepository
{
    public override List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }

    protected override string StringsToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }
}
