using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccessLayer
{
    public class MyDbContext : DbContext
    {
        private readonly string _windowsConnectionString = @"Data Source=DESKTOP-RPA5SSF;Database=TAPproject;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<TestModel> TestModels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(
                new User(new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), "Darius", "darius@gmail.com", "darius", 3),
                new User(new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"), "Monica", "monica@gmail.com", "monica123", 2),
                new User(new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"), "Marius", "marius@gmail.com", "marius", 1),
                new User(new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), "Edi", "maxifny@gmail.com", "geometryfear", 2),
                new User(new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"), "Nico", "popeye@gmail.com", "samp", 1)
                );
            
            builder.Entity<UserType>().HasData(
                new UserType(1,"user"),
                new UserType(2,"organizer"),
                new UserType(3,"admin")
                );

            builder.Entity<EventType>().HasData(
                new EventType(1, "Concert"),
                new EventType(2, "Spectacol Dans"),
                new EventType(3, "Stand-up Comedy"),
                new EventType(4, "Speech"),
                new EventType(5, "Other (Please Specify in the Event's title)")
                );

            builder.Entity<Event>().HasData(
                new Event(new Guid("b2f6eaa1-4c39-411a-8579-d237d33c35e3"), "Concert Ian&Azteca", "Tiki-Club", new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), new DateTime(2024, 6, 15, 14, 30, 0), "Concert Ian, Azteca, Rava, si multi altii!", 1, 60.00m, "Available"),
                new Event(new Guid("7b676b19-fdb8-4d76-95a5-d8df5efc2c4e"), "Spectacol Trandafir de la Moldova!", "Husi", new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), new DateTime(2024, 9, 23, 19, 45, 0), "Spectacol folcloric 'Trandafir de la Moldova'!", 2, 00.00m, "Available"),
                new Event(new Guid("f5a4f779-55f1-47bc-8b95-9ae2b1b69e6a"), "Micutzu - Stand up Comedy Show", "OneCaffe", new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), new DateTime(2024, 11, 5, 8, 0, 0), "Veniti ca sa va simtiti bine!", 3, 30.00m, "Closed"),
                new Event(new Guid("6dfeef92-d8cf-4e4e-85d6-67fc74e6eb92"), "NATO Congress Speech", "Switzerland", new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"), new DateTime(2024, 2, 28, 16, 15, 0), "Come listen to what Selaru has to say", 4, 500.00m, "Sold-out"),
                new Event(new Guid("5eab5c23-2198-4f79-8120-3ad2348f2ed7"), "Marathon (Special Event)", "Stefan cel Mare street", new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), new DateTime(2024, 12, 12, 10, 0, 0), "Come have some fun and become healthier while trying to win a prize!", 5, 00.00m, "Available")
            );



            builder.Entity<Event>(entity =>
            {
                entity.HasIndex(e => e.TypeId, "IX_Events_TypeId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Type).WithMany(p => p.Events)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_EventTypes");

                entity.HasOne(d => d.Organizer).WithMany(p => p.Events)
                .HasForeignKey(d => d.OrganizerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Events_Users");
            });

            builder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.Type).WithMany(p => p.Users)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserTypes");
            });
        }
    }
}
