using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "lab",
                columns: table => new
                {
                    IdLab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LabName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LabAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LabPhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lab", x => x.IdLab);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movement_type",
                columns: table => new
                {
                    IdMovementType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MovementTypeDescription = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movement_type", x => x.IdMovementType);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    IdOwner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OwnerEmail = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OwnerPhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.IdOwner);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.IdRole);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "species",
                columns: table => new
                {
                    IdSpecies = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpeciesName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_species", x => x.IdSpecies);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierPhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.IdSupplier);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vet",
                columns: table => new
                {
                    IdVet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VetName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VetEmail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierPhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    VetSpecialty = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vet", x => x.IdVet);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine",
                columns: table => new
                {
                    IdMedicine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicineName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedicineStock = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MedicinePrice = table.Column<double>(type: "double", maxLength: 200, nullable: false),
                    IdLab = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine", x => x.IdMedicine);
                    table.ForeignKey(
                        name: "FK_medicine_lab_IdLab",
                        column: x => x.IdLab,
                        principalTable: "lab",
                        principalColumn: "IdLab",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "breed",
                columns: table => new
                {
                    IdBreed = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BreedName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdSpecies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breed", x => x.IdBreed);
                    table.ForeignKey(
                        name: "FK_breed_species_IdSpecies",
                        column: x => x.IdSpecies,
                        principalTable: "species",
                        principalColumn: "IdSpecies",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "refresh_token_record",
                columns: table => new
                {
                    IdRefreshTokenRecord = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshToken = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_token_record", x => x.IdRefreshTokenRecord);
                    table.ForeignKey(
                        name: "FK__Record__IdUser__24927208",
                        column: x => x.IdUser,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role", x => new { x.IdRole, x.IdUser });
                    table.ForeignKey(
                        name: "FK_user_role_role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_user_IdUser",
                        column: x => x.IdUser,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine_movement",
                columns: table => new
                {
                    IdMedicineMovement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicineMovementQuantity = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MedicineMovementDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IdMedicine = table.Column<int>(type: "int", nullable: false),
                    IdMovementType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine_movement", x => x.IdMedicineMovement);
                    table.ForeignKey(
                        name: "FK_medicine_movement_medicine_IdMedicine",
                        column: x => x.IdMedicine,
                        principalTable: "medicine",
                        principalColumn: "IdMedicine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicine_movement_movement_type_IdMovementType",
                        column: x => x.IdMovementType,
                        principalTable: "movement_type",
                        principalColumn: "IdMovementType",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier_medicine",
                columns: table => new
                {
                    IdMedicine = table.Column<int>(type: "int", nullable: false),
                    IdSupplier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_medicine", x => new { x.IdMedicine, x.IdSupplier });
                    table.ForeignKey(
                        name: "FK_supplier_medicine_medicine_IdMedicine",
                        column: x => x.IdMedicine,
                        principalTable: "medicine",
                        principalColumn: "IdMedicine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplier_medicine_supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "supplier",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    IdPet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PetName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PetBirthDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IdOwner = table.Column<int>(type: "int", nullable: false),
                    IdSpecies = table.Column<int>(type: "int", nullable: false),
                    IdBreed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_pet_breed_IdBreed",
                        column: x => x.IdBreed,
                        principalTable: "breed",
                        principalColumn: "IdBreed",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_owner_IdOwner",
                        column: x => x.IdOwner,
                        principalTable: "owner",
                        principalColumn: "IdOwner",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_species_IdSpecies",
                        column: x => x.IdSpecies,
                        principalTable: "species",
                        principalColumn: "IdSpecies",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movement_detail",
                columns: table => new
                {
                    IdMovementDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MovementDetailQuantity = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MovementDetailPrice = table.Column<double>(type: "double", maxLength: 20, nullable: false),
                    IdMedicine = table.Column<int>(type: "int", nullable: false),
                    IdMedicineMovement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movement_detail", x => x.IdMovementDetail);
                    table.ForeignKey(
                        name: "FK_movement_detail_medicine_IdMedicine",
                        column: x => x.IdMedicine,
                        principalTable: "medicine",
                        principalColumn: "IdMedicine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movement_detail_medicine_movement_IdMedicineMovement",
                        column: x => x.IdMedicineMovement,
                        principalTable: "medicine_movement",
                        principalColumn: "IdMedicineMovement",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AppointmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AppointmentHour = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    AppointmentReason = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPet = table.Column<int>(type: "int", nullable: false),
                    IdVet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_appointment_pet_IdPet",
                        column: x => x.IdPet,
                        principalTable: "pet",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointment_vet_IdVet",
                        column: x => x.IdVet,
                        principalTable: "vet",
                        principalColumn: "IdVet",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medical_treatment",
                columns: table => new
                {
                    IdMedicalTreatment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicalTreatmentDose = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedicalTreatmentAdminDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    MedicalTreatmentObservation = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdAppointment = table.Column<int>(type: "int", nullable: false),
                    IdMedicine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_treatment", x => x.IdMedicalTreatment);
                    table.ForeignKey(
                        name: "FK_medical_treatment_appointment_IdAppointment",
                        column: x => x.IdAppointment,
                        principalTable: "appointment",
                        principalColumn: "IdAppointment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medical_treatment_medicine_IdMedicine",
                        column: x => x.IdMedicine,
                        principalTable: "medicine",
                        principalColumn: "IdMedicine",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "UserId", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "admin@example.com", "123", "Admin" },
                    { 2, "auser1@example.com", "123456", "User1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointment_IdPet",
                table: "appointment",
                column: "IdPet");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_IdVet",
                table: "appointment",
                column: "IdVet");

            migrationBuilder.CreateIndex(
                name: "IX_breed_IdSpecies",
                table: "breed",
                column: "IdSpecies");

            migrationBuilder.CreateIndex(
                name: "IX_medical_treatment_IdAppointment",
                table: "medical_treatment",
                column: "IdAppointment");

            migrationBuilder.CreateIndex(
                name: "IX_medical_treatment_IdMedicine",
                table: "medical_treatment",
                column: "IdMedicine");

            migrationBuilder.CreateIndex(
                name: "IX_medicine_IdLab",
                table: "medicine",
                column: "IdLab");

            migrationBuilder.CreateIndex(
                name: "IX_medicine_movement_IdMedicine",
                table: "medicine_movement",
                column: "IdMedicine");

            migrationBuilder.CreateIndex(
                name: "IX_medicine_movement_IdMovementType",
                table: "medicine_movement",
                column: "IdMovementType");

            migrationBuilder.CreateIndex(
                name: "IX_movement_detail_IdMedicine",
                table: "movement_detail",
                column: "IdMedicine");

            migrationBuilder.CreateIndex(
                name: "IX_movement_detail_IdMedicineMovement",
                table: "movement_detail",
                column: "IdMedicineMovement");

            migrationBuilder.CreateIndex(
                name: "IX_pet_IdBreed",
                table: "pet",
                column: "IdBreed");

            migrationBuilder.CreateIndex(
                name: "IX_pet_IdOwner",
                table: "pet",
                column: "IdOwner");

            migrationBuilder.CreateIndex(
                name: "IX_pet_IdSpecies",
                table: "pet",
                column: "IdSpecies");

            migrationBuilder.CreateIndex(
                name: "IX_refresh_token_record_IdUser",
                table: "refresh_token_record",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_medicine_IdSupplier",
                table: "supplier_medicine",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_IdUser",
                table: "user_role",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medical_treatment");

            migrationBuilder.DropTable(
                name: "movement_detail");

            migrationBuilder.DropTable(
                name: "refresh_token_record");

            migrationBuilder.DropTable(
                name: "supplier_medicine");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "medicine_movement");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "vet");

            migrationBuilder.DropTable(
                name: "medicine");

            migrationBuilder.DropTable(
                name: "movement_type");

            migrationBuilder.DropTable(
                name: "breed");

            migrationBuilder.DropTable(
                name: "owner");

            migrationBuilder.DropTable(
                name: "lab");

            migrationBuilder.DropTable(
                name: "species");
        }
    }
}
