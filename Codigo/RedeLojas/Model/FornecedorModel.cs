using System;
namespace Model
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string NomeRepresentante { get; set; }
        public string TelefoneRepresentante { get; set; }
        public int IdGrupoProduto { get; set; }
        public byte EhFabricante { get; set; }
    }
}
