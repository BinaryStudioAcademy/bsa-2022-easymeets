using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Samples",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Samples",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Samples",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoPath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PageLink = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailabilitySlots",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    AdvancedSlotSettingsId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilitySlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailabilitySlots_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvailabilitySlots_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvailabilitySlots_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AddEventsFromTeamId = table.Column<long>(type: "bigint", nullable: false),
                    CheckForConflicts = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendars_Teams_AddEventsFromTeamId",
                        column: x => x.AddEventsFromTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedSlotSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    ActivityType = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MaxNumberOfBookings = table.Column<int>(type: "int", nullable: false),
                    PaddingBeforeMeeting = table.Column<int>(type: "int", nullable: false),
                    BookingScheduleBlockingTimeMeetingInHours = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedSlotSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalAttendees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    EventTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAttendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalAttendees_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSlot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CalendarVisibleForTeams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarVisibleForTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarVisibleForTeams_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarVisibleForTeams_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMemberMeetings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberMeetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMemberMeetings_Meetings_EventId",
                        column: x => x.EventId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMemberMeetings_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalAttendeeAvailabilities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalAttendeeId = table.Column<long>(type: "bigint", nullable: false),
                    StartEvent = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndEvent = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAttendeeAvailabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalAttendeeAvailabilities_ExternalAttendees_ExternalAttendeeId",
                        column: x => x.ExternalAttendeeId,
                        principalTable: "ExternalAttendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                column: "AvailabilitySlotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_CreatedBy",
                table: "AvailabilitySlots",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_LocationId",
                table: "AvailabilitySlots",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_TeamId",
                table: "AvailabilitySlots",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_AddEventsFromTeamId",
                table: "Calendars",
                column: "AddEventsFromTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_UserId",
                table: "Calendars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarVisibleForTeams_CalendarId",
                table: "CalendarVisibleForTeams",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarVisibleForTeams_TeamId",
                table: "CalendarVisibleForTeams",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAttendeeAvailabilities_ExternalAttendeeId",
                table: "ExternalAttendeeAvailabilities",
                column: "ExternalAttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAttendees_AvailabilitySlotId",
                table: "ExternalAttendees",
                column: "AvailabilitySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CreatedBy",
                table: "Meetings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_LocationId",
                table: "Meetings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_TeamId",
                table: "Meetings",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AvailabilitySlotId",
                table: "Questions",
                column: "AvailabilitySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberMeetings_EventId",
                table: "TeamMemberMeetings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberMeetings_MemberId",
                table: "TeamMemberMeetings",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_UserId",
                table: "TeamMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_AvailabilitySlotId",
                table: "UserSlot",
                column: "AvailabilitySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_UserId",
                table: "UserSlot",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancedSlotSettings");

            migrationBuilder.DropTable(
                name: "CalendarVisibleForTeams");

            migrationBuilder.DropTable(
                name: "ExternalAttendeeAvailabilities");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TeamMemberMeetings");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "UserSlot");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "ExternalAttendees");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "AvailabilitySlots");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Samples");

            migrationBuilder.InsertData(
                table: "Samples",
                columns: new[] { "Id", "Body", "CreatedAt", "CreatedBy", "Title" },
                values: new object[,]
                {
                    { 2L, "Eligendi quisquam ullam iure praesentium numquam sapiente distinctio ad. Tempore voluptatibus ad et adipisci hic amet. Corporis soluta cupiditate soluta. Provident rerum nemo dolores debitis dicta voluptatem labore dolores adipisci. Adipisci illo quidem sit dolores. Ea dolor animi quod laborum quia perspiciatis sunt tempora.", new DateTime(2020, 7, 1, 1, 14, 20, 556, DateTimeKind.Unspecified).AddTicks(7372), 5L, "hic" },
                    { 3L, "Incidunt perferendis omnis. Quas voluptatem beatae vitae sunt a ut sed repellendus. Accusamus eos enim consequatur et praesentium ad ut beatae eius. Omnis voluptas error et velit autem ipsa atque consequuntur vitae. Nostrum accusamus soluta nisi.", new DateTime(2020, 11, 26, 1, 10, 54, 982, DateTimeKind.Unspecified).AddTicks(9175), 4L, "velit" },
                    { 4L, "Architecto laboriosam culpa cumque dicta in. Perspiciatis amet autem rerum recusandae perspiciatis pariatur. Eum sint molestiae quis neque tempora ab distinctio. Nobis nulla dignissimos voluptas nemo cumque tenetur quod et placeat. Nihil sit eos similique fuga enim dolores ullam suscipit.", new DateTime(2021, 1, 18, 12, 14, 38, 642, DateTimeKind.Unspecified).AddTicks(7703), 1L, "est" },
                    { 5L, "Sapiente et saepe ut atque dolore accusantium soluta cumque perferendis. Magni adipisci labore corrupti. Ratione et quibusdam consequatur voluptatem velit expedita eos maxime.", new DateTime(2020, 2, 2, 15, 3, 56, 551, DateTimeKind.Unspecified).AddTicks(1864), 5L, "placeat" },
                    { 6L, "Iusto aspernatur nihil iure ut blanditiis veritatis quas. Et illum quod atque nulla voluptas quos beatae quaerat consequatur. Ab placeat tenetur perferendis et omnis. Doloremque corrupti deserunt sint enim ex sit.", new DateTime(2021, 4, 7, 16, 50, 6, 239, DateTimeKind.Unspecified).AddTicks(5929), 3L, "facere" },
                    { 7L, "Doloremque omnis facilis unde exercitationem consectetur culpa porro consequatur sed. Vel rem rerum eum harum. Ratione voluptate est officia accusamus doloremque perferendis ea. Unde iure laudantium ut amet repellendus enim consequatur dolor porro. Sed expedita dolorem aperiam ipsa omnis. Ut omnis ipsa quia cupiditate iure.", new DateTime(2019, 7, 23, 7, 33, 40, 245, DateTimeKind.Unspecified).AddTicks(9313), 5L, "impedit" },
                    { 8L, "Nesciunt placeat et consectetur enim. Consectetur magnam perspiciatis ut rem perspiciatis odit dolorem. Modi corrupti corrupti.", new DateTime(2020, 1, 27, 9, 1, 30, 801, DateTimeKind.Unspecified).AddTicks(8159), 3L, "corporis" },
                    { 9L, "Omnis culpa earum modi eos beatae autem. Deleniti labore veritatis dolorum. Omnis perferendis ut sit nulla autem ut voluptatem voluptas ut.", new DateTime(2021, 3, 25, 21, 11, 5, 602, DateTimeKind.Unspecified).AddTicks(6614), 5L, "perspiciatis" },
                    { 10L, "Molestias porro exercitationem omnis et eius. Est consequatur esse sit quia dolorem sequi doloribus corporis. Perspiciatis qui dignissimos.", new DateTime(2021, 4, 7, 22, 46, 32, 439, DateTimeKind.Unspecified).AddTicks(5958), 3L, "esse" },
                    { 11L, "Eos eum perferendis nisi alias et ducimus repudiandae ut. Voluptas rerum ullam omnis placeat non ea voluptatibus. Sint et et asperiores omnis recusandae saepe laborum enim. Non consequatur voluptatem in aut quia quo quo. Commodi aliquid aut quaerat adipisci. Modi ea maxime doloribus qui sint.", new DateTime(2021, 3, 24, 14, 25, 37, 776, DateTimeKind.Unspecified).AddTicks(56), 1L, "in" }
                });
        }
    }
}
