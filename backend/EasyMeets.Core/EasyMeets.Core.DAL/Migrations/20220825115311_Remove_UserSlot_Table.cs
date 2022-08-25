using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Remove_UserSlot_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSlot");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSlot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSlot_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSlot_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserSlot",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L },
                    { 2L, 2L, false, 2L },
                    { 3L, 3L, false, 3L },
                    { 4L, 4L, false, 4L },
                    { 5L, 5L, false, 5L },
                    { 6L, 6L, false, 6L },
                    { 7L, 7L, false, 7L },
                    { 8L, 8L, false, 8L },
                    { 9L, 9L, false, 9L },
                    { 10L, 10L, false, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_AvailabilitySlotId",
                table: "UserSlot",
                column: "AvailabilitySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_UserId",
                table: "UserSlot",
                column: "UserId");
        }
    }
}
