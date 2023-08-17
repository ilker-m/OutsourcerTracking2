using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Receives");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Receives",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}
