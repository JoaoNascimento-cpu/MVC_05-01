using trabalho1.Models;
using trabalho1.Views;

namespace trabalho1.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            produtoView.Listar( produto.Ler());
        }

        public void Cadastrar()
        {
            produto.Inserir(produtoView.CadastrarProduto());
        }
    }
}