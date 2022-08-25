using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Add_MeetingMembers_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingMembers",
                columns: table => new
                {
                    TeamMemberId = table.Column<long>(type: "bigint", nullable: false),
                    MeetingId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingMembers", x => new { x.TeamMemberId, x.MeetingId });
                    table.ForeignKey(
                        name: "FK_MeetingMembers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingMembers_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingMembers");
        }
    }
}
