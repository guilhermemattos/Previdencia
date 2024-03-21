using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Previdencia.Entities;

namespace Previdencia.Entities
{
    public class Certificado
    {
        public int CodigoCertificado { get; set; }
        public DateTime DataInclusao { get; set; }
        public char Status { get; set; }

        #region Relacionamentos
        public Contrato CodigoContrato { get; set; }
        public Produto CodigoProduto { get; set; }
        public Cliente CodigoCliente { get; set; }
        #endregion
    }
}
