using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AllergyName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    MealName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Calory = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_MealCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MealCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dietitians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Specialization = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dietitians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dietitians_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    MedicalConditions = table.Column<string>(type: "text", nullable: false),
                    Medications = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DietitianId = table.Column<int>(type: "integer", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<int>(type: "integer", nullable: false),
                    EndDate = table.Column<int>(type: "integer", nullable: false),
                    CaloriesPerDay = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietPlans_Dietitians_DietitianId",
                        column: x => x.DietitianId,
                        principalTable: "Dietitians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietPlans_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    BloodPressure = table.Column<decimal>(type: "numeric", nullable: false),
                    HeartRate = table.Column<decimal>(type: "numeric", nullable: false),
                    Cholesterol = table.Column<decimal>(type: "numeric", nullable: false),
                    BloodSugar = table.Column<decimal>(type: "numeric", nullable: false),
                    RecordedDate = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientAllergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    AllergyId = table.Column<int>(type: "integer", nullable: false),
                    Severity = table.Column<string>(type: "text", nullable: false),
                    ReactionDescription = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAllergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietitianPatients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DietitianId = table.Column<int>(type: "integer", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    DietPlanId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietitianPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietitianPatients_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietitianPatients_Dietitians_DietitianId",
                        column: x => x.DietitianId,
                        principalTable: "Dietitians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietitianPatients_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietPlanMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DietPlanId = table.Column<int>(type: "integer", nullable: false),
                    MealId = table.Column<int>(type: "integer", nullable: false),
                    ServingSize = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlanMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietPlanMeals_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietPlanMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DietPlanId = table.Column<int>(type: "integer", nullable: false),
                    MealId = table.Column<int>(type: "integer", nullable: false),
                    Ingredients = table.Column<string>(type: "text", nullable: false),
                    Instructions = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealRecipes_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealRecipes_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "AllergyName", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 1, "İlaç Alerjisi", new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(1663), "Kaşıntı, Kurdeşen, Döküntü, Yüzün Şişmesi", false, null });

            migrationBuilder.InsertData(
                table: "MealCategories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 1, "Deniz Yemekleri", new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(4840), "b12 ve demir eksikliği olanlar için", false, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(7257), false, "Admin", null },
                    { 2, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(7262), false, "Dietitian", null },
                    { 3, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(7266), false, "Patient", null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calory", "CategoryId", "CreatedAt", "Description", "IsDeleted", "MealName", "UpdatedAt" },
                values: new object[] { 1, 99m, 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(5315), "Tiroit hastaları için deniz yemeği", false, "Karides", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "BirthDate", "CreatedAt", "Email", "Gender", "IsDeleted", "Name", "Password", "PhoneNumber", "RoleId", "Surname", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, 22, 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(7729), "barisceylan907@gmail.com", "Erkek", false, "Barış", "baris.C123", "05305137988", 2, "Ceylan", null, "barisscl" },
                    { 2, 21, 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(7736), "hakantemiz@gmail.com", "Erkek", false, "Hakan", "hakan.123H", "053087347821", 3, "Temiz", null, "hakaaannn.11" }
                });

            migrationBuilder.InsertData(
                table: "Dietitians",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Specialization", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(2260), false, "Diyabet Diyetisyeni", null, 1 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedAt", "Height", "IsDeleted", "MedicalConditions", "Medications", "UpdatedAt", "UserId", "Weight" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(6698), 178f, false, "Tiroid Hastalığı", "Levotiron, Tefor, Euthyrox", null, 2, 70f });

            migrationBuilder.InsertData(
                table: "DietPlans",
                columns: new[] { "Id", "CaloriesPerDay", "CreatedAt", "Details", "DietitianId", "EndDate", "IsDeleted", "PatientId", "StartDate", "UpdatedAt" },
                values: new object[] { 1, 200, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(3439), "Tiroit hastalığından dolayı alman gereken kalori miktarına dikkat etmelisin !", 1, 1, false, 1, 1, null });

            migrationBuilder.InsertData(
                table: "HealthRecords",
                columns: new[] { "Id", "BloodPressure", "BloodSugar", "Cholesterol", "CreatedAt", "HeartRate", "IsDeleted", "PatientId", "RecordedDate", "UpdatedAt" },
                values: new object[] { 1, 120m, 150m, 239m, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(4411), 90m, false, 1, 1, null });

            migrationBuilder.InsertData(
                table: "PatientAllergies",
                columns: new[] { "Id", "AllergyId", "CreatedAt", "IsDeleted", "PatientId", "ReactionDescription", "Severity", "UpdatedAt" },
                values: new object[] { 1, 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(6241), false, 1, "Ansiyete ve sinirlilik hali", "Yüksek", null });

            migrationBuilder.InsertData(
                table: "DietPlanMeals",
                columns: new[] { "Id", "CreatedAt", "DietPlanId", "IsDeleted", "MealId", "ServingSize", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(3972), 1, false, 1, 2f, null });

            migrationBuilder.InsertData(
                table: "DietitianPatients",
                columns: new[] { "Id", "CreatedAt", "DietPlanId", "DietitianId", "IsDeleted", "PatientId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(2893), 1, 1, false, 1, null });

            migrationBuilder.InsertData(
                table: "MealRecipes",
                columns: new[] { "Id", "CreatedAt", "DietPlanId", "Ingredients", "Instructions", "IsDeleted", "MealId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 20, 40, 1, 167, DateTimeKind.Utc).AddTicks(5754), 1, "Yarım kilo temizlenmiş ve dondurulmuş karides, 3 diş sarımsak, 6 yemek kaşığı zeytinyağı, 1 çay kaşığı pul biber, 1 çay kaşığı toz kırmızı biber (olmasa da olur), 1 çay kaşığından az karabiber, 1 çay kaşığı tuz, 3 yemek kaşığı limon suyu", "Yemeği Yapma Adımları", false, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_DietitianPatients_DietitianId",
                table: "DietitianPatients",
                column: "DietitianId");

            migrationBuilder.CreateIndex(
                name: "IX_DietitianPatients_DietPlanId",
                table: "DietitianPatients",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DietitianPatients_PatientId",
                table: "DietitianPatients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Dietitians_UserId",
                table: "Dietitians",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanMeals_DietPlanId",
                table: "DietPlanMeals",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanMeals_MealId",
                table: "DietPlanMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlans_DietitianId",
                table: "DietPlans",
                column: "DietitianId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlans_PatientId",
                table: "DietPlans",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_PatientId",
                table: "HealthRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MealRecipes_DietPlanId",
                table: "MealRecipes",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_MealRecipes_MealId",
                table: "MealRecipes",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CategoryId",
                table: "Meals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_AllergyId",
                table: "PatientAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_PatientId",
                table: "PatientAllergies",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DietitianPatients");

            migrationBuilder.DropTable(
                name: "DietPlanMeals");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "MealRecipes");

            migrationBuilder.DropTable(
                name: "PatientAllergies");

            migrationBuilder.DropTable(
                name: "DietPlans");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Dietitians");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "MealCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
