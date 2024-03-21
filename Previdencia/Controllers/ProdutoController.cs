using Previdencia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previdencia.Controllers
{
    public class ProdutoController
    {
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE PRODUTO:\n");

                var produto = new Produto();

                Console.Write("DIGITE O NOME DO PRODUTO:");
                produto.Descricao = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao cadastrar Produto: {ex.Message}.");
            }
        }
    }
}
