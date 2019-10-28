using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class ContaBanco
    {
        public ContaBanco()
        {
            MovimentacaoBancaria = new HashSet<MovimentacaoBancaria>();
        }

        public int IdContaBanco { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }
        public int IdBanco { get; set; }

        public Banco IdBancoNavigation { get; set; }
        public ICollection<MovimentacaoBancaria> MovimentacaoBancaria { get; set; }
    }
}
