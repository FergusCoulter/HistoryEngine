using HistoryEngine.Data.Models.Civilisations.Settlement;
using HistoryEngine.Data.Models.World.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Civ
{
    class Civilisation:Entity<Civilisation>
    {
        //Name Civ Gives itself
        public string selfName { get; set; }
        //Date first city was founded
        public DateTime dateBegan { get; set; }
        public SettlementBase[] settlements { get; set; }
        //Log of all notable Civ level Events
        public byte[] eventLog { get; set; }
        public List<CivRelations> knownCivilisations { get; set; }
        public Tile[,] territory { get; set; }
        public List<Knowledge.CivKnowledge.CivilisationKnowledge> knownTechnology { get; set; }
        public List<Enum> states { get; set; }

        #region Stats

        public int population { get; set; }
        public int belligerence { get; set; }
        public int happiness { get; set; }
        public double knowledge { get; set; }
        public int hunger { get; set; }
        public int wealth { get; set; }

        #endregion

        public Civilisation()
        {
            selfName = "test";
            dateBegan = DateTime.Now;
            settlements = new SettlementBase[] {new SettlementBase()};
            eventLog = new byte[0];
            knownCivilisations = new List<CivRelations>();
            knownTechnology = new List<Knowledge.CivKnowledge.CivilisationKnowledge>();
            states = new List<Enum>();
        }
    }
}
