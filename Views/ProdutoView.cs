using System;
using System.Collections.Generic;
using trabalho1.Models;

namespace trabalho1.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código = {item.Codigo}");
                Console.WriteLine($"Produto = {item.Nome}");
                Console.WriteLine($"Preço = R$: {item.Preco}");
                
            }
        }
    }
}