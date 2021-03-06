// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestLoadApp.Api.Dal;

#nullable disable

namespace TestLoadApp.Api.Dal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220320183206_AddUsers")]
    partial class AddUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ea20d4bd-431e-4ccf-b61d-b20db06cf362",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d0c6668e-d674-493e-92e1-5fa6fc9cad6b",
                            Email = "BillieRigby@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEDzlErB0jM3Vf5YH1DAYaqeHnIit4Pucp6nkku5oCw4GJu3UYTtLAUZBiqOOiO/gMg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1e58fc22-9a69-4dbe-ab57-fba7901ef5ae",
                            TwoFactorEnabled = false,
                            UserName = "BillieRigby"
                        },
                        new
                        {
                            Id = "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7a804e90-1b1c-4227-a31c-80ce2e61b55a",
                            Email = "FerneChung@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAECxaUE59SzyJtqnnb9vnoGmN7aaBs6ZexTStxkKvG20JyjWzRyeh0KlQ2vcYCb8Rtg==",
                            PhoneNumber = "1234567891",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0fafc8b8-792e-4e2d-ad64-9ec9ddd6a3df",
                            TwoFactorEnabled = false,
                            UserName = "FerneChung"
                        },
                        new
                        {
                            Id = "fc007b46-551a-44e5-b26f-ed5070a184ba",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "085d98fb-376d-47c9-a86c-91dd2820c946",
                            Email = "YolandaPaine@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEEf4vKktwVeCNsCkPQy8za+oMXW6tpTN5vH2/zgHDHl98oD5d3WPOHx+Cmc3MiAJZA==",
                            PhoneNumber = "1234567892",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9109dbbf-e01a-406d-876c-69f459629721",
                            TwoFactorEnabled = false,
                            UserName = "YolandaPaine"
                        },
                        new
                        {
                            Id = "b4852bde-7e11-4950-b4e7-f612138df5bd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8120b60b-5b82-4349-8331-b4afaa56c414",
                            Email = "MaisyClements@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEKLM4ZLsbTtqEoWpqck1sEkttg3fUtb/edaA9XnRl4ALQPHt7dQkim1Ka+Njx30zRw==",
                            PhoneNumber = "1234567893",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "190a189e-f851-4000-ad38-d04633eea415",
                            TwoFactorEnabled = false,
                            UserName = "MaisyClements"
                        },
                        new
                        {
                            Id = "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "13f61e9d-c081-47b4-8830-21699d654c12",
                            Email = "JacquelineHowarth@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEBPvd3usAEWWcOpxAwrKYexOAuM2WiYdXYBK8AHpy8BIffYxAWD7JU0HaVxDM2okhQ==",
                            PhoneNumber = "1234567894",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f086c395-41bb-4b5d-b289-8ebffcd85bdd",
                            TwoFactorEnabled = false,
                            UserName = "JacquelineHowarth"
                        },
                        new
                        {
                            Id = "4c4e8205-72ad-431e-921a-ed4599bfa427",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c29a25b-a7f5-4a65-b71c-584f43852c85",
                            Email = "AmeerahYoung@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEAineP3sN8Wi6E9YiYYwrhZD8oOjYgK0gTFscNItEJCcngZHnVFneiduwN0xoUQGtA==",
                            PhoneNumber = "1234567895",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1a5da283-7c6f-458f-8705-7ad4e3b713de",
                            TwoFactorEnabled = false,
                            UserName = "AmeerahYoung"
                        },
                        new
                        {
                            Id = "5fa2d163-79bd-4580-abf5-8b6536f239c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cafcbd60-813d-40d2-9dcb-e8bada5925d9",
                            Email = "LibertyDuffy@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELCmsckckUt9nro3au7T7VEMZ7Nl7woYZpsWaz0fsv7fJjgn6SC6KYnqhQSvpiIj1g==",
                            PhoneNumber = "1234567896",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3885e338-4ade-4c3b-bc2f-4002fb551029",
                            TwoFactorEnabled = false,
                            UserName = "LibertyDuffy"
                        },
                        new
                        {
                            Id = "57266d27-1262-4be5-b765-f5674d41300a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "62579bb0-ccde-47b4-8fd7-23a784c83a7c",
                            Email = "ShereenRutledge@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEM+SLoB6vc4vlRYg2UTwKQHss2wSsBaVR+kCD6Ku6b8JZbSRODLSa4WBrEhFkrW9iw==",
                            PhoneNumber = "1234567897",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3545fddb-2624-437b-a855-32961ac4d9ac",
                            TwoFactorEnabled = false,
                            UserName = "ShereenRutledge"
                        },
                        new
                        {
                            Id = "3e42c4a0-a872-47a4-abc9-b3cc69b923a9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9468e829-476f-4796-80c2-9383bea8741a",
                            Email = "AnnabelleRowe@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELwDk9gERAgTFQolN5qL5ppFRqFxqmIoRSD27XJbpfwanEnBhQ64VoTAlG3g9z7puw==",
                            PhoneNumber = "1234567898",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "adb69999-e7ef-46b9-a5ca-3833550c5cb0",
                            TwoFactorEnabled = false,
                            UserName = "AnnabelleRowe"
                        },
                        new
                        {
                            Id = "8598ab52-ed4c-4c48-8ea6-28f560cd66a8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "13c2e5be-ef29-4514-8019-cc4c93678f3e",
                            Email = "RhiannanPittman@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEHlnf64xqGQezRojGBzigmruXGtaksm13WP3lMrBJ8XdJue5xHZWeyPElomCRPQgmg==",
                            PhoneNumber = "1234567899",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d2c374e6-54c1-4d18-ac0e-39b24d2f9cdf",
                            TwoFactorEnabled = false,
                            UserName = "RhiannanPittman"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
