using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Time.Planning.Migrations
{
    /// <inheritdoc />
    public partial class addStringShowTimeToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShowTime",
                table: "Chicks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "Chicks");
        }
    }
}
