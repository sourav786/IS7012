using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_Crud.Migrations
{
    public partial class addingvalidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Destination_Name",
                table: "Destination",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Destination",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResortPhone",
                table: "Destination",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "ResortPhone",
                table: "Destination");

            migrationBuilder.AlterColumn<string>(
                name: "Destination_Name",
                table: "Destination",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 27,
                oldNullable: true);
        }
    }
}
