using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zaliczenie_final.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c11cf6cf-fb58-4fcc-a830-532b7e2099be", "7b3f14b5-9fea-4f81-8307-11d8c46e2caf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c11cf6cf-fb58-4fcc-a830-532b7e2099be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b3f14b5-9fea-4f81-8307-11d8c46e2caf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51b83441-d93c-44a1-8dff-feb7359f8fb7", "51b83441-d93c-44a1-8dff-feb7359f8fb7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b96d303a-acb6-4b09-bbf1-342c1241fb1d", 0, "2ce0ee10-7136-4534-858b-3e534131be53", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAEJsCGxNA+x9NTtE6Q4TVeZdwEQMz2g0XI/OM28mmG4Vv3vgEGv4qe2jPXI0aVIgU4A==", null, false, "63538c7a-01ab-4649-bea0-22b6d906b62a", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51b83441-d93c-44a1-8dff-feb7359f8fb7", "b96d303a-acb6-4b09-bbf1-342c1241fb1d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51b83441-d93c-44a1-8dff-feb7359f8fb7", "b96d303a-acb6-4b09-bbf1-342c1241fb1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51b83441-d93c-44a1-8dff-feb7359f8fb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b96d303a-acb6-4b09-bbf1-342c1241fb1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c11cf6cf-fb58-4fcc-a830-532b7e2099be", "c11cf6cf-fb58-4fcc-a830-532b7e2099be", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b3f14b5-9fea-4f81-8307-11d8c46e2caf", 0, "f84b3ae9-6478-4a99-a29a-4fdcad62bdac", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAEGUCfJVz+MWEgGJ4QW53SrDeMV5pYhbMkhxN0RLmw09syBZYtF/wzZ9NG4/eFc4AMA==", null, false, "ba581100-eee3-4f55-9ae3-c697368dc78c", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c11cf6cf-fb58-4fcc-a830-532b7e2099be", "7b3f14b5-9fea-4f81-8307-11d8c46e2caf" });
        }
    }
}
