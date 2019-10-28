using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Rede
    {
        public Rede()
        {
            Conta = new HashSet<Conta>();
            GrupoProduto = new HashSet<GrupoProduto>();
            MovimentacaoBancaria = new HashSet<MovimentacaoBancaria>();
            Parceria = new HashSet<Parceria>();
            RedeAssociado = new HashSet<RedeAssociado>();
        }

        public int IdRede { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public byte[] Logotipo { get; set; }

        public ICollection<Conta> Conta { get; set; }
        public ICollection<GrupoProduto> GrupoProduto { get; set; }
        public ICollection<MovimentacaoBancaria> MovimentacaoBancaria { get; set; }
        public ICollection<Parceria> Parceria { get; set; }
        public ICollection<RedeAssociado> RedeAssociado { get; set; }
    }
}
