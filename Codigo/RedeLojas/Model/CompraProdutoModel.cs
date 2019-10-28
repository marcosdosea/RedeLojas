using System;
namespace Model
{
    public class CompraProdutoModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Subtotal { get; set; }
    }
}
