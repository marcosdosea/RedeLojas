using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Parceria
    {
        public int IdParceria { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Sitacao { get; set; }
        public int IdRede { get; set; }

        public Rede IdRedeNavigation { get; set; }
    }
}
