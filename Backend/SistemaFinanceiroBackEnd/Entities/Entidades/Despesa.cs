using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class Despesa : Base
    {
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public EnumTipoDespoesa EnumTipoDespoesa { get; set; }

        public DateTime Datacadastro { get; set; } 
        public DateTime DataAlteracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }

        public bool DespesaAtrasada { get; set; }

    }
}
