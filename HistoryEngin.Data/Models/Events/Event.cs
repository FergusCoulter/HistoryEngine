using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.Data.Models.Events
{
    class Event
    {
        public int importance { get; set; }
        public EventDescription description { get; set; }
        public EventType type { get; set; }
    }
}
