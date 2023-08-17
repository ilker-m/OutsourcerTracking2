using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Weight_Kg",
                table: "Trackings",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Receives",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Receives",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "OutsourceWorkOrders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "OutsourceWorkOrders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "OutsourceWorkOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorCode", "ColorName", "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { "ColorCode", "Color Name", new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6bbc03c6-7572-470e-beb4-f013c84e609b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "046d80b1-b095-4179-b369-cbd608900f38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "83018b57-f064-438d-973f-5b1c81d8720c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0aed25ec-3aea-42a7-afcb-c024c90ccb6b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5867f1c-273d-4bbe-aedf-0c52623c57eb", "AQAAAAEAACcQAAAAEKJ3FQDOOO4ZDVML0OuKHIgwZADWrO2aZuzKw7Cz85EMQbxYBAIJ0XEqi4GTU4Ue7g==", "162300e5-806b-4343-abe3-6a27c6197754" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac1a7162-7112-4a6e-9814-94942f349655", "AQAAAAEAACcQAAAAEM6rY5N47ae7GAWiVe7DMxhcY6v/pbnMBIc9lTFnyxG94YPGM7BBFEtqVqRsdQv1iQ==", "ae930300-9097-4ff8-94c8-d29501410224" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1bf093a-3a13-471d-ae62-1a19a451a7d2", "AQAAAAEAACcQAAAAEPK/5mkt5yMVpbqbvG5jCYCmDGdKO2swV5mjT8Xw3VrvooK19dMBiqznqcBaLhDmLQ==", "85fa0bc7-1571-4841-8b0f-380ed7363124" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940e1571-d699-4e25-8f8f-799c8d58da8d", "AQAAAAEAACcQAAAAELPNWC5YlVLVP7QOHP20i2KgRgK3GQW/9oX3y4kvHRDABjLRh2O6OVIrUwa6XbwaBA==", "111b2084-ab0b-4558-9aac-07ee8d224b52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80e3f7bb-e3a3-44d0-8ed8-a268f42689ca", "AQAAAAEAACcQAAAAEK4IhJnzQ7xf9d5rw5xWYmuk6lEEyBC6xZW5KwtAuhiZUowZzzhnFcPXy5eQTdIuKw==", "ea40b596-7bd8-4304-8e03-4c661a0bf250" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7bf5b8-7aa4-4cf1-9005-fee3fce84861", "AQAAAAEAACcQAAAAEDH80FPEKndCPQzJICaTFvLB0phkp7B50HICXnkSkLafAJVbjhwkPf5q7/eqDK+gGQ==", "3acaf1a8-edb1-4649-9ad2-24f4fcd9392b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight_Kg",
                table: "Trackings");

            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Receives");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Receives");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "OutsourceWorkOrders");

            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "OutsourceWorkOrders");

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "OutsourceWorkOrders");

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3528), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3536), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3540), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3539), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3542), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 8, 9, 16, 32, 24, 322, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e9347c0b-52d0-475b-8079-328e501ecc40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "94ef33c1-03ce-4e73-a058-215e92c05edf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "83b72677-70f3-4834-b923-b44098eaee15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9c75cdfc-0004-4345-9c55-75eded3ad303");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6872cef3-2c83-414a-af36-84faee352882", "AQAAAAEAACcQAAAAEL7cZKsKCuvXlx8GLeTn/oLFwOoF3K7kLQsXTyGUmVhYrGvqNfG9hCO+0h6Lqcx4Cw==", "eb4af676-522e-4968-bf52-c84733011182" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df724e89-bdcf-40f9-bb81-1e718b673797", "AQAAAAEAACcQAAAAEOPnxkQqoNS3lDpjhKGlQ1N5qrVZ4VC0WxLWv4yjQp7sXssVndS6sUgpS/RSOHXaAA==", "6b175f03-28ca-42fa-87af-d45de485c81f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3932335-0fea-4a9e-b8e2-317932aee88c", "AQAAAAEAACcQAAAAEJCvnyYdbV0bU0z5CWKhsZWsS5g+fOL3Wsn0S9Ng0CnR0n9o1HpyW5rpBGa40cS5Zg==", "68dab21d-fb85-4b7a-888b-8ea92ac3b5a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838c7014-6d88-4424-8a9c-4a89f3eebac2", "AQAAAAEAACcQAAAAEHiSdkSEgnusxb296bFMxUyF5kFK2gHlOERzoG0SivS8kmrbpNxNfZJAF7RPdheneA==", "44440096-d5e3-4342-baaa-30a533667c1a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6001fd2e-0bc6-42b6-aee9-73758f03a718", "AQAAAAEAACcQAAAAEOgL3Ziqkc1+wAhF9tZJr6xv7eGhJa/cP1iEIeZOYtU/gPUvU2Ke3Dgei318U/ZVaQ==", "38188f34-5595-4197-a092-ebede40fb763" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fade35a-ed21-46a3-af6b-6f44938db51e", "AQAAAAEAACcQAAAAECN3l9fxvKDf3FFh5L9W1NaArEp2UTGe4ZVLQxqcfGcttkJnp/r6zXRAFMxcjt5D0g==", "49e08b5f-7abf-4ba7-a5bb-b716c6818610" });
        }
    }
}
