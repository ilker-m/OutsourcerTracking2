using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1760), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1819), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1821), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1825), new DateTime(2023, 8, 8, 12, 25, 58, 944, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "da138611-e2c1-45e9-836c-3d76831503eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3ca2a70a-76b6-4859-a292-fd1e2eebb1a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b50af66a-fa32-4f7e-9a0e-fa2a3605afe0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a55253a6-709c-4f8e-9f77-95089444b6ed");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "İş aktif olarak devam etmektedir.");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "İş tamamen teslim alınmıştır.");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "İş tamamen teslim alınıp kontol edilmiştir.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cff505b-618b-4547-bb77-098cdf7b9d18", "AQAAAAEAACcQAAAAEMjd7sZd7ZkY736wJBlYKCiGwpKZiyfETPlD/qCdCkyQ3XndfotiKopuJHCa8KC7uw==", "f6c8893f-329f-417e-a458-57f0c2868e4e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae17424c-5012-42e1-ad60-24748d099584", "AQAAAAEAACcQAAAAEF9p1DmlJ4SsfhqgOq/ey0GxrLI9luCaZtnhFxi3PYNKMYso1PZcbfkT5I1EQMY+nw==", "22634d69-e67d-4a7c-a18e-11894e585cb9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16d09b8c-d14c-42ba-add4-8fa4c44e3f27", "AQAAAAEAACcQAAAAEAHkRb9wkaG7s2X+Ga60sxEdyapWUMumb5MIOmrPEDKD5oBtIPZOTRo5D3HuT5qEgA==", "1af12fe1-49cb-4546-b9ab-b522f32ad7af" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac41a1f4-530f-4920-b985-de3204370c85", "AQAAAAEAACcQAAAAEHIUS+uljcQp+8rkipnDSkedE3sqVDcYgPVZ6cVmebfNaFOl+EZhE8a1nZ7D6VTLjQ==", "bc7c13d9-5f6c-400e-b1fe-d036a6c18790" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "210c5beb-bc21-417f-88ff-9d6d2d26d86c", "AQAAAAEAACcQAAAAEIKxEsk2t6YaGEh82nXSqHIzC7JSna+CePtvMZys5LeihXM7YAxEsHrzga1rIAGCRQ==", "9786b494-8f4a-4c2e-b428-935e86f84513" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2655963e-20c2-4ded-acca-1f3ccbc8a220", "AQAAAAEAACcQAAAAEKkITPUKJuhw5L3JSnUc8P4XDGCBlpA56E1fkuUqniJvEGvvXyPIlVgRouPLfTbVWw==", "583acfe3-9a3d-4d19-920f-0a2fb01d25cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 8, 8, 12, 20, 0, 154, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1ca2ff41-caad-4483-9199-c3896399c7b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "757b829d-751f-44d8-b7cc-9f7f4a1398c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8842169d-f039-476e-ab28-87c5aa66e762");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ba55f51d-de2d-40cf-85e8-15a8b9f87381");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "İş teslim edilecek veya üretimde.");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "İş tamamen teslim alınmıştır.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28bec652-1bdd-481d-a37c-62e7e055aaa8", "AQAAAAEAACcQAAAAEF3TE1rh+cetXY91+qCTZQ9FqJSe3+grj8Pt96o53/vKq83o8wukSf7ssRZgMpWaYQ==", "482eafb9-2cf9-47e5-b364-7bbd36041694" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1e0ac4-557e-42bf-9e46-9e6dd62b6496", "AQAAAAEAACcQAAAAEBRf1CKo2pZTV0xg8jBwLuzp/2YMXo7qrlSxUO9AEaJYIkk+1iph/RZT/akN47K8+Q==", "565440e6-2537-43b5-b7d6-1da35dbed426" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa16bd9-c2d6-48f0-a4d2-e177613c998c", "AQAAAAEAACcQAAAAEHe2Zz5Lh7jNt01s77SjeOR8Tu91hgrNQf9i/2ZzS+8G0ItrGa1SzSvws6aHiB96tw==", "3e8a363c-f66d-4b30-b0cb-1ecba61e5b2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbf6832-8aea-4ebd-a791-b29b91fb8654", "AQAAAAEAACcQAAAAEJLZH+NbF5R9ork5qxAiRilSUqE7QIgk/I30oEvdoJ+UosONLbHiRPePLKN+mRV91A==", "2718a52a-aaee-4615-84fb-d6a209415411" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4977082d-a92d-4e1e-b1dd-1af1720d822a", "AQAAAAEAACcQAAAAEP2JWjTwedSdKPfGQO20cMuSNhplcI2SnhrdpALPuj/Db1YneyzaVg9jI5RcPJCLGg==", "6abafd60-dc84-4257-909f-5fc99d09f21a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1ba6cd-6097-4c7d-89c8-ccbeca2b5b05", "AQAAAAEAACcQAAAAELQ2rJ3UU2h8uFhjixx0hD46jRWUoTUn6T+lGVj1GMV1gFmimt5kuH2lfbHrugCeZg==", "06e1659a-24f2-4347-8ecf-aa4364f6e72e" });
        }
    }
}
