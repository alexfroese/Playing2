using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playing2.Migrations
{
    public partial class authors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Posts",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Blogs",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Website = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorID",
                table: "Posts",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_OwnerID",
                table: "Blogs",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Author_OwnerID",
                table: "Blogs",
                column: "OwnerID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Author_AuthorID",
                table: "Posts",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Author_OwnerID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Author_AuthorID",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_OwnerID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Blogs");
        }
    }
}
