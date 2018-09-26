using System.Collections.Generic;
using System.Linq;
using ProjetoBase.Dominio.Entities;
using ProjetoBase.Dominio.Interfaces;

namespace ProjetoBase.Infra.Data.Repositorio
{
    public class ProcessoRepositorio : RepositorioBase<Processo>, IProcessoRepositorio
    {
        public IEnumerable<Processo> BuscaPorProcesso(int numeroprocesso)
        {
            return Db.Processos.Where(p => p.NumeroProcesso == numeroprocesso);
        }
    }
}
