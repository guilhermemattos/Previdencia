using Previdencia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Controllers
{
    public class FundoController
    {
        public void CadastrarFundo()
        {
            try
            {

                Console.WriteLine("\nCADASTRO DE FUNDO:\n");

                var fundo = new Fundo();

                Console.Write("INFORME O NOME DO FUNDO: ");
                fundo.Nome = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao cadastrar Fundo: {ex.Message}.");
            }
        }
    }
}
