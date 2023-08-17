using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KeyCode",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9192), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9202), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9200), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9216), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 8, 17, 13, 59, 7, 739, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c556ac6e-f79f-4c2f-83e3-170356050003");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ce7b5952-cda0-4aed-a1eb-4553b8c1bdf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "189b9bac-ef6f-4a57-94f5-ed7de4f1c79d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "2fc69ba6-c99c-4386-8a69-d551edf3e92d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed925c5a-6c00-4921-b1e4-53f86a9edce0", "AQAAAAEAACcQAAAAEIseugN+bbuIfd5EjY3VQiYGhISppkCCRW0Gww/iuRolZdTnDm49npX7q9GSEvz5fg==", "1b677e80-72b2-4800-8a0a-f4243106bb7d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfb178d-8bf7-4491-b71f-5ac68e805c52", "AQAAAAEAACcQAAAAEJYQMpyYDuGlsqswWW8pHCa2rcsKU/tssAI0bk54N1s117uqwHa5G9I10VmYSepSgw==", "843ddcae-38fe-43ec-b546-4f5cb8b253ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf2a5165-cf06-4c9f-a9ad-e44d9e412819", "AQAAAAEAACcQAAAAED5ui4jpuiPfibGJX3fVwu8icZpi06eZSjWzK+PNVBqyfYeQY8M1KeTIi0YYcrMDew==", "eb96b2a7-3e02-4c99-bb16-a6eafe516395" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "480dc309-cad8-437d-9c22-a02db3472d3d", "AQAAAAEAACcQAAAAEFFQvGH0q+lK21wOM6LjM+hMmM6CUJag3HD/UwNHY49nT6OWBZUTiTFaBlkIjhjvmA==", "a31a01ae-f7a5-4b60-b146-fdcd6680a478" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72fe78bb-df3f-4802-a38e-bf6ea605f936", "AQAAAAEAACcQAAAAEMmjeUYIOebanzg1qSoYogR3l4LP3dT3/pa4T51wQkBVAPPUCTI5iuoBz2xmiBHdYQ==", "61e9e108-8c9d-4fd8-bd96-d64a1651ed5e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433e8840-610f-4775-8729-90aa78c2f1f5", "AQAAAAEAACcQAAAAEPjIOqZtqkogk13QcElLyOqMmd7KoEVlrgOCxLbrFoqaL1ywaIvnP0RSHWqI9d8KtA==", "47633dd6-8a16-4dba-a8e9-c78964b21609" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyCode",
                table: "Users");

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
    }
}
