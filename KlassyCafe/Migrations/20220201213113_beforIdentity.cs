using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KlassyCafe.Migrations
{
    public partial class beforIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "Time",
            //    table: "TbReservation",
            //    type: "nvarchar(50)",
            //    maxLength: 50,
            //    nullable: true,
            //    oldClrType: typeof(TimeSpan),
            //    oldType: "time",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Date",
            //    table: "TbReservation",
            //    type: "datetime",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "date");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "TbEmployee",
            //    type: "nvarchar(200)",
            //    maxLength: 200,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nchar(100)",
            //    oldFixedLength: true,
            //    oldMaxLength: 100,
            //    oldNullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Cockes",
            //    table: "TbEmployee",
            //    type: "nvarchar(50)",
            //    maxLength: 50,
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Facebook",
            //    table: "TbEmployee",
            //    type: "nvarchar(500)",
            //    maxLength: 500,
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "ImageName",
            //    table: "TbEmployee",
            //    type: "nvarchar(200)",
            //    maxLength: 200,
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Insta",
            //    table: "TbEmployee",
            //    type: "nvarchar(500)",
            //    maxLength: 500,
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Twitter",
            //    table: "TbEmployee",
            //    type: "nvarchar(500)",
            //    maxLength: 500,
            //    nullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryId",
            //    table: "TbCategories",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_TbEmployee",
            //    table: "TbEmployee",
            //    column: "NationalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_TbEmployee",
            //    table: "TbEmployee");

            //migrationBuilder.DropColumn(
            //    name: "Cockes",
            //    table: "TbEmployee");

            //migrationBuilder.DropColumn(
            //    name: "Facebook",
            //    table: "TbEmployee");

            //migrationBuilder.DropColumn(
            //    name: "ImageName",
            //    table: "TbEmployee");

            //migrationBuilder.DropColumn(
            //    name: "Insta",
            //    table: "TbEmployee");

            //migrationBuilder.DropColumn(
            //    name: "Twitter",
            //    table: "TbEmployee");

            //migrationBuilder.AlterColumn<TimeSpan>(
            //    name: "Time",
            //    table: "TbReservation",
            //    type: "time",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(50)",
            //    oldMaxLength: 50,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Date",
            //    table: "TbReservation",
            //    type: "date",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "TbEmployee",
            //    type: "nchar(100)",
            //    fixedLength: true,
            //    maxLength: 100,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(200)",
            //    oldMaxLength: 200,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryId",
            //    table: "TbCategories",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
