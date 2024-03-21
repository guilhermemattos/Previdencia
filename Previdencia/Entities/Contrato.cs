using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Entities
{
    public class Contrato
    {
        public int CodigoContrato { get; set; }
        public DateTime DataInclusao { get; set; }
        public Cliente CodigoCliente { get; set; }
        public Fundo CodigoFundo { get; set; }
        public Beneficio CodigoBeneficio { get; set; }
        public char Status { get; set; }
    }
}
