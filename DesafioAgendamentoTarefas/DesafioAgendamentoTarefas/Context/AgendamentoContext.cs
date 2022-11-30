using DesafioAgendamentoTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioAgendamentoTarefas.Context
{
    public class AgendamentoContext: DbContext
    {

        public AgendamentoContext(DbContextOptions<AgendamentoContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
