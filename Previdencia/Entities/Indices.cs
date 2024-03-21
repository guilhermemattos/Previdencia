using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Entities
{
    public class Indices
    {
        
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        #region Relacionamentos
        public Fundo CodigoFundo { get; set; }
        #endregion
    }
}
