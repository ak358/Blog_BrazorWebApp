﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog_BrazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccounts_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "administrator" },
                    { 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Password", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, "adminpass", 1, "admin" },
                    { 2, "userpass", 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "Title", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { 1, "本文１", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5925), "タイトル１", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5925), 1 },
                    { 2, "本文２", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5928), "タイトル２", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5928), 1 },
                    { 3, "本文３", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5930), "タイトル３", new DateTime(2024, 4, 9, 17, 7, 28, 420, DateTimeKind.Local).AddTicks(5931), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_RoleId",
                table: "UserAccounts",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
