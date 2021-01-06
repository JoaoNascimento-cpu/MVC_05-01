using System;
using trabalho1.Controllers;
using trabalho1.Models;

namespace trabalho1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.ListarProdutos();
        }
    }
}
