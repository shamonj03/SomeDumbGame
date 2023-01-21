using SomeDumbGame.Game.Models;
using SomeDumbGame.Pages.Interfaces;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeDumbGame.Pages.World
{
    public class WorldPage : IPage
    {
        private readonly string[][] _map = {
            new [] { "x", "x", "x", "x", "x", "x", "x", "x", "x", "x" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "z" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "z" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "z" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "z" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "x" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "x" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "x" },
            new [] { "x", " ", " ", " ", " ", " ", " ", " ", " ", "x" },
            new [] { "x", "x", "x", "[red]x[/]", "x", "x", "x", "x", "x", "x" }
        };

        private readonly Player _player;

        public WorldPage(Player player)
        {
            _player = player;
        }

        public IPage Render()
        {
            AnsiConsole.Clear();

            for (int y = 0; y < _map.Length; y++)
            {
                var row = _map[y];
                AnsiConsole.Write(new Columns(row).Collapse());
            }

            AnsiConsole.Console.Input.ReadKey(true);
            return this;
        }
    }
}
