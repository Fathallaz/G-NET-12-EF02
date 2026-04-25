using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public int AttendeeId { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; }
    }
}
