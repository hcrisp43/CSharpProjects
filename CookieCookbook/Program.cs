using System.Runtime.CompilerServices;
using System.Text.Json;
using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();
var cookieRecipeApp = new CookieRecipesApp(
    new RecipesRepository(stringsRepository, ingredientsRegister), 
    new RecipesConsoleUserInteraction(ingredientsRegister));

cookieRecipeApp.Run(fileMetadata.ToPath());

