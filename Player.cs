using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectV1
{
    // Create Player
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Club { get; set; }

        public string Score { get; set; }

        public bool IsVisible { get; set; }

    }
}
