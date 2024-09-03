using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<EventCategory> EventCategories { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Organizer> Organizers { get; set; }
        public virtual DbSet<QandA> QandAs { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TicketCategory> TicketCategories { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventCategory>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.EventCategory)
                .HasForeignKey(e => e.Id_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Event)
                .HasForeignKey(e => e.Id_Events)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Event)
                .HasForeignKey(e => e.Id_Events)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Event)
                .HasForeignKey(e => e.Id_Events)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Organizer)
                .HasForeignKey(e => e.Id_Organizer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QandA>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<QandA>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<QandA>()
                .Property(e => e.Keywords)
                .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Id_Roles);

            modelBuilder.Entity<TicketCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TicketCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TicketCategory>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.TicketCategory)
                .HasForeignKey(e => e.Id_Category);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Id_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Id_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Id_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.Venue)
                .HasForeignKey(e => e.Id_Venue);
        }
    }
}
