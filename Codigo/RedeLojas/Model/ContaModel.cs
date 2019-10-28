using System;
namespace Model
{
    public class ContaModel
    {
        public int Id { get; set; }
        public int IdRede { get; set; }
        public int IdPlanoConta { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int? IdAssociado { get; set; }
        public int? IdFornecedor { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? JurosDesconto { get; set; }
        public decimal? ValorPago { get; set; }
    }
}
