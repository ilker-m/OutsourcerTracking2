using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3741), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 8, 17, 8, 6, 37, 217, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "aca654db-a3eb-491d-9fa4-888c925867f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3af7c51d-0f0c-46ef-b41f-458ca363a4c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f5a428d2-1de9-47ea-bee6-7d51db8f9453");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "7e52003e-2446-4098-9ee6-ef73ec576d17");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd157881-1d8e-4ec9-b6d9-0678e833a19a", "AQAAAAEAACcQAAAAEBkMvm1KFBRcNG9U3r5f6cdUVdw7GNz8g56UmQudWWlX1Qx1R8q7w9YjdC17TVTWGA==", "31a87c1b-2b07-4c7c-b28f-1d38d5a9e6ec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "188266a5-da86-467d-8cc3-69f83c19e613", "AQAAAAEAACcQAAAAEFBEpdPmxieOT/xkULkxiPyEGU5hZNHPOfa8T0SH60PXAEeKUb0ZYYyq/UzQJSH6cw==", "b8b992af-35ce-4832-87c6-dca78f4174a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02af68b5-e52e-4775-8b3b-5f159df59a12", "AQAAAAEAACcQAAAAELihb9c0rz4ovZ2pk/ExtJ9Mdu4rCZfiupc4avrq4LMpK2KnFzrb5Ush54P3OFAswQ==", "1dc90916-bd9d-47e4-afc3-76afa653ec9c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5da33fd7-442c-49b4-9af8-3a87c9287114", "AQAAAAEAACcQAAAAEN7hf5BCjgx45VVeWf8uNWhn/NnyfNhZnBL6qzV+yeQ92rMsL4MqGbmWw2JUycB/dg==", "74b028dc-6942-432e-9a5d-9006d25ebcb0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7df6cd-bc36-4cd5-a27c-bf0e26f18757", "AQAAAAEAACcQAAAAEEtZH2LuIHuwKRsxP/+tbip/PWkO3MFF2tdirwVLAyzu/9Z4dg5rOisAHYWRI1L7Qw==", "2f358076-7789-428f-aec4-453d57957297" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe2e2de8-bbe9-4b42-9b48-570a98384b09", "AQAAAAEAACcQAAAAELDTfOeMxf/WV7KAYy4U5ARcpQyH/bVsSUYZH5+NpSLaSiyC9QA60pHXnpmauAVglg==", "2b917638-942c-47ea-a43d-27575524a51d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 8, 17, 7, 57, 12, 105, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "157f4ab4-166f-4930-a080-908b2e5954ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e9914ab2-1859-4e29-bbaf-5168dedd58e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2acfaeba-7448-4db6-901e-f11dd245be32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3514a917-bfc4-470a-8e98-074f87b3f467");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d1cab57-49e3-4aae-a8f1-ef0062ee83e0", "AQAAAAEAACcQAAAAEOnbmf74OFqaLJAaZ7ABXy4N4hQlA1WOtXPnnGsOF1az8b8iF5w6l7k17HXQ3DjQFA==", "6f562bc6-e5b2-4ef2-944b-a755a808dd8d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16cc2abd-2c98-463a-ac16-52eecdd41166", "AQAAAAEAACcQAAAAEKGEvaNRiGXnhQz9E+kVuu9HAHXV37MTcMxfctRLFBwrPlIaQt2DoJS1+SX9DNbmJg==", "40f4adfe-d3aa-46c1-bca1-d688dff8c75b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "635ab73c-bd40-4be1-b0df-1c57f06e091c", "AQAAAAEAACcQAAAAELyPIZvb2I5h3lAqoDFLSWmAqRPV2KenRR3YS5V6P8YxLriIZpmZYRQ9gd/1feKVIg==", "16f2b5ba-0cbc-43ab-bf69-5c97d2524e25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fedf073-63bb-4621-b2e9-2bc80177a779", "AQAAAAEAACcQAAAAEAeeFLk29uXDwcZQOvgKZUU3W3KSUdQ5s0fGZ8gwXY06eFdt0fBqiqWJzWiQDX4+1g==", "9fad1bd3-a49d-44d2-954f-9f931f2ef301" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56b8a5ad-788b-4aa5-9cd8-97da3aa5d8e8", "AQAAAAEAACcQAAAAEJof7cghdrVEvzs2DuWMmWuxDqNiFMUEzTQtc0hGmTGaE9lpXiMewG2WzR/cUgh+xA==", "c0292d9a-c85a-4d49-9319-94e0be7b8aa6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7713b4b-a2f1-448a-96e8-374accd3aaf8", "AQAAAAEAACcQAAAAEP1Ofer+S2fcFpKbChuYItoj97KvWR8DB9qOKDZLXvJ6pkGWqXtjGVirmrdEw6Aamg==", "d9d14d93-b3cd-4dcc-8ec4-bf63c1adf192" });
        }
    }
}
