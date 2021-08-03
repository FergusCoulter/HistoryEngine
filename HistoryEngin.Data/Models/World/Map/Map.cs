using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.World.Map
{
    class Map
    {
        public Tile[,] tileMap { get; set; }


        public Map()
        {
            tileMap = new Tile[700, 300];
        }
        public Map(int xCoords, int yCoords)
        {
            tileMap = new Tile[xCoords, yCoords];
        }
    }
}
