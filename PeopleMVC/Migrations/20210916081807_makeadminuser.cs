using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleMVC.Migrations
{
    public partial class makeadminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                column: "ConcurrencyStamp",
                value: "a7c40389-6bbb-4ef0-b5b7-7cb5bb7f98dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0948bea6-fb82-49c9-8cd8-fec213fe8e8a", "722fc4c2-dd40-4943-83dd-cf9a84ac692d", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ce8a888-ad60-493f-a351-4fb416b81284",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 9, 16, 10, 18, 6, 919, DateTimeKind.Local).AddTicks(7807), "30c6799b-2288-44af-8993-123d0f98db9d", "AQAAAAEAACcQAAAAEJA4mYqR6sMHeiAZliEv6txIHfC0G6LxPoS9DwN3/sQg0VjHEAg5g5J6ImXa1rnNuw==", "5cb4d37a-9432-4013-99aa-7faa1bab5d49" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6ce8a888-ad60-493f-a351-4fb416b81284", "0948bea6-fb82-49c9-8cd8-fec213fe8e8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ce8a888-ad60-493f-a351-4fb416b81284", "0948bea6-fb82-49c9-8cd8-fec213fe8e8a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0948bea6-fb82-49c9-8cd8-fec213fe8e8a");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                column: "ConcurrencyStamp",
                value: "4ca502b3-0b10-46ee-b71a-9eac718d209e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ce8a888-ad60-493f-a351-4fb416b81284",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 59, 47, 309, DateTimeKind.Local).AddTicks(4774), "09ecf7d4-a84f-4f62-95fa-cb6810c27eaa", "AQAAAAEAACcQAAAAEGXaHcDMiEKDBhovcw5Pbv2oIQWt6IlyeedLvdq6EpbaAjByhOFuxDvIzSNx+KNjlQ==", "08cd9810-5990-4ef8-85ca-089658843a69" });
        }
    }
}
