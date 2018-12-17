using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectV1
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Club { get; set; }
    }
}
