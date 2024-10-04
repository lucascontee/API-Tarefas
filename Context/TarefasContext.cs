using desafio_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace desafio_api.Context
{
    public class TarefaContext : DbContext
    {

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) 
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

    }
}
