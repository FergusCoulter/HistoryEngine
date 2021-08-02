using HistoryEngine.Data.Models.Civilisations.Building;
using HistoryEngine.Data.Models.Civilisations.Citizens.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngin.Data.Models.Civilisations.Building
{
    class Hut:BaseBuilding
    {
        public int maxOccupants { get; set; }
        public Individual[] occupants { get; set; }


    }
}
