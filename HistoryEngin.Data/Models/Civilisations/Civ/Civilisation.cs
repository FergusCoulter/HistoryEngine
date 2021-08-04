using HistoryEngine.Data.Models.Civilisations.Settlement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Civ
{
    class Civilisation:Entity<Civilisation>
    {
        public string selfName { get; set; }
        public DateTime dateBegan { get; set; }
        public SettlementBase[] settlements { get; set; }
        public byte[] log { get; set; }


    }
}
