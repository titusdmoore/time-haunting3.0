using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models.helper {
    public class Game {
        public bool Active { get; set; }
        public Player CurrentPlayer { get; set; }
        public Mob? CurrentMob { get; set; }
        public Item[] Items { get; set; }
        public Mob[] Mobs { get; set; }

        public Game () { }
        public Game (Player p, Item[] _iS, Mob[] m) {
            this.CurrentPlayer = p;
            this.Items = _iS;
            this.Active = true;
            this.Mobs = m;
        }

        public void EndGame() {
            this.Active = false;
        }
    }
}
