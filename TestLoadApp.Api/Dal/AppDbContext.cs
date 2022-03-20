#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TestLoadApp.Api.Models;

namespace TestLoadApp.Api.Dal
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("LoadTestDb"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>().Property(x => x.Items).HasConversion(
            v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            v => JsonConvert.DeserializeObject<IList<OrderItem>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Entity<Order>().HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);

            SeedData.SeedUsers(builder);
        }
    }

    public static class SeedData
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            var users = new List<IdentityUser>
            {
                new IdentityUser()
                {
                    Id = "ea20d4bd-431e-4ccf-b61d-b20db06cf362",
                    UserName = "BillieRigby",
                    Email = "BillieRigby@gmail.com",
                    PhoneNumber = "1234567890"
                },
                new IdentityUser()
                {
                    Id = "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95",
                    UserName = "FerneChung",
                    Email = "FerneChung@gmail.com",
                    PhoneNumber = "1234567891"
                },
                new IdentityUser()
                {
                    Id = "fc007b46-551a-44e5-b26f-ed5070a184ba",
                    UserName = "YolandaPaine",
                    Email = "YolandaPaine@gmail.com",
                    PhoneNumber = "1234567892"
                },
                new IdentityUser()
                {
                    Id = "b4852bde-7e11-4950-b4e7-f612138df5bd",
                    UserName = "MaisyClements",
                    Email = "MaisyClements@gmail.com",
                    PhoneNumber = "1234567893"
                },
                new IdentityUser()
                {
                    Id = "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc",
                    UserName = "JacquelineHowarth",
                    Email = "JacquelineHowarth@gmail.com",
                    PhoneNumber = "1234567894"
                },
                new IdentityUser()
                {
                    Id = "4c4e8205-72ad-431e-921a-ed4599bfa427",
                    UserName = "AmeerahYoung",
                    Email = "AmeerahYoung@gmail.com",
                    PhoneNumber = "1234567895"
                },
                new IdentityUser()
                {
                    Id = "5fa2d163-79bd-4580-abf5-8b6536f239c3",
                    UserName = "LibertyDuffy",
                    Email = "LibertyDuffy@gmail.com",
                    PhoneNumber = "1234567896"
                },
                new IdentityUser()
                {
                    Id = "57266d27-1262-4be5-b765-f5674d41300a",
                    UserName = "ShereenRutledge",
                    Email = "ShereenRutledge@gmail.com",
                    PhoneNumber = "1234567897"
                },
                new IdentityUser()
                {
                    Id = "3e42c4a0-a872-47a4-abc9-b3cc69b923a9",
                    UserName = "AnnabelleRowe",
                    Email = "AnnabelleRowe@gmail.com",
                    PhoneNumber = "1234567898"
                },
                new IdentityUser()
                {
                    Id = "8598ab52-ed4c-4c48-8ea6-28f560cd66a8",
                    UserName = "RhiannanPittman",
                    Email = "RhiannanPittman@gmail.com",
                    PhoneNumber = "1234567899"
                },
            };


            foreach (var user in users)
            {
                PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
                user.PasswordHash = passwordHasher.HashPassword(user, "abc123");

                builder.Entity<IdentityUser>().HasData(user);
            }
        }
    }
}
