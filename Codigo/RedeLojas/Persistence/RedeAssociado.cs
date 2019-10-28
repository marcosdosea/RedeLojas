using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class RedeAssociado
    {
        public int IdRede { get; set; }
        public int IdAssociado { get; set; }
        public byte EhAdministrador { get; set; }

        public Associado IdAssociadoNavigation { get; set; }
        public Rede IdRedeNavigation { get; set; }
    }
}
