using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double UnitPrice { get; set; }
    }
}
