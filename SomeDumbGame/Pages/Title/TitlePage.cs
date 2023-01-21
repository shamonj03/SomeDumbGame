using SomeDumbGame.Pages.CharacterSelect;
using SomeDumbGame.Pages.Interfaces;
using Spectre.Console;

namespace SomeDumbGame.Pages.Title
{
    public class TitlePage : IPage
    {
        public IPage Render()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Some")
                    .LeftJustified()
                    .Color(Color.Red));

            AnsiConsole.Write(
               new Padder(new FigletText("Dumb")
                    .LeftJustified()
                    .Color(Color.Green)).PadLeft(16));

            AnsiConsole.Write(
                new Padder(new FigletText("Game")
                    .LeftJustified()
                    .Color(Color.Blue)).PadLeft(32));

            AnsiConsole.Write(new Rule("[red]Press any key to continue[/]").LeftJustified());
            AnsiConsole.Console.Input.ReadKey(true);

            return new CharacterSelectPage();
        }
    }
}
