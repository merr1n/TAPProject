using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class MyDbContext : DbContext
    {
        private readonly string _windowsConnectionString = @"Data Source=DESKTOP-T077D85;Database=TAPproject;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<TestModel> TestModels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(
                new User(new Guid("a529d774-4e8b-4fb7-9d5a-93154fded76e"), "Darius", "darius@gmail.com", "darius", "admin"),
                new User(new Guid("7a628ec2-502f-4ae0-84f2-01e0e7e8bf0d"), "Monica", "monica@gmail.com", "monica123", "organizer"),
                new User(new Guid("c7f9b7b3-956c-4a07-8a7c-45645eb5f2cc"), "Marius", "marius@gmail.com", "marius", "user"),
                new User(new Guid("e7ef7bd2-1c11-48e7-80a0-aa06c5e9b543"), "Edi", "maxifny@gmail.com", "geometryfear", "organizer"),
                new User(new Guid("82e24d8e-0e34-4953-b32f-fb2ac76f92ff"), "Nico", "popeye@gmail.com", "samp", "user")
                );
            
            builder.Entity<UserType>().HasData(
                new UserType(1,"user"),
                new UserType(2,"organizer"),
                new UserType(3,"admin")
                );
        }
    }
}
