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
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), false, "Zoom", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), false, "GoogleMeet", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), false, "Discord", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), false, "Skype", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), false, "Slack", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LogoPath", "Name", "PageLink", "TimeZone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 10, 0, 41, 16, 96, DateTimeKind.Unspecified).AddTicks(227), "sint", false, "", "Goyette, Conn and Morissette", "https://rasheed.org", "Pacific/F", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2021, 4, 25, 12, 58, 54, 935, DateTimeKind.Unspecified).AddTicks(5911), "ipsam", false, "", "Gleichner - Murazik", "https://tierra.net", "America/S", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2020, 2, 26, 17, 33, 25, 653, DateTimeKind.Unspecified).AddTicks(9785), "Voluptas consequatur beatae placeat praesentium est et sed ex.\nQuis alias est qui esse ea nihil.\nEaque perspiciatis dolore ut.\nEst iste quo.\nQuia nihil facere aut iste voluptatem est ut nulla non.\nDolor veritatis quo illo et esse pariatur alias ipsum.", false, "", "Predovic Group", "http://una.info", "Europe/He", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2020, 7, 16, 16, 12, 27, 391, DateTimeKind.Unspecified).AddTicks(9825), "Dolorem consequatur asperiores eligendi explicabo voluptas alias odio et id.\nMinima mollitia ut quasi aut ea culpa.\nLibero quibusdam similique maiores beatae qui.\nDolores sed quia voluptatum sapiente.\nConsectetur ab corporis illo explicabo alias.", false, "", "Orn, Kuphal and Paucek", "https://elouise.org", "Europe/Co", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2020, 4, 22, 7, 50, 5, 468, DateTimeKind.Unspecified).AddTicks(889), "Voluptatem quaerat doloribus ad quo.", false, "", "Predovic - Jacobson", "https://unique.org", "Asia/Toky", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2021, 2, 24, 23, 51, 22, 330, DateTimeKind.Unspecified).AddTicks(5861), "Quisquam a voluptatem modi aut dolores et et fugit et. Qui maiores totam incidunt illo. Qui dolores quae accusantium amet non beatae harum est.", false, "", "Gulgowski Inc", "http://reyna.biz", "Europe/Br", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2019, 8, 8, 0, 36, 54, 303, DateTimeKind.Unspecified).AddTicks(6587), "quisquam", false, "", "Daugherty - Schumm", "https://devante.name", "Asia/Kolk", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2021, 6, 10, 17, 22, 50, 244, DateTimeKind.Unspecified).AddTicks(4235), "Odio et illum explicabo accusantium.", false, "", "Spinka LLC", "https://kathleen.biz", "America/I", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2021, 5, 2, 16, 29, 0, 178, DateTimeKind.Unspecified).AddTicks(2019), "Voluptates impedit molestiae. Ut explicabo amet. Qui ratione quasi error consequatur.", false, "", "Marvin - Kulas", "http://kaylee.name", "Pacific/A", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2019, 8, 1, 2, 2, 19, 77, DateTimeKind.Unspecified).AddTicks(8910), "Aut quis sed et facilis iste.", false, "", "Strosin - Weimann", "https://mia.net", "Pacific/P", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Country", "CreatedAt", "Email", "ImagePath", "IsBanned", "IsDeleted", "Name", "PhoneNumber", "TimeZone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 6, 23, 5, 44, 52, 949, DateTimeKind.Unspecified).AddTicks(4934), "Roland18@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/519.jpg", false, false, "Roland Cronin", "935-530-15", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, null, new DateTime(2021, 1, 22, 22, 58, 16, 103, DateTimeKind.Unspecified).AddTicks(8827), "Lloyd95@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/478.jpg", false, false, "Lloyd Bosco", "(900) 987-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, null, new DateTime(2019, 10, 14, 21, 31, 30, 196, DateTimeKind.Unspecified).AddTicks(7952), "Lamar25@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/289.jpg", false, false, "Lamar Greenfelder", "821.852.81", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, null, new DateTime(2020, 9, 28, 10, 16, 48, 231, DateTimeKind.Unspecified).AddTicks(1501), "Jermaine.Runte71@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1001.jpg", false, false, "Jermaine Runte", "(656) 612-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, null, new DateTime(2020, 12, 13, 23, 25, 10, 811, DateTimeKind.Unspecified).AddTicks(2115), "Cory_Schamberger@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", false, false, "Cory Schamberger", "212-739-35", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, null, new DateTime(2020, 12, 15, 10, 50, 20, 724, DateTimeKind.Unspecified).AddTicks(7026), "Sonya.Goodwin@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/572.jpg", false, false, "Sonya Goodwin", "930-573-65", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, null, new DateTime(2019, 11, 13, 8, 31, 30, 516, DateTimeKind.Unspecified).AddTicks(7436), "Alex_Waelchi@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/973.jpg", false, false, "Alex Waelchi", "1-231-579-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, null, new DateTime(2021, 3, 15, 17, 34, 6, 145, DateTimeKind.Unspecified).AddTicks(8434), "Dave69@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/534.jpg", false, false, "Dave Towne", "1-977-328-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, null, new DateTime(2020, 7, 18, 16, 58, 0, 712, DateTimeKind.Unspecified).AddTicks(2890), "Albert.Lueilwitz@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", false, false, "Albert Lueilwitz", "(654) 365-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, null, new DateTime(2019, 8, 7, 10, 50, 55, 858, DateTimeKind.Unspecified).AddTicks(3832), "Mandy23@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/959.jpg", false, false, "Mandy Connelly", "(979) 393-", null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "AvailabilitySlots",
                columns: new[] { "Id", "AdvancedSlotSettingsId", "CreatedAt", "CreatedBy", "Description", "Frequency", "IsDeleted", "IsEnabled", "IsVisible", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 2, 27, 6, 16, 49, 225, DateTimeKind.Unspecified).AddTicks(3627), 1, "Est dolorem voluptatum nam magnam necessitatibus necessitatibus velit sapiente. Numquam deleniti sapiente aut sunt omnis laboriosam quaerat quisquam. Consequatur nam laborum. Quas voluptatibus quidem ut.", 20, false, true, true, "http://alanis.info", 4, "quaerat", 46, 10, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 2, new DateTime(2020, 7, 12, 9, 9, 3, 32, DateTimeKind.Unspecified).AddTicks(8892), 2, "Omnis reiciendis ex debitis vitae consequuntur ratione.", 21, false, true, true, "http://katelin.biz", 1, "consequuntur", 52, 8, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 3, new DateTime(2020, 9, 4, 20, 26, 30, 130, DateTimeKind.Unspecified).AddTicks(21), 3, "Cum unde ab soluta architecto vel facere rerum.", 30, false, true, true, "https://maia.name", 5, "harum", 19, 5, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 4, new DateTime(2020, 3, 14, 0, 24, 53, 924, DateTimeKind.Unspecified).AddTicks(957), 4, "Aliquam sunt voluptate aliquid omnis consectetur cupiditate non dicta.", 21, false, true, true, "https://deshawn.net", 2, "repellat", 19, 2, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 5, new DateTime(2020, 2, 20, 15, 49, 22, 526, DateTimeKind.Unspecified).AddTicks(7902), 5, "Corporis quas est deserunt consequatur fugiat et laborum. Rerum autem veniam tenetur. Et reiciendis vel. Eligendi odio est saepe accusamus dolores est alias.", 26, false, true, true, "http://tabitha.name", 5, "dolore", 36, 1, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 6, new DateTime(2019, 7, 30, 10, 48, 47, 133, DateTimeKind.Unspecified).AddTicks(1606), 6, "cupiditate", 15, false, true, true, "https://lonnie.net", 4, "veniam", 38, 9, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 7, new DateTime(2019, 12, 27, 15, 48, 50, 850, DateTimeKind.Unspecified).AddTicks(1048), 7, "Voluptas saepe id rerum et iure.", 15, false, true, true, "https://kamren.info", 3, "velit", 16, 1, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 8, new DateTime(2020, 12, 22, 21, 44, 28, 932, DateTimeKind.Unspecified).AddTicks(8776), 8, "ipsa", 19, false, true, true, "http://cristian.info", 3, "sit", 17, 4, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 9, new DateTime(2020, 3, 12, 10, 18, 28, 53, DateTimeKind.Unspecified).AddTicks(5772), 9, "Cumque eligendi sint iste doloribus perferendis qui.", 16, false, true, true, "http://cassidy.com", 5, "eveniet", 45, 8, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 10, new DateTime(2020, 3, 12, 14, 49, 18, 611, DateTimeKind.Unspecified).AddTicks(9808), 10, "Vel id dolor labore facilis unde praesentium et.", 19, false, true, true, "https://otilia.com", 1, "ullam", 34, 5, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "AddEventsFromTeamId", "CheckForConflicts", "CreatedAt", "CreatedBy", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 4, false, new DateTime(2019, 12, 19, 22, 37, 39, 736, DateTimeKind.Unspecified).AddTicks(3124), 5, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 10, false, new DateTime(2020, 1, 26, 18, 17, 5, 670, DateTimeKind.Unspecified).AddTicks(7009), 6, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 2, false, new DateTime(2021, 4, 22, 19, 4, 41, 512, DateTimeKind.Unspecified).AddTicks(3024), 10, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 7, false, new DateTime(2019, 12, 29, 2, 44, 38, 463, DateTimeKind.Unspecified).AddTicks(6962), 8, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 4, false, new DateTime(2021, 6, 22, 11, 2, 13, 822, DateTimeKind.Unspecified).AddTicks(4426), 10, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 5, false, new DateTime(2020, 7, 15, 2, 57, 45, 481, DateTimeKind.Unspecified).AddTicks(6210), 2, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 7, false, new DateTime(2019, 10, 13, 0, 12, 25, 784, DateTimeKind.Unspecified).AddTicks(4207), 4, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 4, false, new DateTime(2020, 1, 26, 1, 54, 6, 412, DateTimeKind.Unspecified).AddTicks(7292), 6, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 2, false, new DateTime(2021, 6, 17, 8, 28, 10, 529, DateTimeKind.Unspecified).AddTicks(5684), 2, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 4, false, new DateTime(2019, 7, 25, 9, 11, 7, 945, DateTimeKind.Unspecified).AddTicks(5888), 3, false, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "IsDeleted", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 13, 11, 0, 56, 621, DateTimeKind.Unspecified).AddTicks(1904), 4, "eligendi", 48, false, 1, "est", new DateTime(2022, 12, 2, 11, 23, 6, 237, DateTimeKind.Local).AddTicks(1475), 8, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2020, 2, 26, 15, 17, 42, 763, DateTimeKind.Unspecified).AddTicks(3964), 1, "Quas laudantium aut accusantium est aut.", 28, false, 1, "sed", new DateTime(2022, 9, 3, 11, 51, 44, 714, DateTimeKind.Local).AddTicks(6278), 6, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2020, 10, 13, 14, 50, 29, 877, DateTimeKind.Unspecified).AddTicks(894), 5, "Ab voluptatem aut id aspernatur pariatur.", 41, false, 2, "numquam", new DateTime(2023, 7, 27, 0, 35, 44, 202, DateTimeKind.Local).AddTicks(2045), 6, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2020, 12, 1, 10, 24, 53, 195, DateTimeKind.Unspecified).AddTicks(7924), 4, "voluptatem", 47, false, 5, "asperiores", new DateTime(2023, 7, 16, 7, 43, 23, 759, DateTimeKind.Local).AddTicks(8900), 9, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2019, 7, 20, 16, 42, 9, 662, DateTimeKind.Unspecified).AddTicks(142), 2, "Est pariatur autem id minus minima consectetur lab", 31, false, 1, "aut", new DateTime(2023, 6, 30, 4, 11, 16, 551, DateTimeKind.Local).AddTicks(5465), 9, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2020, 3, 17, 18, 11, 46, 792, DateTimeKind.Unspecified).AddTicks(2028), 6, "cum", 54, false, 4, "numquam", new DateTime(2022, 9, 17, 12, 51, 35, 776, DateTimeKind.Local).AddTicks(3027), 7, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2020, 8, 5, 18, 40, 3, 149, DateTimeKind.Unspecified).AddTicks(903), 9, "Ut temporibus veritatis aut illo quia vitae et ut.", 31, false, 2, "voluptas", new DateTime(2023, 6, 21, 11, 44, 5, 350, DateTimeKind.Local).AddTicks(6482), 6, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2021, 3, 22, 8, 7, 0, 286, DateTimeKind.Unspecified).AddTicks(5203), 5, "Et consequuntur et velit et aperiam. Modi cupidita", 49, false, 2, "repudiandae", new DateTime(2022, 11, 6, 19, 50, 59, 285, DateTimeKind.Local).AddTicks(648), 6, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2020, 3, 24, 1, 30, 16, 363, DateTimeKind.Unspecified).AddTicks(3718), 9, "aliquam", 53, false, 1, "nesciunt", new DateTime(2022, 12, 25, 21, 23, 41, 667, DateTimeKind.Local).AddTicks(1795), 8, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2020, 12, 28, 2, 21, 17, 884, DateTimeKind.Unspecified).AddTicks(1792), 1, "Earum sit natus sit deleniti.\nAccusamus culpa cons", 39, false, 2, "qui", new DateTime(2022, 10, 1, 21, 42, 58, 138, DateTimeKind.Local).AddTicks(8631), 8, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamId", "UserId", "IsDeleted", "Role", "Status" },
                values: new object[,]
                {
                    { 1, 1, false, 1, 2 },
                    { 2, 2, false, 1, 2 },
                    { 3, 3, false, 2, 1 },
                    { 4, 4, false, 1, 1 },
                    { 5, 5, false, 2, 1 },
                    { 6, 6, false, 1, 1 },
                    { 7, 7, false, 1, 2 },
                    { 8, 8, false, 1, 1 },
                    { 9, 9, false, 1, 1 },
                    { 10, 10, false, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "AdvancedSlotSettings",
                columns: new[] { "Id", "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "CreatedAt", "Days", "EndDate", "IsDeleted", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, 5, 7, new DateTime(2020, 8, 21, 22, 30, 20, 675, DateTimeKind.Unspecified).AddTicks(577), 28, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 6, 13, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 3, 2, 4, 2, new DateTime(2020, 9, 21, 6, 28, 58, 873, DateTimeKind.Unspecified).AddTicks(9237), 21, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 9, 3, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 2, 3, 1, 7, new DateTime(2021, 6, 21, 15, 24, 1, 196, DateTimeKind.Unspecified).AddTicks(7083), 6, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 1, 10, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 1, 4, 3, 5, new DateTime(2019, 12, 27, 5, 34, 33, 193, DateTimeKind.Unspecified).AddTicks(9415), 22, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 3, 13, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 2, 5, 3, 5, new DateTime(2021, 2, 15, 20, 33, 10, 559, DateTimeKind.Unspecified).AddTicks(1966), 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 10, 2, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 1, 6, 1, 7, new DateTime(2019, 11, 20, 18, 10, 46, 663, DateTimeKind.Unspecified).AddTicks(2002), 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 2, 7, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 3, 7, 4, 2, new DateTime(2019, 12, 27, 18, 46, 36, 775, DateTimeKind.Unspecified).AddTicks(3384), 30, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 7, 13, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 1, 8, 5, 6, new DateTime(2019, 11, 4, 13, 54, 43, 796, DateTimeKind.Unspecified).AddTicks(7269), 14, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 1, 9, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 1, 9, 4, 8, new DateTime(2021, 2, 14, 5, 19, 54, 202, DateTimeKind.Unspecified).AddTicks(8710), 24, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 4, 5, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 3, 10, 2, 2, new DateTime(2020, 4, 7, 2, 31, 59, 931, DateTimeKind.Unspecified).AddTicks(9036), 9, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 2, 5, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "CalendarVisibleForTeams",
                columns: new[] { "CalendarId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ExternalAttendees",
                columns: new[] { "Id", "AvailabilitySlotId", "CreatedAt", "Email", "EventTime", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2019, 9, 3, 14, 43, 30, 238, DateTimeKind.Unspecified).AddTicks(6616), "Elmer_Stoltenberg@gmail.com", new DateTime(2023, 7, 30, 4, 51, 32, 518, DateTimeKind.Local).AddTicks(8599), false, "Elmer Stoltenberg", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 5, new DateTime(2021, 1, 4, 9, 41, 49, 928, DateTimeKind.Unspecified).AddTicks(8796), "Oliver.Douglas@yahoo.com", new DateTime(2023, 6, 2, 3, 8, 43, 854, DateTimeKind.Local).AddTicks(5035), false, "Oliver Douglas", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 6, new DateTime(2021, 3, 10, 6, 28, 44, 592, DateTimeKind.Unspecified).AddTicks(9213), "Kari_Dare@yahoo.com", new DateTime(2022, 8, 18, 7, 47, 55, 673, DateTimeKind.Local).AddTicks(682), false, "Kari Dare", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 7, new DateTime(2020, 1, 24, 0, 51, 37, 490, DateTimeKind.Unspecified).AddTicks(4812), "Conrad16@yahoo.com", new DateTime(2022, 9, 30, 12, 54, 13, 533, DateTimeKind.Local).AddTicks(2043), false, "Conrad Powlowski", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 7, new DateTime(2020, 5, 7, 14, 3, 9, 172, DateTimeKind.Unspecified).AddTicks(1537), "Cristina0@yahoo.com", new DateTime(2022, 9, 2, 14, 20, 42, 13, DateTimeKind.Local).AddTicks(688), false, "Cristina Donnelly", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 6, new DateTime(2020, 11, 4, 2, 50, 24, 988, DateTimeKind.Unspecified).AddTicks(6986), "Misty.Considine@yahoo.com", new DateTime(2023, 3, 17, 5, 14, 32, 939, DateTimeKind.Local).AddTicks(7356), false, "Misty Considine", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 8, new DateTime(2020, 7, 18, 13, 28, 14, 916, DateTimeKind.Unspecified).AddTicks(5594), "Anne46@hotmail.com", new DateTime(2023, 6, 27, 17, 59, 4, 387, DateTimeKind.Local).AddTicks(7558), false, "Anne Haag", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 4, new DateTime(2021, 2, 12, 4, 21, 57, 48, DateTimeKind.Unspecified).AddTicks(181), "Lance_Ryan@yahoo.com", new DateTime(2023, 1, 12, 13, 20, 16, 285, DateTimeKind.Local).AddTicks(1469), false, "Lance Ryan", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 8, new DateTime(2020, 7, 20, 0, 14, 51, 767, DateTimeKind.Unspecified).AddTicks(1211), "Cory96@gmail.com", new DateTime(2022, 8, 16, 0, 31, 17, 767, DateTimeKind.Local).AddTicks(2907), false, "Cory Cormier", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 7, new DateTime(2021, 6, 10, 20, 46, 25, 33, DateTimeKind.Unspecified).AddTicks(2382), "Marsha80@yahoo.com", new DateTime(2023, 6, 23, 18, 48, 16, 949, DateTimeKind.Local).AddTicks(8450), false, "Marsha Bernhard", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AvailabilitySlotId", "CreatedAt", "IsDeleted", "Text", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2019, 12, 1, 19, 15, 1, 760, DateTimeKind.Unspecified).AddTicks(3290), false, "Facere quibusdam quam animi explicabo voluptatem porro quo harum quasi. Tempora consequatur ex adipisci animi. Pariatur ut voluptatibus deleniti ratione ut velit animi.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 1, new DateTime(2021, 1, 19, 4, 56, 38, 48, DateTimeKind.Unspecified).AddTicks(3172), false, "Illo ut commodi sunt odit a minus magni asperiores saepe.\nSint quo vel.\nEveniet natus et ab nihil.\nImpedit quo expedita dolorem ullam officia impedit.\nMaiores reiciendis ut non fugit.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 5, new DateTime(2021, 4, 12, 22, 23, 15, 699, DateTimeKind.Unspecified).AddTicks(2476), false, "Modi iste autem tempore quod similique enim beatae ullam. Voluptatem voluptatem similique incidunt animi qui saepe quis quisquam qui. Et quibusdam quam alias omnis debitis et facere veritatis. Aut eaque sed.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 7, new DateTime(2019, 11, 9, 0, 41, 30, 571, DateTimeKind.Unspecified).AddTicks(8882), false, "mollitiaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 8, new DateTime(2020, 4, 14, 22, 28, 53, 761, DateTimeKind.Unspecified).AddTicks(1121), false, "mollitiaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 2, new DateTime(2020, 10, 24, 2, 9, 18, 694, DateTimeKind.Unspecified).AddTicks(3264), false, "At deleniti veniam et cupiditate quis blanditiis veniam.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 9, new DateTime(2020, 12, 24, 3, 10, 3, 106, DateTimeKind.Unspecified).AddTicks(1802), false, "praesentiumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 1, new DateTime(2019, 9, 3, 1, 56, 8, 978, DateTimeKind.Unspecified).AddTicks(6797), false, "Et quis ut et eaque non at velit.AAAAAAAAAAAAAAAAA", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 1, new DateTime(2020, 3, 27, 4, 32, 41, 957, DateTimeKind.Unspecified).AddTicks(425), false, "Temporibus sit placeat.\nTenetur neque aut.\nMaxime soluta rem laborum occaecati est magni magni sed.\nVoluptas et dolor vel excepturi fuga.\nModi et voluptatibus laboriosam rerum.\nQui error magni neque deserunt.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 3, new DateTime(2020, 9, 7, 21, 35, 9, 694, DateTimeKind.Unspecified).AddTicks(4231), false, "Sit voluptatibus quasi soluta.\nQuis et quae blanditiis et.\nNulla est voluptate ratione corrupti sed accusantium.", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "EventId", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "EventId", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 3, 3, 8 },
                    { 4, 4, 7 },
                    { 5, 5, 9 },
                    { 6, 6, 4 },
                    { 7, 7, 5 },
                    { 8, 8, 8 },
                    { 9, 9, 5 },
                    { 10, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserSlot",
                columns: new[] { "AvailabilitySlotId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ExternalAttendeeAvailabilities",
                columns: new[] { "Id", "CreatedAt", "EndEvent", "ExternalAttendeeId", "IsDeleted", "StartEvent", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 2, 19, 9, 53, 45, 739, DateTimeKind.Unspecified).AddTicks(6938), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4047), 5, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(3893), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2019, 12, 15, 9, 59, 5, 607, DateTimeKind.Unspecified).AddTicks(1712), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4481), 9, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2020, 10, 2, 10, 33, 49, 254, DateTimeKind.Unspecified).AddTicks(9316), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4534), 10, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4527), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2020, 8, 22, 18, 58, 16, 368, DateTimeKind.Unspecified).AddTicks(8388), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4579), 1, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4572), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2021, 7, 1, 17, 36, 36, 340, DateTimeKind.Unspecified).AddTicks(6551), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4628), 7, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4621), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2020, 11, 26, 11, 37, 4, 953, DateTimeKind.Unspecified).AddTicks(7648), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4678), 2, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4672), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2020, 12, 27, 9, 30, 59, 184, DateTimeKind.Unspecified).AddTicks(7561), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4706), 2, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2021, 2, 5, 20, 24, 10, 500, DateTimeKind.Unspecified).AddTicks(7399), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4739), 3, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4726), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2021, 3, 4, 10, 37, 50, 485, DateTimeKind.Unspecified).AddTicks(614), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4773), 5, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4766), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2019, 9, 2, 21, 29, 34, 924, DateTimeKind.Unspecified).AddTicks(2060), new DateTime(2022, 8, 11, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4799), 10, false, new DateTime(2022, 8, 10, 19, 59, 11, 90, DateTimeKind.Local).AddTicks(4793), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumns: new[] { "CalendarId", "TeamId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumns: new[] { "EventId", "MemberId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumns: new[] { "AvailabilitySlotId", "UserId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
