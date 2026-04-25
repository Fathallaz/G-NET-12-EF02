using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02
{
    internal class Registration
    {
        public int RegistrationId { get; set; }
        public int AttendeeId { get; set; }
        public int EventId { get; set; }
        public string? NoteToOrganizer { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
