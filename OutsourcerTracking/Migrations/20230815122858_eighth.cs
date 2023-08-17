using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFirst",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1764), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1755), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1770), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1770), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1773), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1773), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1775), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 8, 15, 15, 28, 57, 915, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7043f5ce-55d4-42f7-a32d-353bd9445956");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6e35ee32-3b87-4921-833c-f0730eae4af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c10bf4cc-3ec9-4982-80f4-57f773417b4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "865858e5-fd4b-4ed5-9f54-b9176ba756e4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d191cf85-1c49-437d-860b-12fe2f5fe4a1", true, "AQAAAAEAACcQAAAAELxedt6FQgHKND1mF7OPWoEM4CHaW0oHhq4ifq/msGXxnZx4H/DchbcS599IygEr5w==", "c471d33d-8eff-4b3d-891b-5eaeeae0381f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf5203b-b921-433c-b3c8-c4b3d19b0089", true, "AQAAAAEAACcQAAAAENnIeTLvD1FiDT8gMWxHncYl0GAGkjorPrCDb2OVhPZbMqw6lgZHCe7mNYlDOq6xQg==", "7e4dc09d-2c14-42c6-90a7-337811f74ec2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a603859-7a93-4b0a-9028-63d8c201040b", true, "AQAAAAEAACcQAAAAEAXEdGFHIDIHSyLJUIYhWfzyqccl8Xuoy8ZBsxRz/LaQIm1tLUCjPkqtq7sOphB+Jg==", "ee6122bd-ffd0-4667-a800-cbd36d2e883b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f621a79a-0888-4103-a75b-6c9ca3d23f73", true, "AQAAAAEAACcQAAAAEAQAA4Uue+TyaAJgMag1wxLGm5l8MwvavgWZkqb4JG1xa2iz+Ob8RPG8b73RBLvfYw==", "0005c7b4-aca1-4ac0-8e77-fe011fb10011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89cde83-3d71-4efa-b62a-5c1f24c5e08a", true, "AQAAAAEAACcQAAAAEFLWpnb4uIZ/eHKKaJU6Wsh5B+gE0lPj5n27VeJT4qfBjTiK/koM7WQXHNRHl3PaLw==", "1c22bbea-913a-4992-a114-18be570ebb55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f51057cd-6ff3-492b-b58a-71829cd48883", true, "AQAAAAEAACcQAAAAENS4F7XB7aCMjSS7JK9Hnw2zc1R8FtRoWoGwHPdDzBmiajUhUA+Qr/qrrZH9JqkTWQ==", "8441fe97-3f88-4be4-9f83-4d5ba6fab884" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsFirst",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5303), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5324), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5327), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Deadline", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 8, 15, 13, 13, 9, 36, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b0d20f6a-ff66-4242-9034-b4d44d35eb83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f1f76b86-7089-4f61-9c7d-55f685d9d670");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "284f55d4-b7f1-4489-8034-5c4ecdb16885");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0f4847fe-3a0f-46ea-b83c-4407331d3e9c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e650b25-d4a4-468a-b61e-db1d1bb616dd", "AQAAAAEAACcQAAAAEMG4EaXHL/P9TXdQPCVF2Cng/IzR8Y13trTjoVX0FoPEqIqxelSsc6c+jN/OhH81hg==", "81c9ef99-027b-4fc8-965b-3890b633f176" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "171337bc-ab70-4ed7-b6a7-d64ab249f14f", "AQAAAAEAACcQAAAAEA8LI85Ibw57zglfJouaOFv8sQstIxq31PTGfAZiNbPNpMmdCJ30Fbwuf9Neit3ZCA==", "4225556a-8b6c-4f33-b749-94bd76064933" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e94a8e0-5aaa-44f2-ba99-3ed517993da3", "AQAAAAEAACcQAAAAEIhCFpfm6/yIRzit8n4+hDAnK1JC6QAe+vY0uh+qpH43UHBYRq82ouuuKnavb5RirA==", "ff7aba34-ac1f-4101-a5e6-6732da637e51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be29450-2440-45ba-bb8a-75610bb65a38", "AQAAAAEAACcQAAAAEHk5QMf8526iPIxNvHrmUFUipMAejGYvjySE01gtVH0LwosGWK1t15yLVRzeaq+euA==", "7be4775e-a045-47b2-a2b9-863dd6ab329c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d45d8f-1849-45da-9344-125643a000dd", "AQAAAAEAACcQAAAAEMZ3kadFdsGREn6XMsOxLXw5ZIXVc7Y2OxIMwksrSibi1s0+q6NniOQQyhn0Qvkjqw==", "fed0fcb5-7edb-4d57-a741-df4175472eff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f454f8f-494a-4b1a-b264-2d70ed1756b2", "AQAAAAEAACcQAAAAEMo+oLk5aIxX3W02MyTfTPflm0rF8E4aNpG83d8Ld//N4ojI4BfpOttaY8YQ9Vk7dQ==", "96e6b3f0-f567-4a1c-98c0-34db6a4d2961" });
        }
    }
}
