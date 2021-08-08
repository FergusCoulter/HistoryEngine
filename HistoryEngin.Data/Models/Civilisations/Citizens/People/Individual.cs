using HistoryEngin.Data.States.People_States;
using HistoryEngine.Data.Models.Civilisations.Citizens.Jobs;
using HistoryEngine.Data.States.People_States;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Citizens.People

{
    public class Individual:Entity<Individual>
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public DateTime dob { get; set; }
        public Health healthStatus { get; set; }
        public Gender gender { get; set; }
        public IndividualRelationship[] relationships { get; set; }
        public Function function { get; set; }
        public int[] location { get; set; }
        //could be dictionary
        public Knowledge.IndividualKnowledge.Knowledge[] knowledge { get; set; }


        public int[] emotions { get; set; }
        public byte[] memory { get; set; }
        


    }
}
