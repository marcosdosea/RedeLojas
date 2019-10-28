using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Cidade
    {
        public Cidade()
        {
            Associado = new HashSet<Associado>();
        }

        public int IdCidade { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }

        public ICollection<Associado> Associado { get; set; }
    }
}
