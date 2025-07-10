using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Runner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInstanceCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstanceCount",
                table: "AppInstances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstanceCount",
                table: "AppInstances");
        }
    }
}
