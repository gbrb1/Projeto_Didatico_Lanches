using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Didatico_Lanches.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO CATEGORIAS(CategoriaNome, Descricao)
            VALUES('Nomal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql(@"INSERT INTO CATEGORIAS(CategoriaNome, Descricao)
            VALUES('Natural', 'Lanche feito com ingredientes naturais e integrais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM CATEGORIAS");
        }
    }
}
