namespace SysPatrimonioo.Models
{
    public class DtoPatrimonio
    {
        public int id { get; set; }
        public string nomepatrimonio { get; set; }
        public string nomelocal { get; set; }
        public string nomefornecedor { get; set; }
        public string nomecategoria { get; set; }
        public string descricaopatrimonio { get; set; }
        public decimal valorpatrimonio { get; set; }
        public string marcamodelo { get; set; }
        public DateTime? dataaquisicao { get; set; }
        public DateTime? databaixa { get; set; }
        public int numnf { get; set; }
        public string numserie { get; set; }
        public string situacao { get; set; }
        public DateTime? datagarantia { get; set; }
        public string numetiqueta { get; set; }
    }
}
