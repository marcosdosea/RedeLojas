using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class MovimentacaoBancaria
    {
        public int IdMovimentacaoBancaria { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public int IdRede { get; set; }
        public int IdContaBanco { get; set; }
        public int IdConta { get; set; }

        public ContaBanco IdContaBancoNavigation { get; set; }
        public Conta IdContaNavigation { get; set; }
        public Rede IdRedeNavigation { get; set; }
    }
}
