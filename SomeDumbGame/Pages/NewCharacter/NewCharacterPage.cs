using SomeDumbGame.Extensions;
using SomeDumbGame.Game.Models;
using SomeDumbGame.Pages.Interfaces;
using SomeDumbGame.Pages.World;
using Spectre.Console;

namespace SomeDumbGame.Pages.NewCharacter
{
    public class NewCharacterPage : IPage
    {
        public IPage Render()
        {
            AnsiConsole.Clear();
            AnsiConsole.Console.WriteDialogue($"....................");
            AnsiConsole.Console.WriteDialogue($"....................");
            AnsiConsole.Console.WriteDialogue($"....................");
            AnsiConsole.Console.WriteDialogue($"Hey,");
            AnsiConsole.Console.WriteDialogue($"You,");
            AnsiConsole.Console.WriteDialogue($"You're [green]finally[/] [red]awake[/]...");
            AnsiConsole.Console.Input.ReadKey(true);

            var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
            var @class = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("What's your [green]class[/]?")
                .AddChoices(new[] {
                    "Druid", "Elementalist", "Warrior"
                }));
            AnsiConsole.Write(new Markup($"What's your [green]class[/]? {@class}\n"));

            AnsiConsole.WriteLine();
            AnsiConsole.Console.WriteDialogue($"These don't matter; you'll be back at this screen soon enough.");
            AnsiConsole.Console.Input.ReadKey(true);

            return new WorldPage(new Player(name, @class));
        }
    }
}
