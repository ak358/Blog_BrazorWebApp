using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_BrazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "本文１", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8226), "タイトル１", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8236) },
                    { 2, "本文２", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8237), "タイトル２", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8237) },
                    { 3, "本文３", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8238), "タイトル３", new DateTime(2024, 4, 6, 4, 15, 35, 831, DateTimeKind.Local).AddTicks(8239) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
