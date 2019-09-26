using System;
using time_haunting3._0.models.helper;

namespace time_haunting3._0 {
    class Program {
        static void Main(string[] args) {
            var menu = false;
            var _in = "";
            do {
                Display.Home();
                Console.WriteLine("Welcome to Time Haunting!");
                Console.WriteLine(@"[P]lay      [C]redits       [E]xit");
                var play = GameConsole.InlineReadControl(">");
                _in = play;
                menu = play switch
                {
                    "p" => false,
                    "c" => false,
                    "e" => false,
                    _ => true,
                };
                Console.Clear();
            } while (menu);




        }
    }
}
