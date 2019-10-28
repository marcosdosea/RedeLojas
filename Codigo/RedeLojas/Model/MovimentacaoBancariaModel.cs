using System;
namespace Model
{
    public class MovimentacaoBancariaModel
    {
        public int Id { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public int IdRede { get; set; }
        public int IdContaBanco { get; set; }
        public int IdConta { get; set; }
    }
}
