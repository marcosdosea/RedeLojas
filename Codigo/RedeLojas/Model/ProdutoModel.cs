using System;
namespace Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string CodigoBarra { get; set; }
        public string Nome { get; set; }
        public string CodigoFabricante { get; set; }
        public int IdGrupoProduto { get; set; }
        public string NomeFabricante { get; set; }
    }
}
