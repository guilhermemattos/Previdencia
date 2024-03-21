using Previdencia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Controllers
{
    public class IndicesController
    {
        public void CadastrarIndices()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE INDICES:\n");

                var indices = new Indices()
                {
                    CodigoFundo = new Fundo()
                };

                Console.Write("DIGITE O CÓDIGO DO FUNDO: ");
                var codFundo = Console.ReadLine();

                Console.Write("DIGITE O VALOR DO INDICE: ");
                indices.Valor = double.Parse(Console.ReadLine());

                indices.Data = DateTime.Now;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao cadastrar Indices: {ex.Message}.");
            }
        }
    }
}
