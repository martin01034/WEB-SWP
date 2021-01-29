using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class RemovedKeyword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPerBookDatas");

            migrationBuilder.DropTable(
                name: "BookDataPerKeywords");

            migrationBuilder.DropTable(
                name: "BookDataPerSpecializations");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "BookDatas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "BookDatas");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyWords",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWords", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuthorPerBookDatas",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPerBookDatas", x => x.Key);
                    table.ForeignKey(
                        name: "FK_AuthorPerBookDatas_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPerBookDatas_BookDatas_BookDataId",
                        column: x => x.BookDataId,
                        principalTable: "BookDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDataPerKeywords",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookDataId = table.Column<int>(type: "int", nullable: false),
                    KeyWordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDataPerKeywords", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BookDataPerKeywords_BookDatas_BookDataId",
                        column: x => x.BookDataId,
                        principalTable: "BookDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDataPerKeywords_KeyWords_KeyWordId",
                        column: x => x.KeyWordId,
                        principalTable: "KeyWords",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDataPerSpecializations",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoodDataId = table.Column<int>(type: "int", nullable: false),
                    BookDataId = table.Column<int>(type: "int", nullable: true),
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDataPerSpecializations", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BookDataPerSpecializations_BookDatas_BookDataId",
                        column: x => x.BookDataId,
                        principalTable: "BookDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookDataPerSpecializations_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPerBookDatas_AuthorId",
                table: "AuthorPerBookDatas",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPerBookDatas_BookDataId",
                table: "AuthorPerBookDatas",
                column: "BookDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDataPerKeywords_BookDataId",
                table: "BookDataPerKeywords",
                column: "BookDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDataPerKeywords_KeyWordId",
                table: "BookDataPerKeywords",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDataPerSpecializations_BookDataId",
                table: "BookDataPerSpecializations",
                column: "BookDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDataPerSpecializations_SpecializationId",
                table: "BookDataPerSpecializations",
                column: "SpecializationId");
        }
    }
}
