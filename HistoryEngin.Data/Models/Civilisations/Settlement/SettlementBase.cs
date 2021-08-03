using HistoryEngine.Data.Models.Civilisations.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngin.Data.Models.Civilisations.Settlement
{
    class SettlementBase
    {
        public BaseBuilding[] buildings { get; set; }
        public int population { get; set; }

    }
}
