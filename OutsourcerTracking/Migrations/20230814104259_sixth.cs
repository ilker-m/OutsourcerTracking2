using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4665), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4669), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 8, 14, 13, 42, 58, 432, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5f4cada3-3b5d-4e71-8172-61ede0e08093");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8fa88ce9-c3cf-43a0-9e26-8c94a26e862b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1823ec8a-581c-4cbf-a042-1fb5aef71c1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a52ecc5c-7fae-408f-a8e8-33720a2effd9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003270f6-e882-4779-ba09-89a805035cec", "AQAAAAEAACcQAAAAENIlMGz7tRhSk8xm6KP9kCONPVummPw6Dc3J2caO3HavhIxQdzp/OYJF/YK0h5/xjQ==", "641db29c-2a2c-45d9-8857-7814dd3ab940" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa166f6e-c549-40e0-818d-4f5016bebff7", "AQAAAAEAACcQAAAAEFVicoeoNOgwNLacMgBcm6YZpniRztUwJtnUfruhPVwq+6vwBfyrTFLN87VZRtGW4w==", "1abd047a-5f50-43d5-ab6b-da707b039593" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e76cee4-e36d-4276-91c8-6b9b549e6724", "AQAAAAEAACcQAAAAEJBuJk1nGaxrppbhP6OWkdzo/tg/Bs4xCExLGCHP0OxQ//cROc2zf6HvIxh/VDgtXA==", "df9181f9-45a2-48aa-bd4b-f08c42e06344" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1531fa9e-3247-4625-8cb3-399a4b07ab22", "AQAAAAEAACcQAAAAEIgS8ZaKXm7E9i+dotIN0T8MXHMW4bLccVJurlw6jVFJYC1xeJf0Q4U1vNTr96T19Q==", "8cae75a2-26ff-461e-b0b8-fd80eb8f1247" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "650daacf-d7bf-4217-a795-3d2a30e30409", "AQAAAAEAACcQAAAAEJqutfIhkA1FYhYkzTUZzRq+AfBrUkE6FVc1t9whIGdRZDlMfItcNenzWpEwnabBbg==", "69fe6361-b8fc-4518-bf84-ecf2c0552bb9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8467952a-b4b1-4910-ab11-abbc018e9680", "AQAAAAEAACcQAAAAEFDHTsZ2s1Q2hiDDPPi0CLUJyjusVvUDbbhA898Nfp8B1Z/cAQZVPDjdBMP+KO35JA==", "a84e1872-ce1f-4397-b874-55cec1f52c43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 8, 14, 13, 27, 50, 982, DateTimeKind.Local).AddTicks(6023) });

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
    }
}
