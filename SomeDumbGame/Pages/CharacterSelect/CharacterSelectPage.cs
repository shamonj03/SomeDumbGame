using SomeDumbGame.Pages.Interfaces;
using SomeDumbGame.Pages.LoadCharacter;
using SomeDumbGame.Pages.NewCharacter;
using Spectre.Console;

namespace SomeDumbGame.Pages.CharacterSelect
{
    public class CharacterSelectPage : IPage
    {
        private const string LoadCharacter = "Load Character";
        private const string NewCharacter = "New Character";
        private const string Exit = "Exit";

        public IPage Render()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Choose an option")
                    .LeftJustified()
                    .Color(Color.Red));

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .PageSize(10)
                    .AddChoices(new[] { NewCharacter, LoadCharacter, Exit })
            );

            if (selection == LoadCharacter)
            {
                return new LoadCharacterPage();
            }
            if(selection == NewCharacter)
            {
                return new NewCharacterPage();
            }
            return new ExitPage();
        }
    }
}
