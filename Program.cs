using Microsoft.Win32;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_12_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EventHub
            //            EventHub is a platform that allows individuals and companies to organize,
            //promote, and manage public and private events.
            //When a person or a company decides to host events through the platform, they
            //first register as an organizer by providing their name and, if applicable, the name
            //of the company they represent.
            //The platform assigns each organizer a verified status after completing an
            //internal review process.Alongside their account, every organizer maintains a
            //public-facing profile page where they can write a short biography, link to their
            //personal or company website, and upload a logo.
            //This profile page is directly tied to the organizer’s account and cannot exist
            //without it.

            //Once their account is set up, an organizer can publish events on the platform.
            //Every event carries a title, a detailed description, a start date, an optional end
            //date, and a maximum number of attendees allowed.

            //Large-scale events such as annual conferences may also contain smaller, more
            //focused sessions within them.For example, a technology conference might host
            //several breakout workshops on the same day, with each workshop treated as a
            //distinct event that is nested under the main conference event.

            //1

            //Sessions can only belong to one parent event, and a parent event can have any
            //number of sessions.

            //People who wish to attend can register for any event as attendees. Each
            //attendee provides their full name, an email address, and a home address that
            //includes a street, city, country, and postal code, used for correspondence
            //purposes. Once an attendee has registered for at least one event, the platform
            //issues them a badge — a credential uniquely numbered per attendee, stamped
            //with the date it was issued, and assigned a tier based on their registration
            //history: either Standard or VIP.
            //A badge belongs to one attendee, and each attendee can have at most one
            //badge.
            //An attendee can register for multiple events, and any given event will naturally
            //have many attendees signed up for it.
            //When registering, an attendee may optionally leave a short note to the
            //organizer, and the platform automatically records the exact date and time the
            //registration was completed.

            //Finally, the system silently tracks when each event record was first created in the
            //database and when it was last modified — these timestamps are maintained by
            //the platform internally and are never displayed on the public event page, nor
            //are they part of the event’s data model as visible fields.

            //2

            //Task:
            //Implement a full EF Core console app applying every configuration
            //technique covered in this session with all entity classes, a
            //DbContext, and OnModelCreating fully configured.
            //Each entity must be configured using the technique assigned in
            //the session(Data Annotations, Fluent API, or a separate
            //configuration class) — do not mix techniques on the same entity.

            #endregion
        }
    }
}
