using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models.helper {
    public static class GameConsole {
        public static string InlineRead(string s = null) {
            if (s != null) {
                Console.Write($"{s} ");
            }

            return Console.ReadLine();
        }

        public static string InlineReadControl(string s  = null) {
            if (s != null) {
                Console.Write($"{s} ");
            }
            var _char = Console.ReadKey().KeyChar;
            return _char.ToString().ToLower();
        }
    }
}
