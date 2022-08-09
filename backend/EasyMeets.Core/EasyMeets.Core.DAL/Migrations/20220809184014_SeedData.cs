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
                    { 1L, "Libero qui necessitatibus natus asperiores et incidunt ea optio sit.", false, "", "Mills - Nader", "http://jettie.org", "Europe/So" },
                    { 2L, "Commodi voluptatum officiis repellat atque sunt. Omnis doloremque fuga provident ullam. Aspernatur qui magnam sit dolores aliquid quae dolore dicta. Corrupti alias maxime cupiditate aliquam tempora accusamus. Est et ex harum hic ipsam quia at ab maxime. Sint laborum repellat rem perspiciatis tempor", false, "", "Grady - Wilkinson", "https://jacquelyn.com", "Asia/Kual" },
                    { 3L, "Nemo sapiente odio ipsa.\nIllum reprehenderit autem ab quam consectetur omnis.", false, "", "Klocko - Wintheiser", "https://leta.info", "Asia/Toky" },
                    { 4L, "Voluptatibus exercitationem voluptas. Ut consequatur qui sequi sit adipisci. Iusto repellat alias ipsum esse deserunt quis. Voluptas voluptatem rerum doloribus libero nemo neque enim voluptatem. Iusto quo natus et.", false, "", "Lebsack, Krajcik and Cartwright", "https://sabrina.org", "Pacific/N" },
                    { 5L, "Voluptatem laboriosam dolore.\nVeritatis ipsam nisi qui.", false, "", "Kessler, Rowe and Walker", "http://janessa.org", "Asia/Maga" },
                    { 6L, "dolore", false, "", "McDermott, Luettgen and Berge", "http://carter.biz", "Australia" },
                    { 7L, "Mollitia est vitae.", false, "", "Zulauf Inc", "http://danny.biz", "America/J" },
                    { 8L, "Vel non totam ipsa est enim ut.\nRerum maxime tempora repellat et corrupti.\nDicta possimus labore consequatur natus sunt.\nDicta sed omnis porro aspernatur.\nNam a quia aut illo corporis itaque cumque occaecati eius.", false, "", "Mertz Group", "http://ayla.biz", "Europe/Be" },
                    { 9L, "rerum", false, "", "Olson Inc", "https://henriette.info", "Atlantic/" },
                    { 10L, "Iure aut neque voluptatem voluptas.", false, "", "Morar - Koepp", "https://otis.com", "Pacific/A" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Country", "Email", "ImagePath", "IsBanned", "IsDeleted", "Name", "PhoneNumber", "TimeZone" },
                values: new object[,]
                {
                    { 1L, null, "Doug58@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", false, false, "Doug Baumbach", "568-425-13", null },
                    { 2L, null, "Noah2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/597.jpg", false, false, "Noah Swift", "394-517-52", null },
                    { 3L, null, "Rebecca.Robel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1144.jpg", false, false, "Rebecca Robel", "(895) 358-", null },
                    { 4L, null, "Albert.Swaniawski76@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/216.jpg", false, false, "Albert Swaniawski", "326-405-30", null },
                    { 5L, null, "Gertrude92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", false, false, "Gertrude Koch", "1-450-952-", null },
                    { 6L, null, "Jacob_Boyer@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/608.jpg", false, false, "Jacob Boyer", "811-396-49", null },
                    { 7L, null, "Kay_Hilll76@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", false, false, "Kay Hilll", "1-614-740-", null },
                    { 8L, null, "Ruben38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1025.jpg", false, false, "Ruben Monahan", "851.634.09", null },
                    { 9L, null, "Carrie.Morar@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/606.jpg", false, false, "Carrie Morar", "1-412-529-", null },
                    { 10L, null, "Devin75@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", false, false, "Devin Cremin", "1-358-591-", null }
                });

            migrationBuilder.InsertData(
                table: "AvailabilitySlots",
                columns: new[] { "Id", "AdvancedSlotSettingsId", "CreatedAt", "CreatedBy", "Description", "Frequency", "IsDeleted", "IsEnabled", "IsVisible", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2020, 9, 26, 5, 27, 18, 157, DateTimeKind.Unspecified).AddTicks(5561), 1L, "Error illo debitis ad.", 24, false, true, true, "https://keanu.net", 2L, "quidem", 45, 5L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, 2L, new DateTime(2019, 9, 28, 1, 32, 23, 12, DateTimeKind.Unspecified).AddTicks(816), 2L, "Recusandae quo quis voluptatem porro sed aut non. Recusandae recusandae minus et qui ea asperiores laborum assumenda. Architecto eum quam cumque atque facilis sequi eveniet et.", 30, false, true, true, "http://leslie.name", 1L, "harum", 44, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, 3L, new DateTime(2020, 11, 30, 1, 19, 20, 330, DateTimeKind.Unspecified).AddTicks(9269), 3L, "Et optio dolores eos. Provident nobis omnis porro ipsam. Atque deleniti officiis et consectetur consequuntur.", 24, false, true, true, "https://fredy.name", 2L, "beatae", 41, 10L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, 4L, new DateTime(2019, 8, 1, 22, 11, 4, 409, DateTimeKind.Unspecified).AddTicks(8771), 4L, "Rerum cupiditate eos eligendi sunt laboriosam consectetur non.\nQuas et omnis quia et autem consectetur dolore modi fugiat.\nNatus pariatur voluptatem corporis repellendus ut esse rem quo omnis.\nCorporis ea non officiis molestiae doloribus.", 26, false, true, true, "http://liam.name", 1L, "quis", 42, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, 5L, new DateTime(2021, 2, 25, 2, 10, 57, 920, DateTimeKind.Unspecified).AddTicks(8269), 5L, "Similique est exercitationem maxime quidem dignissimos sed animi ex.", 18, false, true, true, "https://lewis.name", 3L, "nesciunt", 26, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, 6L, new DateTime(2021, 1, 31, 17, 59, 39, 329, DateTimeKind.Unspecified).AddTicks(1926), 6L, "Non tempore rem impedit sint enim sed. Praesentium et quia blanditiis repellendus omnis iure vitae numquam eos. Ut voluptas maiores magnam cumque et consequatur eveniet. Doloribus sit blanditiis aspernatur perferendis ut consequatur.", 19, false, true, true, "https://kamron.org", 1L, "illum", 45, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, 7L, new DateTime(2021, 4, 17, 7, 10, 24, 17, DateTimeKind.Unspecified).AddTicks(7483), 7L, "Nostrum et fugiat consequatur qui.", 21, false, true, true, "https://willis.name", 3L, "voluptatem", 49, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, 8L, new DateTime(2020, 2, 6, 21, 17, 2, 453, DateTimeKind.Unspecified).AddTicks(5646), 8L, "Sapiente nemo dolor natus voluptatem sed. Iusto sint omnis est. Dolor ut dolores.", 20, false, true, true, "http://dangelo.biz", 4L, "esse", 20, 9L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, 9L, new DateTime(2019, 12, 28, 3, 1, 39, 366, DateTimeKind.Unspecified).AddTicks(7434), 9L, "Rerum magni quisquam nemo nostrum alias. Eum tempora velit sed est quo hic et incidunt magnam. Et deleniti non tenetur aut voluptas qui quisquam.", 15, false, true, true, "http://nathanael.net", 1L, "consequatur", 26, 9L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, 10L, new DateTime(2020, 1, 24, 14, 14, 2, 827, DateTimeKind.Unspecified).AddTicks(8613), 10L, "Minus nemo aut vel minus corrupti est porro pariatur.\nAdipisci aut similique nesciunt optio necessitatibus magni sed mollitia suscipit.\nMolestiae ut aut nemo excepturi.\nMinus harum ex nostrum eum minima omnis est voluptas dolor.\nNeque officia perferendis.\nAccusamus cupiditate dolorem.", 19, false, true, true, "https://maurice.biz", 3L, "delectus", 23, 9L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "AddEventsFromTeamId", "CheckForConflicts", "CreatedAt", "CreatedBy", "IsDeleted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 3L, false, new DateTime(2020, 8, 23, 11, 46, 20, 777, DateTimeKind.Unspecified).AddTicks(5827), 8L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L },
                    { 2L, 6L, false, new DateTime(2021, 1, 15, 0, 4, 3, 195, DateTimeKind.Unspecified).AddTicks(7388), 7L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L },
                    { 3L, 5L, false, new DateTime(2020, 4, 27, 16, 33, 11, 97, DateTimeKind.Unspecified).AddTicks(4093), 6L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 4L, 6L, false, new DateTime(2020, 12, 4, 5, 48, 35, 934, DateTimeKind.Unspecified).AddTicks(3481), 1L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L },
                    { 5L, 6L, false, new DateTime(2020, 12, 9, 20, 28, 38, 929, DateTimeKind.Unspecified).AddTicks(1135), 6L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L },
                    { 6L, 5L, false, new DateTime(2020, 7, 5, 4, 14, 22, 105, DateTimeKind.Unspecified).AddTicks(486), 5L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 7L, 5L, false, new DateTime(2021, 3, 27, 21, 55, 40, 731, DateTimeKind.Unspecified).AddTicks(8064), 5L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 7L },
                    { 8L, 4L, false, new DateTime(2021, 6, 28, 23, 11, 11, 146, DateTimeKind.Unspecified).AddTicks(5668), 5L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L },
                    { 9L, 1L, false, new DateTime(2020, 3, 13, 14, 26, 21, 980, DateTimeKind.Unspecified).AddTicks(4243), 10L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L },
                    { 10L, 10L, false, new DateTime(2021, 2, 13, 11, 44, 28, 980, DateTimeKind.Unspecified).AddTicks(850), 6L, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "IsDeleted", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 12, 13, 19, 46, 11, 190, DateTimeKind.Unspecified).AddTicks(7247), 6L, "Odit reiciendis nisi possimus repudiandae inventor", 25, false, 2L, "ipsa", new DateTimeOffset(new DateTime(2022, 9, 22, 16, 31, 9, 6, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2019, 11, 13, 9, 35, 44, 572, DateTimeKind.Unspecified).AddTicks(3426), 8L, "Cum enim dolore. Alias aut ab ut enim ipsam ducimu", 44, false, 1L, "id", new DateTimeOffset(new DateTime(2023, 7, 18, 8, 51, 11, 39, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2020, 6, 5, 18, 23, 19, 420, DateTimeKind.Unspecified).AddTicks(7301), 4L, "Fuga aliquid cupiditate nisi similique. Cupiditate", 50, false, 1L, "et", new DateTimeOffset(new DateTime(2022, 11, 4, 1, 55, 10, 764, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, new DateTime(2019, 11, 22, 19, 5, 9, 840, DateTimeKind.Unspecified).AddTicks(6975), 3L, "Asperiores omnis dicta distinctio non ex est.", 18, false, 3L, "vel", new DateTimeOffset(new DateTime(2023, 4, 20, 20, 34, 39, 697, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, new DateTime(2021, 2, 8, 22, 8, 2, 324, DateTimeKind.Unspecified).AddTicks(6597), 3L, "Molestiae nostrum temporibus fugiat placeat libero", 13, false, 4L, "inventore", new DateTimeOffset(new DateTime(2023, 4, 11, 0, 42, 23, 833, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, new DateTime(2020, 8, 5, 18, 13, 10, 719, DateTimeKind.Unspecified).AddTicks(55), 1L, "Voluptatum molestias quia minima quisquam vero vel", 30, false, 3L, "animi", new DateTimeOffset(new DateTime(2022, 11, 13, 21, 28, 49, 587, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, new DateTime(2019, 10, 9, 10, 14, 27, 974, DateTimeKind.Unspecified).AddTicks(7923), 4L, "consequatur", 19, false, 3L, "at", new DateTimeOffset(new DateTime(2023, 4, 7, 16, 13, 54, 47, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, new DateTime(2020, 2, 12, 23, 29, 12, 644, DateTimeKind.Unspecified).AddTicks(2012), 9L, "Eos quod amet sed in vero. Saepe dolorum natus sed", 21, false, 4L, "quo", new DateTimeOffset(new DateTime(2023, 4, 1, 2, 9, 59, 784, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, new DateTime(2019, 8, 12, 4, 11, 0, 561, DateTimeKind.Unspecified).AddTicks(1866), 3L, "nihil", 44, false, 2L, "omnis", new DateTimeOffset(new DateTime(2022, 12, 29, 14, 50, 29, 995, DateTimeKind.Unspecified).AddTicks(3372), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, new DateTime(2021, 3, 17, 11, 24, 18, 404, DateTimeKind.Unspecified).AddTicks(497), 5L, "Doloremque laudantium aspernatur et eligendi dolor", 55, false, 4L, "doloribus", new DateTimeOffset(new DateTime(2023, 5, 6, 9, 24, 4, 350, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "IsDeleted", "Role", "Status", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1L, false, 2, 1, 1L, 1L },
                    { 2L, false, 1, 1, 2L, 2L },
                    { 3L, false, 2, 2, 3L, 3L },
                    { 4L, false, 2, 2, 4L, 4L },
                    { 5L, false, 1, 2, 5L, 5L },
                    { 6L, false, 1, 2, 6L, 6L },
                    { 7L, false, 2, 1, 7L, 7L },
                    { 8L, false, 1, 2, 8L, 8L },
                    { 9L, false, 2, 2, 9L, 9L },
                    { 10L, false, 1, 2, 10L, 10L }
                });

            migrationBuilder.InsertData(
                table: "AdvancedSlotSettings",
                columns: new[] { "Id", "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "IsDeleted", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[,]
                {
                    { 1L, 2, 1L, 2, 5, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 2, 3, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, 3, 2L, 2, 2, 26, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 6, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, 2, 3L, 1, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 2, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, 3, 4L, 1, 1, 20, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 10, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, 1, 5L, 4, 6, 11, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 7, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, 2, 6L, 5, 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 10, 4, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, 3, 7L, 4, 7, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 7, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, 1, 8L, 1, 6, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, 1, 9L, 3, 3, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 3, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, 2, 10L, 3, 5, 30, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 11, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
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
                    { 1L, 7L, "Valerie.Trantow@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 21, 8, 14, 35, 544, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 3, 0, 0, 0)), false, "Valerie Trantow" },
                    { 2L, 9L, "Amber2@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 7, 9, 31, 32, 216, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 0, 0, 0)), false, "Amber Senger" },
                    { 3L, 7L, "Ian78@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 30, 22, 46, 6, 995, DateTimeKind.Unspecified).AddTicks(9603), new TimeSpan(0, 2, 0, 0, 0)), false, "Ian Schuster" },
                    { 4L, 2L, "Jason_Mills7@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 8, 3, 28, 11, 516, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 2, 0, 0, 0)), false, "Jason Mills" },
                    { 5L, 5L, "Vanessa_Goyette@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 26, 19, 35, 52, 558, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 3, 0, 0, 0)), false, "Vanessa Goyette" },
                    { 6L, 7L, "Erica87@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 27, 8, 5, 13, 34, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 2, 0, 0, 0)), false, "Erica Marquardt" },
                    { 7L, 8L, "Johnnie.Moen@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 15, 21, 48, 5, 802, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 3, 0, 0, 0)), false, "Johnnie Moen" },
                    { 8L, 9L, "Enrique.Toy@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 7, 20, 51, 0, 184, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 2, 0, 0, 0)), false, "Enrique Toy" },
                    { 9L, 8L, "Wendy74@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 8, 23, 49, 13, 375, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 3, 0, 0, 0)), false, "Wendy Lowe" },
                    { 10L, 3L, "Chad.Bednar56@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 21, 16, 43, 57, 702, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 0, 0, 0)), false, "Chad Bednar" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "Text" },
                values: new object[,]
                {
                    { 1L, 3L, false, "Et natus iste repellat velit ratione quis.AAAAAAAA" },
                    { 2L, 2L, false, "Eos labore sint autem maiores. Sunt rerum omnis cumque harum ab voluptas. Non ullam fugit expedita tenetur." },
                    { 3L, 3L, false, "Ipsam pariatur labore eius tempore repellat unde.\nPariatur aspernatur eos voluptatem possimus.\nDolorem nisi sunt nulla." },
                    { 4L, 3L, false, "ducimusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 5L, 4L, false, "Perferendis beatae quia officiis.AAAAAAAAAAAAAAAAA" },
                    { 6L, 8L, false, "Tempora voluptatem praesentium nisi dicta quasi.\nNon aut accusantium corrupti praesentium alias nemo soluta aut et.\nMinima nulla vero maiores impedit est sunt voluptatum consequuntur.\nQuidem eaque et dolore.\nEum consectetur ipsum cumque voluptatem et deleniti labore sit iure." },
                    { 7L, 10L, false, "Et veniam consequuntur atque.\nEos maxime harum est nihil exercitationem ducimus quia veniam quae.\nEum incidunt eius sint.\nSit perspiciatis iste nobis accusamus.\nVoluptas dolores consequatur aliquid quo soluta est omnis.\nLaudantium sapiente porro dolores placeat molestiae atque quibusdam rerum." },
                    { 8L, 8L, false, "Quia iusto dolor ut.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 9L, 8L, false, "Molestiae minus ullam nemo. Sint reprehenderit incidunt et natus in nihil sint dolore laboriosam. Amet dolor debitis maxime ipsam corporis aut." },
                    { 10L, 2L, false, "Assumenda molestiae laudantium reprehenderit ea.AA" }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 9 },
                    { 2L, 2L, false, 2L, 8 }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 3L, 3L, false, 3L, 5 },
                    { 4L, 4L, false, 4L, 10 },
                    { 5L, 5L, false, 5L, 9 },
                    { 6L, 6L, false, 6L, 3 },
                    { 7L, 7L, false, 7L, 1 },
                    { 8L, 8L, false, 8L, 7 },
                    { 9L, 9L, false, 9L, 10 },
                    { 10L, 10L, false, 10L, 7 }
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
                    { 1L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 3, 0, 0, 0)), 10L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(6927), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)), 1L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 3, 0, 0, 0)), 8L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 0, 0, 0)) }
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
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L);

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
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L);

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
                keyValue: 1L);

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
                keyValue: 8L);

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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

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
                keyValue: 6L);

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
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L);

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
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L);
        }
    }
}
