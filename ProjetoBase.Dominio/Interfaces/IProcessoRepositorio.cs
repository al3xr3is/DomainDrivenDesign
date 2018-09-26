using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBase.Dominio.Entities;

namespace ProjetoBase.Dominio.Interfaces
{
    public interface IProcessoRepositorio : IRepositorioBase<Processo>
    {
        IEnumerable<Processo> BuscaPorProcesso(int NumeroProceso);
    }
}
