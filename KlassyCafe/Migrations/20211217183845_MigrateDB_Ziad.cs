using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KlassyCafe.Migrations
{
    public partial class MigrateDB_Ziad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "TbCategories",
            //    columns: table => new
            //    {
            //        CategoryId = table.Column<int>(type: "int", nullable: false),
            //        CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbCategories", x => x.CategoryId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbJops",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbJops", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbOrders",
            //    columns: table => new
            //    {
            //        OrderId = table.Column<int>(type: "int", nullable: false),
            //        DateTimeNow = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        DeleveryDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Delevered = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
            //        Canceled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbDelevery", x => x.OrderId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbReservation",
            //    columns: table => new
            //    {
            //        ReservationId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
            //        Date = table.Column<DateTime>(type: "date", nullable: false),
            //        Time = table.Column<TimeSpan>(type: "time", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        N_Guests = table.Column<int>(type: "int", nullable: true),
            //        Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        TimeSent = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reservation", x => new { x.Date, x.ReservationId });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbSlider",
            //    columns: table => new
            //    {
            //        SliderId = table.Column<int>(type: "int", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbSlider", x => x.SliderId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbItems",
            //    columns: table => new
            //    {
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        SalesPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
            //        ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Disciption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CategoryId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbItems", x => x.ItemId);
            //        table.ForeignKey(
            //            name: "FK_TbItems_TbCategories",
            //            column: x => x.CategoryId,
            //            principalTable: "TbCategories",
            //            principalColumn: "CategoryId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbEmployee",
            //    columns: table => new
            //    {
            //        NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(newid())"),
            //        Name = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        JopId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "FK_TbEmployee_TbJops",
            //            column: x => x.JopId,
            //            principalTable: "TbJops",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbInvoices",
            //    columns: table => new
            //    {
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        InvoiceId = table.Column<int>(type: "int", nullable: false),
            //        Qty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
            //        InvoicePrice = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "FK_TbInvoices_TbItems",
            //            column: x => x.ItemId,
            //            principalTable: "TbItems",
            //            principalColumn: "ItemId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_TbInvoices_TbOrders",
            //            column: x => x.InvoiceId,
            //            principalTable: "TbOrders",
            //            principalColumn: "OrderId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_TbEmployee_JopId",
            //    table: "TbEmployee",
            //    column: "JopId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TbInvoices_InvoiceId",
            //    table: "TbInvoices",
            //    column: "InvoiceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TbInvoices_ItemId",
            //    table: "TbInvoices",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TbItems_CategoryId",
            //    table: "TbItems",
            //    column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "TbEmployee");

            //migrationBuilder.DropTable(
            //    name: "TbInvoices");

            //migrationBuilder.DropTable(
            //    name: "TbReservation");

            //migrationBuilder.DropTable(
            //    name: "TbSlider");

            //migrationBuilder.DropTable(
            //    name: "TbJops");

            //migrationBuilder.DropTable(
            //    name: "TbItems");

            //migrationBuilder.DropTable(
            //    name: "TbOrders");

            //migrationBuilder.DropTable(
            //    name: "TbCategories");
        }
    }
}
