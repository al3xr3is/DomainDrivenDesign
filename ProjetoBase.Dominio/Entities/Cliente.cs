using System;
using System.Collections.Generic;

namespace ProjetoBase.Dominio.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Processo> Processos { get; set; }
    }
}
