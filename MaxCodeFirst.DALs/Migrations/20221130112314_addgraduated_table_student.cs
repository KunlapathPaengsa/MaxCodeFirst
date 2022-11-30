using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaxCodeFirst.DALs.Migrations
{
    /// <inheritdoc />
    public partial class addgraduatedtablestudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "graduated",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "graduated",
                table: "Students");
        }
    }
}
