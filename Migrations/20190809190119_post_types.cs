using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playing2.Migrations
{
    public partial class post_types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostTypeID",
                table: "Posts",
                nullable: false);

            migrationBuilder.Sql("UPDATE Posts SET PostTypeID = 3;");

            migrationBuilder.CreateTable(
                name: "PostTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeID",
                table: "Posts",
                column: "PostTypeID");

            migrationBuilder.InsertData("PostTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,] { { 1, "Personal" }, { 2, "Public" }, { 3, "Other" } });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostTypes_PostTypeID",
                table: "Posts",
                column: "PostTypeID",
                principalTable: "PostTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostTypes_PostTypeID",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostTypes");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostTypeID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostTypeID",
                table: "Posts");
        }
    }
}
