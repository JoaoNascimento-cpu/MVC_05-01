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
            public Produto CadastrarProduto()
            {
                Produto produto = new Produto();
                Console.WriteLine($"Digite um código:");
                produto.Codigo = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Digite o Nome do produto:");
                produto.Nome = Console.ReadLine();
                
                Console.WriteLine($"Digite o PReço do produto:");
                produto.Preco = float.Parse(Console.ReadLine());

                return produto;
            }
    }
}