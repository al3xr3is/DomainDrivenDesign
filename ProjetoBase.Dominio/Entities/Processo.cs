using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Dominio.Entities
{
    public class Processo
    {
        public int ProcessoId { get; set; }

        public int NumeroProcesso { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
