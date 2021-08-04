using HistoryEngine.Data.States.People_States;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Civilisations.Citizens.People
{
    class IndividualRelationship
    {
        public Guid RelationshipIndividualId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public Relationship type { get; set; }
    }
}
