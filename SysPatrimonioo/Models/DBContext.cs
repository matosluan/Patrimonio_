using Microsoft.EntityFrameworkCore;

namespace SysPatrimonioo.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opcoes)
            : base(opcoes)
        {
        }
        public DbSet<DbUsuario> usuario { get; set; }
        public DbSet<DbDepartamento> departamento { get; set;}
        public DbSet<DbLocal> local { get; set; }
        public DbSet<DbCategoria> categorias { get; set; }
        public DbSet<DbFornecedor> fornecedor { get; set; }
        public DbSet<DbPatrimonio> patrimonio { get; set; }



    }
}
