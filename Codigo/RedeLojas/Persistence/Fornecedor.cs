using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Compra = new HashSet<Compra>();
            Conta = new HashSet<Conta>();
        }

        public int IdFornecedor { get; set; }
        public string NomeFantasia { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string NomeRepresentante { get; set; }
        public string TelefoneRepresentante { get; set; }
        public int IdGrupoProduto { get; set; }
        public byte EhFabricante { get; set; }

        public GrupoProduto IdGrupoProdutoNavigation { get; set; }
        public ICollection<Compra> Compra { get; set; }
        public ICollection<Conta> Conta { get; set; }
    }
}
