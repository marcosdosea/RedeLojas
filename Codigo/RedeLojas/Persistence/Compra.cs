using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Compra
    {
        public Compra()
        {
            CompraProduto = new HashSet<CompraProduto>();
        }

        public int IdCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdAssociado { get; set; }
        public int IdFornecedor { get; set; }

        public Associado IdAssociadoNavigation { get; set; }
        public Fornecedor IdFornecedorNavigation { get; set; }
        public ICollection<CompraProduto> CompraProduto { get; set; }
    }
}
