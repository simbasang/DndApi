using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DndApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArmorType = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligens = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    WeaponType = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    IsTwoHanded = table.Column<bool>(type: "bit", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligens = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SholderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LegsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_ChestId",
                        column: x => x.ChestId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_FeetId",
                        column: x => x.FeetId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_HandsId",
                        column: x => x.HandsId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_HeadId",
                        column: x => x.HeadId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_LegsId",
                        column: x => x.LegsId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Armors_SholderId",
                        column: x => x.SholderId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillEfectType = table.Column<int>(type: "int", nullable: false),
                    AmountType = table.Column<int>(type: "int", nullable: false),
                    EffectAmount = table.Column<int>(type: "int", nullable: false),
                    SkillType = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Skills_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMana = table.Column<int>(type: "int", nullable: false),
                    CurrentHealth = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    MaxMana = table.Column<int>(type: "int", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligens = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerSkills_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayerSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ChestId",
                table: "Equipment",
                column: "ChestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_FeetId",
                table: "Equipment",
                column: "FeetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HandsId",
                table: "Equipment",
                column: "HandsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HeadId",
                table: "Equipment",
                column: "HeadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_LegsId",
                table: "Equipment",
                column: "LegsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_SholderId",
                table: "Equipment",
                column: "SholderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_ClassId",
                table: "Players",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquipmentId",
                table: "Players",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_RaceId",
                table: "Players",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkills_PlayerId",
                table: "PlayerSkills",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkills_SkillId",
                table: "PlayerSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ClassId",
                table: "Skills",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_RaceId",
                table: "Skills",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerSkills");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Armors");
        }
    }
}
