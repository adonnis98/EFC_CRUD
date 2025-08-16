using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIBROS",
                columns: table => new
                {
                    Id_LIBRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AUTOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EDITORIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA_PUBLICACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GENERO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIBROS", x => x.Id_LIBRO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIBROS");
        }
    }
}
