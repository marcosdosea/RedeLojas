using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class PlanoConta
    {
        public PlanoConta()
        {
            Conta = new HashSet<Conta>();
        }

        public int IdPlanoConta { get; set; }
        public string Nome { get; set; }

        public ICollection<Conta> Conta { get; set; }
    }
}
