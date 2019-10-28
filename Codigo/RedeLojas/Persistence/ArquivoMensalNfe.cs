using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class ArquivoMensalNfe
    {
        public int IdArquivoMensalNfe { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public byte[] Arquivo { get; set; }
        public string Situacao { get; set; }
        public int IdAssociado { get; set; }

        public Associado IdAssociadoNavigation { get; set; }
    }
}
