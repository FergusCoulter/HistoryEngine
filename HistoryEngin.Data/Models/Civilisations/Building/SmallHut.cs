using HistoryEngin.Data.States.Building_States;
using HistoryEngine.Data.Models.Civilisations.Building;
using HistoryEngine.Data.Models.Civilisations.Citizens.People;
using HistoryEngine.Data.States.Building_States;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Building
{
    class SmallHut:BaseBuilding
    {
        public int maxOccupants { get; set; }
        public Individual[] occupants { get; set; }
        public Condition condition { get; set; }
        public Function function { get; set; }
        public GeneralState state { get; set; }

        public SmallHut()
        {
            maxOccupants = 4;
            function = Function.Housing;
        }
        

    }
}
