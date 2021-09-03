﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleMVC.Data.DataBase;

namespace PeopleMVC.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("LanguagePerson");
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Frankfurt"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            Name = "Chicago"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 3,
                            Name = "Houston"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 4,
                            Name = "Oslo"
                        });
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 3,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Norway"
                        });
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("PeopleMVC.Models.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("SocialSecurityNr")
                        .IsUnique();

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 3,
                            FirstName = "Tina",
                            LastName = "Zwanzig",
                            PhoneNr = "031-5092-333",
                            SocialSecurityNr = "9206901234"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            FirstName = "Olle",
                            LastName = "Larsson",
                            PhoneNr = "074-3232-356",
                            SocialSecurityNr = "9206902222"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            FirstName = "Karin",
                            LastName = "Andersson",
                            PhoneNr = "074-3244-444",
                            SocialSecurityNr = "9206901111"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            FirstName = "Fatima",
                            LastName = "Koh",
                            PhoneNr = "071-1234-123",
                            SocialSecurityNr = "9206905678"
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("PeopleMVC.Data.Entities.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleMVC.Models.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.City", b =>
                {
                    b.HasOne("PeopleMVC.Data.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PeopleMVC.Models.Entities.Person", b =>
                {
                    b.HasOne("PeopleMVC.Data.Entities.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("PeopleMVC.Data.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
