using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models {
    public class Item {
        public string Name { get; set; }
        public int Space { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }

        public Item() { }
        public Item(string n, int s, int p, string t) {
            this.Name = n;
            this.Space = s;
            this.Power = p;
            this.Type = t;
        }
    }
}
