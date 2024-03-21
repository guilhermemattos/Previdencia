using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Entities
{
    public class Indices
    {
        public Fundo CodigoFundo { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
