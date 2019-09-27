using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models {
    public class Player {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Armor { get; set; } = 0;
        public List<Item> Inventory { get; set; }
        public Item MainItem { get; set; }

        public Player () { }
        public Player (string name, List<Item> _iS, Item m) {
            this.Name = name;
            this.Inventory = _iS;
            this.MainItem = m;
        } 
    }
}
