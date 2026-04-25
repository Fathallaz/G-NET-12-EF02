using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02
{
    internal class Event
    {
        public int EventId { get; set; }
        public int OrganizerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
