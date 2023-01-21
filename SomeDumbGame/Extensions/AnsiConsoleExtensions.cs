using Spectre.Console;

namespace SomeDumbGame.Extensions
{
    public static class AnsiConsoleExtensions
    {
        private const string ClosingTag = "[/]";

        public static void WriteDialogue(this IAnsiConsole console, string message, int speed = 25)
        {
            var skip = false;
            var markup = string.Empty;

            for (var position = 0; position < message.Length; position++)
            {
                if (console.Input.IsKeyAvailable())
                {
                    console.Input.ReadKey(true);
                    skip = true;
                }

                var currentCharacter = message[position];

                // Look ahead to determin if there's markup.
                // If there is cut out the markup and advance the position in the message.
                if (currentCharacter == '[')
                {
                    var endIndex = message.Substring(position).IndexOf(']') + 1;
                    markup = message.Substring(position, endIndex);

                    position += endIndex;
                    currentCharacter = message[position];

                    // Discard markup if we hit a closing tag.
                    if (markup == ClosingTag)
                        markup = string.Empty;
                }

                if(string.IsNullOrEmpty(markup))
                    console.Write($"{currentCharacter}");
                else
                    console.Write(new Markup($"{markup}{currentCharacter}{ClosingTag}"));

                if (!skip)
                    Thread.Sleep(speed);
                else if (position % 10 == 0)
                    Thread.Sleep(10);
            }
            console.WriteLine();
        }

        public static void ClearKeys(this IAnsiConsole console)
        {
            while (console.Input.IsKeyAvailable())
            {
                console.Input.ReadKey(false);
            }
        }

        public static async Task ClearKeys(this IAnsiConsole console, CancellationToken cancellationToken)
        {
            while (console.Input.IsKeyAvailable())
            {
                await console.Input.ReadKeyAsync(false, cancellationToken);
            }
        }
    }
}
