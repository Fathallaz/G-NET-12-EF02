using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02
{
    internal class Session
    {
        public int SessionId { get; set; }
        public int ParentEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
    }
}
