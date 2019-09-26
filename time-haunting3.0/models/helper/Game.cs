using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models.helper {
    class Game {
        public bool Active { get; set; }
        public Player CurrentPlayer { get; set; }
        public Item[] Items { get; set; } 
        //TODO Add Mobs

        public Game () { }
        public Game (Player p, Item[] _iS) {
            this.CurrentPlayer = p;
            this.Items = _iS;
            this.Active = true;
        }

        public void EndGame() {
            this.Active = false;
        }
    }
}
