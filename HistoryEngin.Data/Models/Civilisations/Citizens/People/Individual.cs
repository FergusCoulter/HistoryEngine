using HistoryEngin.Data.States.People_States;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Citizens.People

{
    class Individual
    {
        public string name { get; set; }
        public int age { get; set; }
        public DateTime dob { get; set; }
        public Health healthStatus { get; set; }
        public Gender gender { get; set; }

    }
}
