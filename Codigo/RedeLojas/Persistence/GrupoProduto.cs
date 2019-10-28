using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class GrupoProduto
    {
        public GrupoProduto()
        {
            Fornecedor = new HashSet<Fornecedor>();
            Produto = new HashSet<Produto>();
        }

        public int IdGrupoProduto { get; set; }
        public string Nome { get; set; }
        public int IdRede { get; set; }

        public Rede IdRedeNavigation { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
