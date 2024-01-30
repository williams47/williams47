using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoiaShop.ProdutoApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder modelb)
        {
            modelb.Sql("Insert Into Produtos(Nome, Preço, Descrição, Estoque, ImageUrl,CategoriaId) " +
                "Values('Gargantilha', 35.50, 'Banhado a Ouro', 10, 'Gargantilha1.jpg', 1");

            modelb.Sql("Insert into Produtos(Nome, Preço, Descrição, Estoque, ImageUrl, CategoriaId)" +
           "Values('Pulseiras', 18.90, 'Ouro ou Prata', 10, 'Pulseiras.jpg', 1");

            modelb.Sql("Insert into Produtos(Nome, Preço, Descrição, Estoque, ImageUrl, CategoriaId)" +
                "Values('Aneis', 22.00, 'Banhado a Ouro e Prata', 10, 'Aneis.jpg', 2");

            modelb.Sql("Insert into Produtos(Nome, Preço, Descrição, Estoque, ImageUrl, CategoriaId)" +
                "Values('Brincos', 35.50, ' Ouro e Prata', 10, 'Gargantilha.jpg', 2");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder modelb)
        {
            modelb.Sql("delete from Produtos");
        }
    }
}
