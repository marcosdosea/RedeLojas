using System;
namespace Model
{
    public class ContaBancoModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }
        public int IdBanco { get; set; }
    }
}
