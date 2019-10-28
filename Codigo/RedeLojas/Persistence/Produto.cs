using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Produto
    {
        public Produto()
        {
            CompraProduto = new HashSet<CompraProduto>();
        }

        public int IdProduto { get; set; }
        public string CodigoBarra { get; set; }
        public string Nome { get; set; }
        public string CodigoFabricante { get; set; }
        public int IdGrupoProduto { get; set; }
        public string NomeFabricante { get; set; }

        public GrupoProduto IdGrupoProdutoNavigation { get; set; }
        public ICollection<CompraProduto> CompraProduto { get; set; }
    }
}
