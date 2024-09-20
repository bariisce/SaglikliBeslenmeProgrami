﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AllergyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Allergies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AllergyName = "İlaç Alerjisi",
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(30),
                            Description = "Kaşıntı, Kurdeşen, Döküntü, Yüzün Şişmesi",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CaloriesPerDay")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DietitianId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DietitianId");

                    b.HasIndex("PatientId");

                    b.ToTable("DietPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaloriesPerDay = 200,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(1917),
                            Details = "Tiroit hastalığından dolayı alman gereken kalori miktarına dikkat etmelisin !",
                            DietitianId = 1,
                            EndDate = new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            PatientId = 1,
                            StartDate = new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietPlanMeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DietPlanId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MealId")
                        .HasColumnType("integer");

                    b.Property<float>("ServingSize")
                        .HasColumnType("real");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId");

                    b.HasIndex("MealId");

                    b.ToTable("DietPlanMeals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(2376),
                            DietPlanId = 1,
                            IsDeleted = false,
                            MealId = 1,
                            ServingSize = 2f
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Dietitian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dietitians");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(768),
                            IsDeleted = false,
                            Specialization = "Diyabet Diyetisyeni",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietitianPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DietPlanId")
                        .HasColumnType("integer");

                    b.Property<int>("DietitianId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId");

                    b.HasIndex("DietitianId");

                    b.HasIndex("PatientId");

                    b.ToTable("DietitianPatients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(1288),
                            DietPlanId = 1,
                            DietitianId = 1,
                            IsDeleted = false,
                            PatientId = 1
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.HealthRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BloodPressure")
                        .HasColumnType("numeric");

                    b.Property<decimal>("BloodSugar")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Cholesterol")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("HeartRate")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RecordedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("HealthRecords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodPressure = 120m,
                            BloodSugar = 150m,
                            Cholesterol = 239m,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(2912),
                            HeartRate = 90m,
                            IsDeleted = false,
                            PatientId = 1,
                            RecordedDate = new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Calory")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calory = 99m,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(3897),
                            Description = "Tiroit hastaları için deniz yemeği",
                            IsDeleted = false,
                            MealName = "Karides"
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MealCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("MealCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Deniz Yemekleri",
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(3368),
                            Description = "b12 ve demir eksikliği olanlar için",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MealRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DietPlanId")
                        .HasColumnType("integer");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MealId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId");

                    b.HasIndex("MealId");

                    b.ToTable("MealRecipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(4374),
                            DietPlanId = 1,
                            Ingredients = "Yarım kilo temizlenmiş ve dondurulmuş karides, 3 diş sarımsak, 6 yemek kaşığı zeytinyağı, 1 çay kaşığı pul biber, 1 çay kaşığı toz kırmızı biber (olmasa da olur), 1 çay kaşığından az karabiber, 1 çay kaşığı tuz, 3 yemek kaşığı limon suyu",
                            Instructions = "Yemeği Yapma Adımları",
                            IsDeleted = false,
                            MealId = 1
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MedicalConditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Medications")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(5414),
                            Height = 178f,
                            IsDeleted = false,
                            MedicalConditions = "Tiroid Hastalığı",
                            Medications = "Levotiron, Tefor, Euthyrox",
                            UserId = 2,
                            Weight = 70f
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.PatientAllergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AllergyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<string>("ReactionDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Severity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AllergyId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientAllergies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AllergyId = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(4941),
                            IsDeleted = false,
                            PatientId = 1,
                            ReactionDescription = "Ansiyete ve sinirlilik hali",
                            Severity = "Yüksek"
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(5887),
                            IsDeleted = false,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(5893),
                            IsDeleted = false,
                            RoleName = "Dietitian"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(5896),
                            IsDeleted = false,
                            RoleName = "Patient"
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            BirthDate = new DateTime(2002, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(6355),
                            Email = "barisceylan907@gmail.com",
                            Gender = "Erkek",
                            IsDeleted = false,
                            Name = "Barış",
                            Password = "baris.C123",
                            PhoneNumber = "05305137988",
                            RoleId = 2,
                            Surname = "Ceylan",
                            Username = "barisscl"
                        },
                        new
                        {
                            Id = 2,
                            Age = 21,
                            BirthDate = new DateTime(2003, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 9, 20, 15, 14, 11, 933, DateTimeKind.Local).AddTicks(6360),
                            Email = "hakantemiz@gmail.com",
                            Gender = "Erkek",
                            IsDeleted = false,
                            Name = "Hakan",
                            Password = "hakan.123H",
                            PhoneNumber = "053087347821",
                            RoleId = 3,
                            Surname = "Temiz",
                            Username = "hakaaannn.11"
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietPlan", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Dietitian", "Dietitian")
                        .WithMany("DietPlans")
                        .HasForeignKey("DietitianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dietitian");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietPlanMeal", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.DietPlan", "DietPlan")
                        .WithMany("DietPlanMeals")
                        .HasForeignKey("DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Meal", "Meal")
                        .WithMany("DietPlanMeals")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Dietitian", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietitianPatient", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.DietPlan", "DietPlan")
                        .WithMany()
                        .HasForeignKey("DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Dietitian", "Dietitian")
                        .WithMany("DietitianPatients")
                        .HasForeignKey("DietitianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Patient", "Patient")
                        .WithMany("DietitianPatients")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");

                    b.Navigation("Dietitian");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.HealthRecord", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Patient", "Patient")
                        .WithMany("HealthRecords")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Meal", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.MealCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.MealRecipe", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.DietPlan", "DietPlan")
                        .WithMany()
                        .HasForeignKey("DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Patient", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "Users")
                        .WithMany("Patients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.PatientAllergy", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Allergy", "Allergy")
                        .WithMany("PatientAllergies")
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Patient", "Patient")
                        .WithMany("PatientAllergies")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergy");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Allergy", b =>
                {
                    b.Navigation("PatientAllergies");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.DietPlan", b =>
                {
                    b.Navigation("DietPlanMeals");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Dietitian", b =>
                {
                    b.Navigation("DietPlans");

                    b.Navigation("DietitianPatients");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Meal", b =>
                {
                    b.Navigation("DietPlanMeals");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Patient", b =>
                {
                    b.Navigation("DietitianPatients");

                    b.Navigation("HealthRecords");

                    b.Navigation("PatientAllergies");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
