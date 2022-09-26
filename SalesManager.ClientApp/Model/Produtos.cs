using SistemaVendas.DAO;
using System.Data;

namespace SistemaVendas.Model
{
    public class Produtos
    {
        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal Estoque { get; private set; }
        public decimal Preco { get; private set; }
        public bool Ativo { get; private set; }
        public ProdutoDAO produtoDAO { get; } = new ProdutoDAO();

        public Produtos ()
        {            
        }

        public Produtos (int id, string nomeProduto, decimal estoque, decimal preco)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Estoque = estoque;
            Preco = preco;
        }

        public Produtos (int id, string nomeProduto, decimal estoque, decimal preco, bool ativo) : this(id, nomeProduto, estoque, preco)
        {
            Ativo = ativo;
        }

        public int BuscaProximoId ()
        {
            return produtoDAO.BuscaProximoId();
        }

        public void InsertProduto (Produtos produto)
        {
            produtoDAO.InsertProduto(produto);
        }

        public void DeleteProduto (int idProduto)
        {
            produtoDAO.DeleteProduto(idProduto);
        }

        public void UpdateProduto (Produtos produto)
        {
            produtoDAO.UpdateProduto(produto);
        }

        public void UpdateEstoque (int idProduto, decimal quantidade, string tipoMovi)
        {
            produtoDAO.UpdateEstoque(idProduto, quantidade, tipoMovi);
        }

        public DataTable SelectAll ()
        {
            return produtoDAO.SelectAll();
        }

        public Produtos BuscaProdutoPorId(int id)
        {
            return produtoDAO.BuscaPorId(id);
        }

        public DataTable FiltroProduto (string busca)
        {
            return produtoDAO.FiltroProduto(busca);
        }
    }
}
