using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class CompraProduto
    {
        public int IdCompra { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Subtotal { get; set; }

        public Compra IdCompraNavigation { get; set; }
        public Produto IdProdutoNavigation { get; set; }
    }
}
