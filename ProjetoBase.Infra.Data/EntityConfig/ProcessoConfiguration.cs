using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBase.Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoBase.Infra.Data.EntityConfig
{
    public class ProcessoConfiguration : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfiguration()
        {
            HasKey(p => p.ProcessoId);

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
