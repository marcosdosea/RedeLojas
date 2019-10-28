using System;
namespace Model
{
    public class AssociadoModel
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Situcao { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int IdCidade { get; set; }
    }
}
