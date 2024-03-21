using Previdencia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Controllers
{
    public class BeneficioController
    {
        public void CadastrarBeneficio()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE BENEFÍCIO:\n");

                var beneficio = new Beneficio();

                Console.Write("INFORME O NOME DO BENEFÍCIO: ");
                beneficio.Descricao = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao cadastrar Beneficio: {ex.Message}.");
            }
        }
    }
}
