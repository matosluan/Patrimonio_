using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SysPatrimonioo.Models
{
    [Table("local", Schema = "public")]
    public class DbLocal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nomelocal { get; set; }
        public string descricaolocal { get; set; }
    }
}
