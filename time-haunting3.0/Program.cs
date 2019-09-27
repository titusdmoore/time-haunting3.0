using System;
using System.Linq;
using time_haunting3._0.models;
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
                    "g" => true,
                    _ => true,
                };
                if (_in == "g") {
                    Display.EasterEgg();
                    Console.ReadLine();
                }
                Console.Clear();
            } while (menu);

            Game instanceGame = null;
            Player instancePlayer = null;
            switch (_in) {
                case "p":
                    instancePlayer = GameController.CreatePlayer();
                    instanceGame = GameController.NewGame(instancePlayer);
                    break;

                default:
                    break;
            }

            while (instanceGame.Active) {
                Display.Home();
                var instanceMonster = instanceGame.Mobs.Where(m => m.Name == "Ogre").FirstOrDefault();
                instanceGame.CurrentMob = instanceMonster;
                Console.WriteLine($"Hello, {instanceGame.CurrentPlayer.Name}. You walk into a dark room and meet a monster called {instanceMonster.Name}.");
                GameController.Controls(instanceGame);
                               
                instanceGame.Active = false;
            }

        }
    }
}
