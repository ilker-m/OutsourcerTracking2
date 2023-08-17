using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Situations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Üretici tarafında bekleyen işler.", "Beklemede" });

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Üretimi devam eden işler.", "Üretimde" });

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Üretimi tamamlanmış işler.");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Üretimi ve teslimatı tamamlanmış işler.", "Biten" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Description", "Name" },
                values: new object[] { "İş aktif olarak devam etmektedir.", "Aktif" });

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "İş tamamen teslim alınmıştır.", "Kontrolde" });

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "İş tamamen teslim alınıp kontol edilmiştir.");

            migrationBuilder.UpdateData(
                table: "Situations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "İş iptal edilmiş.", "Pasif" });

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
    }
}
