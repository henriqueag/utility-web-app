using SistemaVendas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Model
{
    public class ItensDaVenda
    {
        public int IdVenda { get; private set; }
        public Produtos Produto { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal VlrUnitario { get; private set; }
        public List<ItensDaVenda> ListItens { get; set; } = new List<ItensDaVenda>();
        private readonly ItensVendaDAO _itensDAO = new ItensVendaDAO();

        public ItensDaVenda ()
        {
        }

        public ItensDaVenda (int idVenda, Produtos produto, decimal quantidade, decimal vlrUnitario)
        {
            IdVenda = idVenda;
            Produto = produto;
            Quantidade = quantidade;
            VlrUnitario = vlrUnitario;
        }

        public DataTable BuscaItensPorIdVenda (int id)
        {
            return _itensDAO.BuscaItensPorIdVenda(id);
        }

        public void VoltarEstoqueProdutos (int idVenda)
        {
            _itensDAO.VoltarEstoqueProdutos(idVenda);
        }
    }
}
