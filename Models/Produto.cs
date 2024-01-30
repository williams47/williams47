namespace JoiaShop.ProdutoApi.Models;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public decimal Preço { get; set; }
    public string? Descrição { get; set; }
    public long Estoque { get; set; }
    public string? ImageURL { get; set; }
   
    public Categoria? Categoria { get; set; }
    public int CategoriaId { get; set; }
}
