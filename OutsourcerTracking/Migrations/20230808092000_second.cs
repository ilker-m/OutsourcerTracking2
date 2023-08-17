using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Outsources",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

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
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Address");

            migrationBuilder.UpdateData(
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address",
                value: "Address");

            migrationBuilder.UpdateData(
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: "Address");

            migrationBuilder.UpdateData(
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Address",
                value: "Address");

            migrationBuilder.UpdateData(
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 5,
                column: "Address",
                value: "Address");

            migrationBuilder.UpdateData(
                table: "Outsources",
                keyColumn: "Id",
                keyValue: 6,
                column: "Address",
                value: "Address");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Outsources");

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9372), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "OutsourceWorkOrders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "RecordDate", "WorkOrderDate" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "420cf1f3-7227-4a27-ae67-5d07320c3af2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6c187ab4-8c56-44ab-94f6-212f8e87f336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a917a1ff-143e-4626-97e2-276abc8962ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0b221cdc-a49b-4e0d-bcc8-2011cc8261e8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "304c27d4-3fa0-4963-92e8-d1135a212b27", "AQAAAAEAACcQAAAAEPLWJ6QJ36r9r3SsUkapMuWNOWBUkTWmRxGVgGpuz6PKxVAnK03WGd9bH6XB8KHGTw==", "2f784c9f-1327-4bde-8248-88a659814e6f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c98c00e0-4bc7-4d9c-b565-0dadf538cb21", "AQAAAAEAACcQAAAAEJX077e41lb8lWYDij1f0i9HK2koma8h+I6h6CBj9YRyfpioWRfV+m2lee8x73g34g==", "040d863e-6dd0-4261-b7b1-bfa398471ffd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c946d219-4604-411d-898c-51e1e3ea39b0", "AQAAAAEAACcQAAAAEF3IMjoFACRDj4Fs9i7Dac0hCLTBj7G7a5705YnZlHSbvOlMj8thWNO8N2JysVYJ4w==", "120c486d-af2d-4b2c-9df6-8de771adda90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a18e7c1-6c91-45b2-aa4f-3eea9d907112", "AQAAAAEAACcQAAAAEKE+KYJ4U/Cee/UsY6qV3nM8tYp+FuigYAQfJKnEgAn/yQPdpIdxxKsQ3D49oynmKQ==", "c2dece38-efb7-4c4b-b45e-e008c864af06" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3e52f8-87c5-42a6-9f4b-0870bfc265a9", "AQAAAAEAACcQAAAAEILgWgd2ladRsVOxyC63nvUpYfxB1ZaNdDw7h6xs5wEFu3IndKiUqV19UOPz8v4h0w==", "36a6a18e-40e4-47a0-8daa-5178211f2d45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c41272f4-cd1f-444f-84a6-63f7d8408a54", "AQAAAAEAACcQAAAAEIBNGlUoAVdRRLiWlxizom5hXGzL84QxCVJhdXiQVeuPadpN2dzG6wkqhRPt+qO9+A==", "360373e2-f62c-4fa3-bb71-d2704ae932a3" });
        }
    }
}
