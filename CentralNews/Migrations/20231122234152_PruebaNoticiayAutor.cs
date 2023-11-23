using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentralNews.Migrations
{
    /// <inheritdoc />
    public partial class PruebaNoticiayAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_id_noticia",
                table: "Comentarios",
                column: "id_noticia");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_id_usuario",
                table: "Comentarios",
                column: "id_usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Noticias_id_noticia",
                table: "Comentarios",
                column: "id_noticia",
                principalTable: "Noticias",
                principalColumn: "id_noticia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Usuarios_id_usuario",
                table: "Comentarios",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_usuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Noticias_id_noticia",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Usuarios_id_usuario",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_id_noticia",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_id_usuario",
                table: "Comentarios");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Usuarios",
                newName: "usuario");
        }
    }
}
