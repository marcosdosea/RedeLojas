using System;
namespace Model
{
    public class CompraModel
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdAssociado { get; set; }
        public int IdFornecedor { get; set; }
    }
}
