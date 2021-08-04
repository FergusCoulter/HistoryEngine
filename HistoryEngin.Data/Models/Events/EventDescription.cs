using HistoryEngine.Data.Models.Civilisations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Events
{
    class EventDescription
    {
        public Entity[] entitiesInvolved { get; set; }
        public string descriptionOfEvent { get; set; }

    }
}
