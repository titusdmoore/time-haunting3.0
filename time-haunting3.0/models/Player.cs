using System;
using System.Collections.Generic;
using System.Text;

namespace time_haunting3._0.models {
    class Player {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Armor { get; set; } = 0;
        public Item[] Inventory { get; set; }
        public Item MainItem { get; set; }


    }
}
