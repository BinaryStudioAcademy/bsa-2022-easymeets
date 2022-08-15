using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Update_SlotType_Values_In_AvailabilitySlot_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               $"UPDATE [AvailabilitySlots] " +
               $"SET Type = " +
               $"Case " +
               $"WHEN  Type=1 THEN 0 " +
               $"WHEN Type=2 THEN 1 " +
               $"END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
             $"UPDATE [AvailabilitySlots] " +
             $"SET Type = " +
             $"Case " +
             $"WHEN  Type=0 THEN 1 " +
             $"WHEN Type=1 THEN 2 " +
             $"END");
        }
    }
}
