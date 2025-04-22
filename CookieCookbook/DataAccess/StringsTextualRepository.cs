namespace CookieCookbook.DataAccess;

public class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    public override List<string> TextToStrings(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }

    protected override string StringsToText(List<string> strings)
    {
        return string.Join(Separator, strings);
    }
}
