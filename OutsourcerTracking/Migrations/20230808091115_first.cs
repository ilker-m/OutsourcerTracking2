using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsourcerTracking.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlkWorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceWorkOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StockCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StockName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlkWorkOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outsources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WarehouseCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MachineNo = table.Column<int>(type: "int", nullable: false),
                    MachineCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outsources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsChanged = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutsourceWorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RawMaterialsWarehouseCode = table.Column<int>(type: "int", nullable: false),
                    ProductWarehouseCode = table.Column<int>(type: "int", nullable: false),
                    AlkWorkOrderId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    OutsourceId = table.Column<int>(type: "int", nullable: false),
                    SituationId = table.Column<int>(type: "int", nullable: false),
                    IntegrationStatusId = table.Column<int>(type: "int", nullable: false),
                    WorkOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AlkUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AlkNormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsourceWorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutsourceWorkOrders_AlkWorkOrders_AlkWorkOrderId",
                        column: x => x.AlkWorkOrderId,
                        principalTable: "AlkWorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutsourceWorkOrders_IntegrationStatuses_IntegrationStatusId",
                        column: x => x.IntegrationStatusId,
                        principalTable: "IntegrationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutsourceWorkOrders_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutsourceWorkOrders_Outsources_OutsourceId",
                        column: x => x.OutsourceId,
                        principalTable: "Outsources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutsourceWorkOrders_Situations_SituationId",
                        column: x => x.SituationId,
                        principalTable: "Situations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutsourceUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsourceUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutsourceUsers_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trackings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutsourceWorkOrderId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    IsSealed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trackings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trackings_OutsourceWorkOrders_OutsourceWorkOrderId",
                        column: x => x.OutsourceWorkOrderId,
                        principalTable: "OutsourceWorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutsourceWorkOrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeUserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    IsSealed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receives_EmployeeUsers_EmployeeUserId",
                        column: x => x.EmployeeUserId,
                        principalTable: "EmployeeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receives_OutsourceWorkOrders_OutsourceWorkOrderId",
                        column: x => x.OutsourceWorkOrderId,
                        principalTable: "OutsourceWorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutsourcesOutsourceUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutsourceId = table.Column<int>(type: "int", nullable: false),
                    OutsourceUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsourcesOutsourceUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutsourcesOutsourceUsers_Outsources_OutsourceId",
                        column: x => x.OutsourceId,
                        principalTable: "Outsources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutsourcesOutsourceUsers_OutsourceUsers_OutsourceUserId",
                        column: x => x.OutsourceUserId,
                        principalTable: "OutsourceUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AlkWorkOrders",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsDeleted", "OrderGroup", "ReferenceWorkOrderNo", "StockCode", "StockName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, false, "2-Takımlar+CVL", "000000000002988", "P-K23160-09", "StockName 1", null, null },
                    { 2, null, null, false, "ZZZ-Yazlık Deneme", "000000000006124", "Y23270-11", "StockName 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, "Bilgi İşlem", false, "Bilgi İşlem", null, null },
                    { 2, null, null, "Lojistik", false, "Lojistik", null, null }
                });

            migrationBuilder.InsertData(
                table: "IntegrationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eşit" },
                    { 2, "Eklenecek" },
                    { 3, "Güncellenecek" },
                    { 4, "Silinecek" }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "IsDeleted", "Name", "No", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Code 1", null, null, false, "Kesim Atölye", "No 1", null, null },
                    { 2, "Code 2", null, null, false, "Pres Atölye", "No 2", null, null },
                    { 3, "Code 3", null, null, false, "Grogren Atölye", "No 3", null, null },
                    { 4, "Code 4", null, null, false, "Hasse Lamine Atölye", "No 4", null, null },
                    { 5, "Code 5", null, null, false, "Eva Lamine Atölye", "No 5", null, null }
                });

            migrationBuilder.InsertData(
                table: "Outsources",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CurrentCode", "Email", "IsDeleted", "MachineCode", "MachineName", "MachineNo", "Phone", "UpdatedBy", "UpdatedOn", "WarehouseCode" },
                values: new object[,]
                {
                    { 1, null, null, "Cari Kod 1", "ornek@ornek.com", false, "0042-003", "Güney Triko", 37, "1123456789", null, null, "Depo Kod 1" },
                    { 2, null, null, "Cari Kod 2", "ornek@ornek.com", false, "0044-005", "Miraç - Elişi", 38, "1123456789", null, null, "Depo Kod 2" },
                    { 3, null, null, "Cari Kod 3", "ornek@ornek.com", false, "0042-004", "Erdal Karakuş", 39, "1123456789", null, null, "Depo Kod 3" },
                    { 4, null, null, "Cari Kod 4", "ornek@ornek.com", false, "0042-006", "Taner Örme", 40, "1123456789", null, null, "Depo Kod 4" },
                    { 5, null, null, "Cari Kod 5", "ornek@ornek.com", false, "0042-007", "Onur Triko - Zaza", 41, "1123456789", null, null, "Depo Kod 5" },
                    { 6, null, null, "Cari Kod 6", "ornek@ornek.com", false, "0042-008", "Fatih Yavuz", 42, "1123456789", null, null, "Depo Kod 6" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedOn", "IsDeleted", "Name", "NormalizedName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "420cf1f3-7227-4a27-ae67-5d07320c3af2", null, null, false, "Admin", "ADMIN", null, null },
                    { 2, "6c187ab4-8c56-44ab-94f6-212f8e87f336", null, null, false, "Employee User", "EMPLOYEE USER", null, null },
                    { 3, "a917a1ff-143e-4626-97e2-276abc8962ea", null, null, false, "Outsource User", "OUTSOURCE USER", null, null },
                    { 4, "0b221cdc-a49b-4e0d-bcc8-2011cc8261e8", null, null, false, "API User", "API USER", null, null }
                });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, "İş teslim edilecek veya üretimde.", false, "Aktif", null, null },
                    { 2, null, null, "", false, "Kontrolde", null, null },
                    { 3, null, null, "İş tamamen teslim alınmıştır.", false, "Tamamlandı", null, null },
                    { 4, null, null, "İş iptal edilmiş.", false, "Pasif", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "IsChanged" },
                values: new object[] { 1, false });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, "Yazılım Uzamanı", false, "Yazılım Uzmanı", null, null },
                    { 2, null, null, "Yazılım Uzman Yardımcısı", false, "Yazılım Uzman Yardımcı", null, null },
                    { 3, null, null, "Ulaştırmacı", false, "Ulaştırmacı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "304c27d4-3fa0-4963-92e8-d1135a212b27", null, null, "admin@gmail.com", false, "Admin", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEPLWJ6QJ36r9r3SsUkapMuWNOWBUkTWmRxGVgGpuz6PKxVAnK03WGd9bH6XB8KHGTw==", "1234567890", false, "2f784c9f-1327-4bde-8248-88a659814e6f", false, null, null, "Admin Kullanıcı" },
                    { 2, 0, "c98c00e0-4bc7-4d9c-b565-0dadf538cb21", null, null, "employee1@gmail.com", false, "Çalışan1", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEJX077e41lb8lWYDij1f0i9HK2koma8h+I6h6CBj9YRyfpioWRfV+m2lee8x73g34g==", "1234567890", false, "040d863e-6dd0-4261-b7b1-bfa398471ffd", false, null, null, "Çalışan1 Kullanıcı" },
                    { 3, 0, "c946d219-4604-411d-898c-51e1e3ea39b0", null, null, "fason1@gmail.com", false, "Fason1", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEF3IMjoFACRDj4Fs9i7Dac0hCLTBj7G7a5705YnZlHSbvOlMj8thWNO8N2JysVYJ4w==", "1234567890", false, "120c486d-af2d-4b2c-9df6-8de771adda90", false, null, null, "Fason1 Kullanıcı" },
                    { 4, 0, "1a18e7c1-6c91-45b2-aa4f-3eea9d907112", null, null, "fason2@gmail.com", false, "Fason2", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEKE+KYJ4U/Cee/UsY6qV3nM8tYp+FuigYAQfJKnEgAn/yQPdpIdxxKsQ3D49oynmKQ==", "1234567890", false, "c2dece38-efb7-4c4b-b45e-e008c864af06", false, null, null, "Fason2 Kullanıcı" },
                    { 5, 0, "df3e52f8-87c5-42a6-9f4b-0870bfc265a9", null, null, "employee2@gmail.com", false, "Çalışan2", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEILgWgd2ladRsVOxyC63nvUpYfxB1ZaNdDw7h6xs5wEFu3IndKiUqV19UOPz8v4h0w==", "1234567890", false, "36a6a18e-40e4-47a0-8daa-5178211f2d45", false, null, null, "Çalışan2 Kullanıcı" },
                    { 6, 0, "c41272f4-cd1f-444f-84a6-63f7d8408a54", null, null, "server@gmail.com", false, "Server", false, "Kullanıcı", false, null, null, null, "AQAAAAEAACcQAAAAEIBNGlUoAVdRRLiWlxizom5hXGzL84QxCVJhdXiQVeuPadpN2dzG6wkqhRPt+qO9+A==", "1234567890", false, "360373e2-f62c-4fa3-bb71-d2704ae932a3", false, null, null, "Server Kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeUsers",
                columns: new[] { "Id", "DepartmentId", "TitleId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "OutsourceUsers",
                column: "Id",
                values: new object[]
                {
                    3,
                    4
                });

            migrationBuilder.InsertData(
                table: "OutsourceWorkOrders",
                columns: new[] { "Id", "AlkNormalizedUserName", "AlkUserName", "AlkWorkOrderId", "Amount", "CreatedBy", "CreatedOn", "Description", "IntegrationStatusId", "IsDeleted", "OperationId", "OutsourceId", "ProductWarehouseCode", "RawMaterialsWarehouseCode", "ReceivedDate", "RecordDate", "SituationId", "UpdatedBy", "UpdatedOn", "WorkOrderDate", "WorkOrderNo" },
                values: new object[,]
                {
                    { 1, "Orkun Demirci", "Or_De", 1, 500m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9366), "Açıklama", 1, false, 1, 1, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9355), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9365), "000000000002988" },
                    { 2, "Orkun Demirci", "Or_De", 1, 700m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9372), "Açıklama", 1, false, 2, 2, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9371), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9371), "000000000002989" },
                    { 3, "Orkun Demirci", "Or_De", 1, 200m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9374), "Açıklama", 1, false, 3, 3, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9373), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9374), "000000000002990" },
                    { 4, "Orkun Demirci", "Or_De", 2, 350m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9376), "Açıklama", 1, false, 4, 4, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9375), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9376), "000000000006124" },
                    { 5, "Orkun Demirci", "Or_De", 2, 400m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9379), "Açıklama", 1, false, 5, 5, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9378), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9378), "000000000006125" },
                    { 6, "Orkun Demirci", "Or_De", 2, 200m, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9381), "Açıklama", 1, false, 1, 6, 1, 1, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9380), 1, null, null, new DateTime(2023, 8, 8, 12, 11, 15, 158, DateTimeKind.Local).AddTicks(9380), "000000000006126" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 3, 4 },
                    { 5, 2, 5 },
                    { 6, 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "OutsourcesOutsourceUsers",
                columns: new[] { "Id", "OutsourceId", "OutsourceUserId" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 2, 3 },
                    { 3, 3, 3 },
                    { 4, 1, 4 },
                    { 5, 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_DepartmentId",
                table: "EmployeeUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_TitleId",
                table: "EmployeeUsers",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourcesOutsourceUsers_OutsourceId",
                table: "OutsourcesOutsourceUsers",
                column: "OutsourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourcesOutsourceUsers_OutsourceUserId",
                table: "OutsourcesOutsourceUsers",
                column: "OutsourceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourceWorkOrders_AlkWorkOrderId",
                table: "OutsourceWorkOrders",
                column: "AlkWorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourceWorkOrders_IntegrationStatusId",
                table: "OutsourceWorkOrders",
                column: "IntegrationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourceWorkOrders_OperationId",
                table: "OutsourceWorkOrders",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourceWorkOrders_OutsourceId",
                table: "OutsourceWorkOrders",
                column: "OutsourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OutsourceWorkOrders_SituationId",
                table: "OutsourceWorkOrders",
                column: "SituationId");

            migrationBuilder.CreateIndex(
                name: "IX_Receives_EmployeeUserId",
                table: "Receives",
                column: "EmployeeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Receives_OutsourceWorkOrderId",
                table: "Receives",
                column: "OutsourceWorkOrderId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Trackings_OutsourceWorkOrderId",
                table: "Trackings",
                column: "OutsourceWorkOrderId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_UserId",
                table: "UsersRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OutsourcesOutsourceUsers");

            migrationBuilder.DropTable(
                name: "Receives");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Trackings");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "OutsourceUsers");

            migrationBuilder.DropTable(
                name: "EmployeeUsers");

            migrationBuilder.DropTable(
                name: "OutsourceWorkOrders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AlkWorkOrders");

            migrationBuilder.DropTable(
                name: "IntegrationStatuses");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Outsources");

            migrationBuilder.DropTable(
                name: "Situations");
        }
    }
}
