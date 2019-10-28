using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Conta
    {
        public Conta()
        {
            MovimentacaoBancaria = new HashSet<MovimentacaoBancaria>();
        }

        public int IdConta { get; set; }
        public int IdRede { get; set; }
        public int IdPlanoConta { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int? IdAssociado { get; set; }
        public int? IdFornecedor { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? JurosDesconto { get; set; }
        public decimal? ValorPago { get; set; }

        public Associado IdAssociadoNavigation { get; set; }
        public Fornecedor IdFornecedorNavigation { get; set; }
        public PlanoConta IdPlanoContaNavigation { get; set; }
        public Rede IdRedeNavigation { get; set; }
        public ICollection<MovimentacaoBancaria> MovimentacaoBancaria { get; set; }
    }
}
