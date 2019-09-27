using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models {
    public class Mob {
        public string Name { get; set; }
        public bool Tradable { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public Item[] Inventory { get; set; }
        public Item ActiveItem { get; set; }

        public Mob() {}

        public Mob(string n, bool t, string ty, int p, int h) {
            this.Name = n;
            this.Tradable = t;
            this.Type = ty;
            this.Power = p;
            this.Health = h;
        }
    }
}
