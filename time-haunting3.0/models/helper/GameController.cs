using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace time_haunting3._0.models.helper {
    public static class GameController {
        public static Player CreatePlayer() {
            Display.PlayerCreator();
            Console.WriteLine("Choose a Name!");
            var n = GameConsole.InlineRead(">");
            List<Item> f = new List<Item>();
            return new Player(n, f, new Item("Fist", 0, 100, "Weapon"));
        }

        public static void Help() {
            Console.Clear();
            Display.Home();
            Console.WriteLine($"Fight [F] => Fight with your Main item if its a weapon, or with your fist " +
                $"{Environment.NewLine}Run [R] => Run away like a baby (or like a man...but men don't run)" +
                $"{Environment.NewLine}Trade [T] => Trades with the current mob (or gets you killed, dragons don't trade dunce)" +
                $"{Environment.NewLine}Set Main Item [S] => Sets your main item" +
                $"{Environment.NewLine}View Inventory [V] => Look at what you have managed to collect " +
                $"{Environment.NewLine}Use Item [U]: Use whatever is in your hand...be careful if it's a weapon though... " +
                $"{Environment.NewLine}Help [H]: Do you really need a decription of this?");
            Console.ReadKey();
        }

        public static Game Fight(Game g) {
            Console.Clear();
            Display.Home();
            Random random = new Random();
            var weapon = g.CurrentPlayer.MainItem;
            while (g.CurrentPlayer.Health > 0 && g.CurrentMob.Health > 0) {
                double powerMult = random.NextDouble();
                var attck = powerMult * weapon.Power;
                g.CurrentMob.Health -= (int)attck;
                Console.WriteLine($"You attacked {g.CurrentMob.Name} with {weapon.Name} for {attck} damage. {g.CurrentMob.Name} has {g.CurrentMob.Health} health left");
                Console.Write("Enter to continue");
                Console.ReadLine();
                double mobMult = random.NextDouble();
                var mobAttk = mobMult * g.CurrentMob.Power;
                g.CurrentPlayer.Health -= (int)mobAttk;
                Console.WriteLine($"{g.CurrentMob.Name} attacked you for {mobAttk} damage. You have {g.CurrentPlayer.Health} health left.");
                Console.Write("Enter to continue");
                Console.ReadLine();
            }
            if (g.CurrentPlayer.Health <= 0) {
                Display.Dead();
                g.Active = false;
            }
            return g;
        }

        public static Game NewGame(Player p) {
            Item[] items = {
                new Item("Sword", 5, 15, "Weapon"),
                new Item("Healing Spell", 2, 10, "Heal Spell"),
                new Item("Poison Spell", 4, 10, "Attack Spell"),
                new Item("Hammer", 8, 10, "Weapon"),
                new Item("Braclet", 1, 0, "Tradable")
            };
            Mob[] mobs = {
                new Mob("Dragon", false, "Monster", 35, 125),
                new Mob("Villager", true, "Trader", 10, 80),
                new Mob("Ogre", true, "Monster", 20, 110),
            };
            return new Game(p, items, mobs);
        }

        public static void Controls(Game g) {
            var contr = true;
            while (contr) {
                Console.ReadLine();
                Console.Clear();
                Display.Home();
                Console.WriteLine("What will you do?");
                Console.WriteLine(@"[F]ight     [R]un      [T]rade      [S]et Main Item     [V]iew Inventory        [U]se Item       [H]elp");
                var resp = GameConsole.InlineReadControl(">");
                switch (resp) {
                    case "f":
                        GameController.Fight(g);
                        contr = false;
                        break;
                    case "r":
                        Console.WriteLine("Ran");
                        contr = false;
                        break;
                    case "t":
                        Console.WriteLine("Traded");
                        contr = false;
                        break;
                    case "s":
                        Console.WriteLine("Set");
                        contr = false;
                        break;
                    case "v":
                        Console.WriteLine("Viewed");
                        contr = false;
                        break;
                    case "u":
                        Console.WriteLine("Used");
                        contr = false;
                        break;
                    case "h":
                        GameController.Help();
                        contr = true;
                        break;
                    default:
                        contr = true;
                        break;
                }
            }
        }
    }
}
