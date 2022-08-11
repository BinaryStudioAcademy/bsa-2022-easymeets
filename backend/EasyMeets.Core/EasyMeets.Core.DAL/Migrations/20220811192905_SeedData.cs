using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, false, "Zoom" },
                    { 2L, false, "GoogleMeet" },
                    { 3L, false, "Discord" },
                    { 4L, false, "Skype" },
                    { 5L, false, "Slack" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "IsDeleted", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[,]
                {
                    { 1L, "error", false, "", "Johns Inc", "https://newton.biz", "Asia/Bagh" },
                    { 2L, "Et impedit dolores cupiditate est.\nModi consequuntur enim itaque.\nEos cum et est maiores mollitia.", false, "", "Reinger - Braun", "https://fritz.org", "Asia/Dhak" },
                    { 3L, "Non numquam voluptas et aut aut corporis vel est.", false, "", "Haley - Larkin", "http://madisyn.org", "Pacific/P" },
                    { 4L, "Iure consequuntur a. Minus asperiores quidem pariatur. Omnis ipsam reiciendis quos. Qui mollitia eum nemo temporibus officiis accusamus.", false, "", "Daniel and Sons", "http://lauriane.info", "Asia/Alma" },
                    { 5L, "Ab ullam consequatur ea laborum quidem ut culpa.\nOfficiis perspiciatis quos totam cupiditate provident tempora cupiditate ea sint.\nPorro libero distinctio sapiente dolor eaque quae.\nQui ut et porro molestiae aliquid doloremque dicta.\nVelit sed magni architecto est assumenda in id modi beatae.", false, "", "Schroeder, Gerhold and Reynolds", "https://dillon.org", "Australia" },
                    { 6L, "Possimus deserunt praesentium quas.\nQuidem reprehenderit fugit vel hic.\nUllam consequatur qui at totam illo quasi.\nReiciendis quibusdam minima.\nNon quos accusamus.\nIste voluptatem nesciunt asperiores eum rerum qui.", false, "", "Klocko - Hoeger", "http://kelsi.org", "America/S" },
                    { 7L, "Vero consequuntur consequatur earum repudiandae et consequatur aliquam illum. Explicabo labore ex voluptate harum amet sapiente. Voluptas voluptas accusantium. Consequatur eos quia et dolor deleniti velit architecto id. Aut perferendis vitae et ullam. Et quia nesciunt iste voluptatem qui dignissimo", false, "", "Kling LLC", "https://lempi.net", "Asia/Novo" },
                    { 8L, "At voluptatem velit quos autem beatae sequi incidunt soluta ut.", false, "", "Hagenes Group", "https://rossie.name", "Asia/Riya" },
                    { 9L, "Vel et numquam iusto eaque sint.\nExercitationem reprehenderit atque debitis.\nQuo quasi eius non dicta modi quibusdam aut sit.", false, "", "Stoltenberg Group", "http://erwin.org", "Europe/Br" },
                    { 10L, "Rerum itaque et adipisci similique corporis eum.\nEt quisquam distinctio laudantium illum est quidem doloremque est.\nCulpa quo consectetur aperiam voluptatibus soluta est possimus eveniet iure.", false, "", "Frami, Kuphal and Langworth", "http://magnolia.com", "Pacific/A" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Country", "DateFormat", "Email", "ImagePath", "IsBanned", "IsDeleted", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[,]
                {
                    { 1L, 1, 2, "Stuart.Funk@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/133.jpg", false, false, 2, "Stuart Funk", "(829) 296-", 2, null },
                    { 2L, 1, 2, "Adrienne.Emmerich62@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/526.jpg", false, false, 2, "Adrienne Emmerich", "(306) 812-", 2, null },
                    { 3L, 1, 2, "Faith.Olson68@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/652.jpg", false, false, 2, "Faith Olson", "833-988-82", 2, null },
                    { 4L, 1, 2, "Donna14@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/702.jpg", false, false, 2, "Donna MacGyver", "1-951-899-", 2, null },
                    { 5L, 1, 2, "Beatrice.Stoltenberg@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/988.jpg", false, false, 2, "Beatrice Stoltenberg", "1-776-299-", 2, null },
                    { 6L, 1, 2, "Pete73@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/286.jpg", false, false, 2, "Pete Muller", "(463) 858-", 2, null },
                    { 7L, 1, 2, "Lamar_Stiedemann@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/394.jpg", false, false, 2, "Lamar Stiedemann", "(513) 882-", 2, null },
                    { 8L, 1, 2, "Omar67@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/683.jpg", false, false, 2, "Omar Ebert", "(372) 494-", 2, null },
                    { 9L, 1, 2, "Caroline22@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/816.jpg", false, false, 2, "Caroline Boehm", "(262) 463-", 2, null },
                    { 10L, 1, 2, "Maurice_Kemmer@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1241.jpg", false, false, 2, "Maurice Kemmer", "(578) 572-", 2, null }
                });

            migrationBuilder.InsertData(
                table: "AvailabilitySlots",
                columns: new[] { "Id", "AdvancedSlotSettingsId", "CreatedAt", "CreatedBy", "Description", "Frequency", "IsDeleted", "IsEnabled", "IsVisible", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2020, 9, 28, 16, 32, 50, 903, DateTimeKind.Unspecified).AddTicks(1093), 1L, "Aut aut qui consequatur maxime suscipit eveniet doloribus.", 17, false, true, true, "https://noemy.net", 3L, "in", 15, 2L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, 2L, new DateTime(2020, 6, 11, 10, 46, 22, 3, DateTimeKind.Unspecified).AddTicks(2683), 2L, "distinctio", 26, false, true, true, "http://salma.com", 2L, "exercitationem", 50, 10L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, 3L, new DateTime(2021, 5, 6, 14, 48, 32, 635, DateTimeKind.Unspecified).AddTicks(4730), 3L, "Voluptatem sint delectus odit sit.", 30, false, true, true, "http://maxie.net", 1L, "officiis", 35, 4L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, 4L, new DateTime(2021, 1, 11, 22, 33, 22, 390, DateTimeKind.Unspecified).AddTicks(6669), 4L, "possimus", 20, false, true, true, "http://bethel.org", 1L, "cumque", 22, 6L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, 5L, new DateTime(2019, 8, 25, 9, 57, 10, 530, DateTimeKind.Unspecified).AddTicks(8298), 5L, "laudantium", 21, false, true, true, "http://dion.net", 4L, "molestiae", 26, 3L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, 6L, new DateTime(2020, 3, 26, 5, 25, 40, 941, DateTimeKind.Unspecified).AddTicks(5541), 6L, "Quia qui earum iure et similique dolore eum quis.", 17, false, true, true, "http://bernadine.net", 3L, "impedit", 33, 9L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, 7L, new DateTime(2021, 2, 24, 11, 58, 32, 727, DateTimeKind.Unspecified).AddTicks(8995), 7L, "Est ipsam et labore id sit odit. Laboriosam omnis cumque repellat natus eius laborum dolores. Est consequuntur deleniti nostrum. Maxime pariatur ab nihil ducimus nemo dicta necessitatibus. Reiciendis doloribus vero excepturi doloremque sunt laborum.", 17, false, true, true, "http://francesca.info", 3L, "voluptatem", 36, 9L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, 8L, new DateTime(2020, 1, 28, 19, 43, 11, 595, DateTimeKind.Unspecified).AddTicks(3254), 8L, "Dolores rerum voluptatem qui nihil consequatur totam. Et totam rerum et. Blanditiis ipsum voluptas. Minima sit vitae. Eius voluptatem alias aspernatur et delectus nihil. Et iusto voluptatem totam architecto reiciendis quia impedit.", 24, false, true, true, "http://cathy.biz", 1L, "iste", 23, 4L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, 9L, new DateTime(2019, 9, 17, 3, 3, 2, 133, DateTimeKind.Unspecified).AddTicks(9818), 9L, "Odit quibusdam ea qui. Aliquam officia voluptate. Incidunt veritatis libero. Consequatur quia ipsa aliquam.", 21, false, true, true, "http://matteo.info", 5L, "quis", 33, 8L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, 10L, new DateTime(2020, 11, 5, 17, 49, 21, 4, DateTimeKind.Unspecified).AddTicks(4152), 10L, "Omnis est quas cumque.\nQuia commodi quis vero dolores voluptatum possimus et.\nAccusantium ex et exercitationem commodi iure quae.\nEos excepturi quo animi reprehenderit qui ad ut cum iste.\nSunt nobis possimus eius vero unde aspernatur est illum.\nVoluptatem quidem dignissimos sit ab mollitia et repreh", 27, false, true, true, "http://tia.org", 4L, "voluptas", 24, 8L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "AddEventsFromTeamId", "CheckForConflicts", "CreatedAt", "CreatedBy", "IsDeleted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 4L, false, new DateTime(2019, 12, 24, 0, 40, 30, 684, DateTimeKind.Unspecified).AddTicks(7630), 4L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L },
                    { 2L, 2L, false, new DateTime(2020, 4, 7, 21, 43, 39, 569, DateTimeKind.Unspecified).AddTicks(2454), 10L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1L },
                    { 3L, 10L, false, new DateTime(2020, 12, 30, 5, 41, 5, 741, DateTimeKind.Unspecified).AddTicks(3460), 9L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 8L },
                    { 4L, 1L, false, new DateTime(2021, 5, 7, 0, 48, 55, 108, DateTimeKind.Unspecified).AddTicks(563), 2L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L },
                    { 5L, 7L, false, new DateTime(2020, 11, 24, 19, 4, 16, 199, DateTimeKind.Unspecified).AddTicks(7885), 5L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 6L, 7L, false, new DateTime(2021, 7, 11, 21, 29, 18, 315, DateTimeKind.Unspecified).AddTicks(6296), 7L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1L },
                    { 7L, 2L, false, new DateTime(2020, 6, 17, 8, 53, 45, 293, DateTimeKind.Unspecified).AddTicks(7350), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 8L },
                    { 8L, 4L, false, new DateTime(2021, 3, 19, 2, 57, 32, 944, DateTimeKind.Unspecified).AddTicks(7608), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 5L },
                    { 9L, 4L, false, new DateTime(2020, 7, 7, 9, 16, 40, 364, DateTimeKind.Unspecified).AddTicks(5792), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 10L, 3L, false, new DateTime(2020, 2, 25, 22, 25, 43, 784, DateTimeKind.Unspecified).AddTicks(8961), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "IsDeleted", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 11, 2, 4, 6, 34, 491, DateTimeKind.Unspecified).AddTicks(5665), 5L, "Aut quae qui reiciendis excepturi.", 38, false, 1L, "necessitatibus", new DateTimeOffset(new DateTime(2023, 4, 19, 11, 3, 43, 622, DateTimeKind.Unspecified).AddTicks(5148), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2021, 5, 3, 9, 6, 8, 233, DateTimeKind.Unspecified).AddTicks(9395), 8L, "Ab omnis ullam quasi eveniet blanditiis eum quidem", 23, false, 2L, "assumenda", new DateTimeOffset(new DateTime(2023, 2, 24, 19, 9, 7, 917, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2020, 12, 5, 7, 42, 57, 898, DateTimeKind.Unspecified).AddTicks(9299), 8L, "Iste molestiae ab. Enim id minus. Accusantium exer", 14, false, 3L, "magnam", new DateTimeOffset(new DateTime(2023, 1, 18, 19, 55, 8, 945, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, new DateTime(2019, 12, 8, 3, 44, 36, 289, DateTimeKind.Unspecified).AddTicks(9829), 6L, "Est quae est. Esse vel earum odit ducimus voluptat", 23, false, 5L, "ex", new DateTimeOffset(new DateTime(2023, 1, 28, 23, 5, 47, 848, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, new DateTime(2020, 6, 26, 3, 12, 58, 704, DateTimeKind.Unspecified).AddTicks(3493), 10L, "Ullam delectus eos tempore totam eos non vel.\nMole", 53, false, 1L, "cumque", new DateTimeOffset(new DateTime(2023, 4, 23, 19, 33, 29, 438, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, new DateTime(2020, 4, 22, 11, 10, 54, 158, DateTimeKind.Unspecified).AddTicks(8797), 7L, "dolore", 44, false, 1L, "est", new DateTimeOffset(new DateTime(2023, 6, 4, 20, 5, 44, 21, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, new DateTime(2020, 8, 5, 8, 6, 15, 626, DateTimeKind.Unspecified).AddTicks(9404), 6L, "Voluptatum consequatur deserunt ut magni eum paria", 50, false, 1L, "commodi", new DateTimeOffset(new DateTime(2022, 12, 27, 3, 34, 18, 672, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, new DateTime(2020, 10, 11, 23, 10, 12, 626, DateTimeKind.Unspecified).AddTicks(5475), 4L, "Ea suscipit hic aut quia sunt aliquam aperiam moll", 46, false, 2L, "voluptas", new DateTimeOffset(new DateTime(2023, 1, 26, 4, 30, 43, 288, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, new DateTime(2020, 1, 28, 4, 59, 5, 309, DateTimeKind.Unspecified).AddTicks(8676), 10L, "Qui id debitis voluptas sed quo quidem sunt ea.\nQu", 43, false, 5L, "saepe", new DateTimeOffset(new DateTime(2023, 1, 17, 21, 55, 20, 29, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, new DateTime(2020, 10, 23, 7, 2, 38, 163, DateTimeKind.Unspecified).AddTicks(6104), 9L, "Odit atque autem dolores iusto.", 18, false, 2L, "qui", new DateTimeOffset(new DateTime(2023, 6, 27, 18, 54, 59, 703, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "IsDeleted", "Role", "Status", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1L, false, 1, 2, 1L, 1L },
                    { 2L, false, 2, 1, 2L, 2L },
                    { 3L, false, 1, 1, 3L, 3L },
                    { 4L, false, 1, 1, 4L, 4L },
                    { 5L, false, 2, 1, 5L, 5L },
                    { 6L, false, 2, 2, 6L, 6L },
                    { 7L, false, 2, 1, 7L, 7L },
                    { 8L, false, 1, 2, 8L, 8L },
                    { 9L, false, 1, 2, 9L, 9L },
                    { 10L, false, 2, 2, 10L, 10L }
                });

            migrationBuilder.InsertData(
                table: "AdvancedSlotSettings",
                columns: new[] { "Id", "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "IsDeleted", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[,]
                {
                    { 1L, 3, 1L, 5, 5, 17, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 14, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, 3, 2L, 1, 5, 19, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 10, 7, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, 1, 3L, 3, 1, 30, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 3, 3, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, 2, 4L, 2, 6, 27, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, 1, 5L, 2, 5, 21, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 7, 7, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, 1, 6L, 4, 3, 29, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 4, 7, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, 1, 7L, 3, 7, 17, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 3, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, 1, 8L, 4, 7, 10, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 12, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, 1, 9L, 5, 7, 27, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 6, 9, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, 1, 10L, 2, 8, 13, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 8, 14, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "CalendarVisibleForTeams",
                columns: new[] { "Id", "CalendarId", "IsDeleted", "TeamId" },
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

            migrationBuilder.InsertData(
                table: "ExternalAttendees",
                columns: new[] { "Id", "AvailabilitySlotId", "Email", "EventTime", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, 2L, "Josh.Bailey@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 8, 9, 20, 22, 111, DateTimeKind.Unspecified).AddTicks(2131), new TimeSpan(0, 3, 0, 0, 0)), false, "Josh Bailey" },
                    { 2L, 6L, "Derek.Leannon@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 20, 15, 47, 31, 510, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 3, 0, 0, 0)), false, "Derek Leannon" },
                    { 3L, 6L, "April.Conn@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 18, 11, 9, 52, 434, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 3, 0, 0, 0)), false, "April Conn" },
                    { 4L, 2L, "Edna.Rowe@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 24, 14, 38, 9, 870, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 3, 0, 0, 0)), false, "Edna Rowe" },
                    { 5L, 8L, "Jonathan.Kautzer72@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 22, 17, 20, 59, 92, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 2, 0, 0, 0)), false, "Jonathan Kautzer" },
                    { 6L, 7L, "Clayton_Leannon@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 10, 17, 17, 33, 787, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 2, 0, 0, 0)), false, "Clayton Leannon" },
                    { 7L, 8L, "Carmen_Nicolas2@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 16, 18, 7, 2, 189, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 2, 0, 0, 0)), false, "Carmen Nicolas" },
                    { 8L, 8L, "Pauline_Lehner2@gmail.com", new DateTimeOffset(new DateTime(2023, 6, 4, 21, 21, 27, 915, DateTimeKind.Unspecified).AddTicks(379), new TimeSpan(0, 3, 0, 0, 0)), false, "Pauline Lehner" },
                    { 9L, 2L, "Juana.Lynch84@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 26, 6, 9, 4, 83, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 3, 0, 0, 0)), false, "Juana Lynch" },
                    { 10L, 2L, "Louise79@yahoo.com", new DateTimeOffset(new DateTime(2022, 8, 22, 0, 29, 58, 744, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 3, 0, 0, 0)), false, "Louise Hettinger" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "Text" },
                values: new object[,]
                {
                    { 1L, 9L, false, "Voluptatem voluptatem a rem voluptatem alias est dolorem quisquam. Veniam voluptatum reiciendis earum. Aliquam pariatur qui dolorem cupiditate officia corrupti. Laboriosam est ab reiciendis libero voluptatem sint. Eos magni quam voluptatem tenetur fugit quia pariatur." },
                    { 2L, 9L, false, "Hic voluptas earum. Qui velit corporis. Consequatur unde ut mollitia quia. Excepturi et atque qui iusto non et earum. Voluptatem magnam ea aut magnam error hic repudiandae." },
                    { 3L, 1L, false, "Omnis non omnis. Laudantium modi labore autem odit natus nobis enim. Quis ut architecto aut veritatis veritatis quo et consequatur." },
                    { 4L, 1L, false, "utAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 5L, 6L, false, "Molestias ducimus cupiditate vel aliquam voluptatem laboriosam molestias placeat. Nesciunt et dolore. Accusamus dolore odio omnis. Deserunt cum cumque nisi. Sunt voluptas illo." },
                    { 6L, 8L, false, "Non quam non nisi voluptas voluptatem unde numquam." },
                    { 7L, 2L, false, "Consequatur minima est reiciendis. Illum est assumenda quo quam molestiae consequatur nemo ad minima. Fugiat ut dicta nihil ullam quia blanditiis sint. Id nihil voluptatem perspiciatis quis illum. Sint blanditiis et aut assumenda sit consequatur. Maxime odio nihil fuga veritatis." },
                    { 8L, 7L, false, "Dolor consequatur aut. Nobis repellendus reprehenderit incidunt. Voluptates eligendi rerum quaerat corrupti rerum quasi vitae animi corporis. Magnam et dolorem. Itaque exercitationem rerum sequi. Inventore omnis ea modi officia mollitia." },
                    { 9L, 10L, false, "fugaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 10L, 2L, false, "recusandaeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 5 },
                    { 2L, 2L, false, 2L, 2 }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 3L, 3L, false, 3L, 8 },
                    { 4L, 4L, false, 4L, 4 },
                    { 5L, 5L, false, 5L, 10 },
                    { 6L, 6L, false, 6L, 6 },
                    { 7L, 7L, false, 7L, 4 },
                    { 8L, 8L, false, 8L, 2 },
                    { 9L, 9L, false, 9L, 1 },
                    { 10L, 10L, false, 10L, 6 }
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

            migrationBuilder.InsertData(
                table: "ExternalAttendeeAvailabilities",
                columns: new[] { "Id", "EndEvent", "ExternalAttendeeId", "IsDeleted", "StartEvent" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6874), new TimeSpan(0, 3, 0, 0, 0)), 10L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6867), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6884), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6912), new TimeSpan(0, 3, 0, 0, 0)), 5L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6909), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 3, 0, 0, 0)), 7L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6935), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 3, 0, 0, 0)), 7L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, new DateTimeOffset(new DateTime(2022, 8, 13, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(7015), new TimeSpan(0, 3, 0, 0, 0)), 5L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 29, 4, 885, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
