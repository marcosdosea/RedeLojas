using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Associado
    {
        public Associado()
        {
            ArquivoMensalNfe = new HashSet<ArquivoMensalNfe>();
            Compra = new HashSet<Compra>();
            Conta = new HashSet<Conta>();
            RedeAssociado = new HashSet<RedeAssociado>();
        }

        public int IdAssociado { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Situcao { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int IdCidade { get; set; }

        public Cidade IdCidadeNavigation { get; set; }
        public ICollection<ArquivoMensalNfe> ArquivoMensalNfe { get; set; }
        public ICollection<Compra> Compra { get; set; }
        public ICollection<Conta> Conta { get; set; }
        public ICollection<RedeAssociado> RedeAssociado { get; set; }
    }
}
