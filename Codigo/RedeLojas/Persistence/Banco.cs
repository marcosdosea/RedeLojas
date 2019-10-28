using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Banco
    {
        public Banco()
        {
            ContaBanco = new HashSet<ContaBanco>();
        }

        public int IdBanco { get; set; }
        public string Nome { get; set; }

        public ICollection<ContaBanco> ContaBanco { get; set; }
    }
}
