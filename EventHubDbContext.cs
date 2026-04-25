using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace G_NET_12_EF02
{
    internal class EventHubDbContext :DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDb;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(e => e.Description)
                      .IsRequired();

                entity.Property(e => e.StartDate)
                      .IsRequired();

                entity.Property(e => e.MaxAttendees)
                      .IsRequired();

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.UpdatedAt)
                      .HasDefaultValueSql("GETDATE()");
            });
            modelBuilder.Entity<Badge>(entity =>
            {
                entity.HasKey(b => b.BadgeId);

                entity.Property(b => b.BadgeNumber)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(b => b.IssuedDate)
                      .IsRequired();

                entity.Property(b => b.Tier)
                      .IsRequired()
                      .HasMaxLength(20);
            });
        }

         public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }


    }
}
