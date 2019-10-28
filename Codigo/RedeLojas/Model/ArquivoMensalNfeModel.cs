using System;
namespace Model
{
    public class ArquivoMensalNfeModel
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public byte[] Arquivo { get; set; }
        public string Situacao { get; set; }
        public int IdAssociado { get; set; }
    }
}
