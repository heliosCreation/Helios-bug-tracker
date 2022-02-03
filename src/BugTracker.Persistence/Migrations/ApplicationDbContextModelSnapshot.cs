﻿// <auto-generated />
using System;
using BugTracker.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationUserProject", b =>
                {
                    b.Property<Guid>("ProjectsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectsId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("ApplicationUserProject");
                });

            modelBuilder.Entity("ApplicationUserTicket", b =>
                {
                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("TicketsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeamId", "TicketsId");

                    b.HasIndex("TicketsId");

                    b.ToTable("ApplicationUserTicket");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedAmountOfHours")
                        .HasColumnType("int");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BugTracker.Domain.Identity.ApplicationUser", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "805ea1cb-3a0a-4076-85f8-8bc8ac6070e3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e7e2955-bc0e-4d1d-a18d-ea6430b9c6c8",
                            Email = "DemoAdmin@Admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOADMIN@ADMIN.COM",
                            NormalizedUserName = "DEMO ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDJ2GE+JvKHzLfHDwH8HcaZsXDlHcO1nCM6YCWsH/BOwDcbJztafaEXVZP/eR5HUhQ==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Admin"
                        },
                        new
                        {
                            Id = "8ca59f42-0405-4e45-9ef9-c1f92e648ef6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f6a1d908-1d85-4eea-9aea-5b04630d49eb",
                            Email = "DemoDev@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMODEV@GMAIL.COM",
                            NormalizedUserName = "DEMO DEVELOPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEDVj2pP8giK2drUHxIOw2RFpFP1vrZFuA/LqLXfbDXid8Bb2i4A954ZcF2kKe8axYA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo developer"
                        },
                        new
                        {
                            Id = "c4aec3eb-4ad5-44de-8d3c-d2338813caee",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb8372c8-4664-4bb2-9e9a-d9ce24264c7b",
                            Email = "john@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN@GMAIL.COM",
                            NormalizedUserName = "DEMO SUBMITTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEMq0LyNpG2vXH9YfolrdQWIyF1D+kzT2Qtqh9IZNecpVpS4PhMdIuleQmXidPp+tzQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo submitter"
                        },
                        new
                        {
                            Id = "b86afb1d-e945-4a29-91ce-7a82e4b4d757",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "50e97083-ca95-4c20-8845-cb16d48d6591",
                            Email = "demoPM@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOPM@GMAIL.COM",
                            NormalizedUserName = "DEMO PROJECT MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEIA0G/juKjAziPIGSUjJ8VPbC6d0D57oxghLBe1wTCPvXhcYREjQv6PipPAVblnQPw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Project Manager"
                        },
                        new
                        {
                            Id = "5cfddd63-424e-46ad-b202-1fd94269cefe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "24f18718-e99d-4ab9-a13e-d40b533032c1",
                            Email = "quentin.coui@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QUENTIN.COUI@HOTMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJb/fdEtxa0skd6iu7PqmbcGY5o24HuKuJSvQOaWQEHH2bTND7bay4JSZ9cMLrDfAw==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "291508f3-6656-4ff2-b801-bcd405792b62",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e578f08c-ef7b-4daa-bc53-f103194a782b",
                            Email = "john.doe@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN.DOE@HOTMAIL.COM",
                            NormalizedUserName = "JOHN DOE",
                            PasswordHash = "AQAAAAEAACcQAAAAEKNLKgp0D389p4NwqjrMZx+pBJVOvo8ZA0Xk69ybCE1K3ca9RXMzc0cCYGwfa+qcnA==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "John doe"
                        },
                        new
                        {
                            Id = "d475f214-2fc4-4244-a3e0-06bf62b6fd65",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "94fdb525-4f51-4885-924a-911a3fc4ace9",
                            Email = "jane.doe@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JANE.DOE@HOTMAIL.COM",
                            NormalizedUserName = "JANE DOE",
                            PasswordHash = "AQAAAAEAACcQAAAAEIBVNKtS1ZYrYhGqFLMmfT/JWun+CPLx9l2pFX09GjV71mK5SFUui/pO14VLsK6L1w==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Jane doe"
                        },
                        new
                        {
                            Id = "e91815a6-5c63-45e1-950c-3410daeeb13d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1faba3f3-28ad-4154-b040-5caefe81e91e",
                            Email = "jack.nicklefrost@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JACK.NICKLEFROST@HOTMAIL.COM",
                            NormalizedUserName = "JACK NICKEFROST",
                            PasswordHash = "AQAAAAEAACcQAAAAENuXgZ9L6bHiLYGB231wc1Beh+OlvJ7eH9YRjUo/MJeRA4MWdL0+o0jCBNqzyRT7Xg==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Jack nicklefrost"
                        },
                        new
                        {
                            Id = "1f5066c7-c502-4048-8438-d725dc55d4db",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f403623-dfb9-46d1-a460-9d60efc6bc6b",
                            Email = "alice.cooper@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICE.COOPER@HOTMAIL.COM",
                            NormalizedUserName = "ALICE COOPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEC6xvmbj7IjhgHqd6MbuOI2oAw1vvIH2EKG80L7hr0o9G2mMoZrLhjyPV6ihx0QfPQ==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Alice cooper"
                        });
                });

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "8538a649-7957-44d1-b783-920b3ccbcc93",
                            ConcurrencyStamp = "5c0cf457-acc2-4a08-b46c-808ac3ecda86",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f59a635a-ae1a-47b7-9ed8-0e9f303080db",
                            ConcurrencyStamp = "ff0194b0-e7ef-4f6b-876b-59c15d62e5c1",
                            Name = "Project Manager",
                            NormalizedName = "PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "29988be7-9501-4429-8b05-5c6102c68742",
                            ConcurrencyStamp = "c89d2621-adcb-4e9e-a6dc-8edc540dd49e",
                            Name = "Developer",
                            NormalizedName = "DEVELOPER"
                        },
                        new
                        {
                            Id = "5fcac0df-b6a9-46d5-8c96-259e169f9d10",
                            ConcurrencyStamp = "afda2c5d-1b94-44e0-9518-d5a55dd86dea",
                            Name = "Submitter",
                            NormalizedName = "SUBMITTER"
                        },
                        new
                        {
                            Id = "506037ee-697f-4b55-b4ca-cb9bf226902a",
                            ConcurrencyStamp = "d052b974-6ed8-4ed8-8485-8d2f6383c83c",
                            Name = "Demo Admin",
                            NormalizedName = "DEMO_ADMIN"
                        },
                        new
                        {
                            Id = "b5488c61-c6c0-46b5-9ec9-7e0ff3a350d7",
                            ConcurrencyStamp = "9ab07f0c-ebea-4cd5-b3bf-56100e4a10bc",
                            Name = " Demo Project Manager",
                            NormalizedName = "DEMO PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "1e798ffa-7fa8-4e1b-bc49-b0a76f3fa421",
                            ConcurrencyStamp = "fdefbcee-a4b4-4ff0-acf5-38d410acc01c",
                            Name = "Demo Developer",
                            NormalizedName = "DEMO DEVELOPER"
                        },
                        new
                        {
                            Id = "a8ddc5ce-856f-4464-898a-407f6add02f9",
                            ConcurrencyStamp = "a25386b2-97f3-4930-a24a-be529366ff24",
                            Name = "Demo Submitter",
                            NormalizedName = "DEMO SUBMITTER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ApplicationUserProject", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserTicket", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Domain.Entities.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Comment", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Ticket", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
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
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
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

                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
