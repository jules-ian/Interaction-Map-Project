﻿// <auto-generated />
using System;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Audiences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("12b1c47b-e752-4203-8059-a8bbcb526a9d"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "0-3 ans"
                        },
                        new
                        {
                            Id = new Guid("f51fc34c-1c5a-45f6-be14-dc1a8e08b54a"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "3-6 ans"
                        },
                        new
                        {
                            Id = new Guid("55bc3bb7-3b5d-49e0-a62f-27a705ec84ac"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "6-12 ans"
                        },
                        new
                        {
                            Id = new Guid("d68a3fe3-a1b1-4005-9a67-fec96f230245"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "12-18 ans"
                        },
                        new
                        {
                            Id = new Guid("4c7ab37a-62c3-40e7-bfc5-210d9a3654c4"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Parents"
                        },
                        new
                        {
                            Id = new Guid("1a582e56-4e22-40f9-ad71-2f59ad0f8522"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Professionnels"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Missions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d80477b2-ebb6-4b8a-8044-8002e4ebaabf"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de loisirs"
                        },
                        new
                        {
                            Id = new Guid("a8d51451-da44-4248-85ee-b251822415cc"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Petite enfance"
                        },
                        new
                        {
                            Id = new Guid("90a445eb-5c48-45b2-9e9b-db10c70e018f"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Répit"
                        },
                        new
                        {
                            Id = new Guid("360bdf6a-396a-40df-b4a4-97b259b4c12a"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil occasionnel"
                        },
                        new
                        {
                            Id = new Guid("6eeefc1e-bd62-46f9-9ffd-8c4e154b579b"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Scolarité"
                        },
                        new
                        {
                            Id = new Guid("28c560d8-701f-4013-9c74-12c138651b78"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Référent santé accueil inclusif (RSAI)"
                        },
                        new
                        {
                            Id = new Guid("8a5157a5-8bee-4f15-b6d7-9308f1440b02"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de jour"
                        },
                        new
                        {
                            Id = new Guid("783ad868-f47d-42ce-8350-652e623c836f"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de nuit"
                        },
                        new
                        {
                            Id = new Guid("4d0ddaaf-0d0c-4ac7-8c53-1244c3926511"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Soins/santé/réeducation"
                        },
                        new
                        {
                            Id = new Guid("df65210e-8ec6-4750-8703-39110fddbdea"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accompagnement à la parentalité"
                        },
                        new
                        {
                            Id = new Guid("863f82c8-2319-4adb-95ca-a678eec78e11"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accompagnement administratif"
                        },
                        new
                        {
                            Id = new Guid("af71ede5-4336-4422-bf0f-0cef2a108fe8"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ressource documentaire"
                        },
                        new
                        {
                            Id = new Guid("10072e8f-03bd-457f-a6d8-01b0bd368ea0"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Group de parole/Ateliers"
                        },
                        new
                        {
                            Id = new Guid("bb8f5973-92d2-4136-956a-8802d2296385"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Orientation"
                        },
                        new
                        {
                            Id = new Guid("2dc71c9e-e077-4cf5-8a84-e2c7ea86f133"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prestataire"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlacesOfIntervention", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5c236e21-df55-42b9-9d10-6787f0379f8e"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Domicile"
                        },
                        new
                        {
                            Id = new Guid("80cd1709-4478-4b40-8c0d-7dfd5e7ab210"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "EAJE"
                        },
                        new
                        {
                            Id = new Guid("1012d645-73b3-494d-96ba-49e60a2a606e"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "École"
                        },
                        new
                        {
                            Id = new Guid("a0b8c54b-c1e4-4c53-9711-6872f5ac6ecb"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cabinet"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalAudience", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AudienceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "AudienceId");

                    b.HasIndex("AudienceId");

                    b.ToTable("ProfessionalsAudiences", (string)null);
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalMission", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("ProfessionalsMissions", (string)null);
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalPlaceOfIntervention", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaceOfInterventionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "PlaceOfInterventionId");

                    b.HasIndex("PlaceOfInterventionId");

                    b.ToTable("ProfessionalsPlacesOfIntervention", (string)null);
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstablishmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Professionals", (string)null);
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalAudience", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", "Audience")
                        .WithMany("Professionals")
                        .HasForeignKey("AudienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("Audiences")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Audience");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalMission", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", "Mission")
                        .WithMany("Professionals")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("Missions")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalPlaceOfIntervention", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", "PlaceOfIntervention")
                        .WithMany("Professionals")
                        .HasForeignKey("PlaceOfInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("PlacesOfIntervention")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlaceOfIntervention");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.ContactPerson", "ContactPerson", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Function")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("PhoneNumber")
                                .HasColumnType("int");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.Geolocation", "Geolocation", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("ContactPerson")
                        .IsRequired();

                    b.Navigation("Geolocation")
                        .IsRequired();
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.Navigation("Audiences");

                    b.Navigation("Missions");

                    b.Navigation("PlacesOfIntervention");
                });
#pragma warning restore 612, 618
        }
    }
}
