using SomeDumbGame.Pages.CharacterSelect;
using SomeDumbGame.Pages.Interfaces;
using Spectre.Console;

namespace SomeDumbGame.Pages.LoadCharacter
{
    public class LoadCharacterPage : IPage
    {
        public IPage Render()
        {
            AnsiConsole.Clear();
            AnsiConsole.WriteLine("This is a fucking rogue like. There is no load character.");
            AnsiConsole.WriteLine("(We haven't figured out how to save characters actually)");
            AnsiConsole.WriteLine("Press any key to continue...");
            AnsiConsole.Console.Input.ReadKey(true);

            return new CharacterSelectPage();
        }
    }
}
