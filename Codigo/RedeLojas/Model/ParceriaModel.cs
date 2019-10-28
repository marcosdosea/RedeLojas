using System;
namespace Model
{
    public class ParceriaModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Sitacao { get; set; }
        public int IdRede { get; set; }
    }
}
