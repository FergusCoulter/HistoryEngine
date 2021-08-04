using HistoryEngine.Data.Models.Civilisations.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Settlement
{
    class SettlementBase:Entity<SettlementBase>
    {
        public BaseBuilding[] buildings { get; set; }
        public int population { get; set; }
        public DateTime dateFounded { get; set; }

        public byte[] log { get; set; }

    }
}
