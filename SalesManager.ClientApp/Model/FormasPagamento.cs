using SistemaVendas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Model
{
    public class FormasPagamento
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public bool PermiteDesconto { get; private set; }
        private readonly FormasPagamentoDAO pagamentoDAO = new FormasPagamentoDAO();

        public FormasPagamento ()
        {
        }

        public FormasPagamento (int id, string descricao, bool permiteDesconto)
        {
            Id = id;
            Descricao = descricao;
            PermiteDesconto = permiteDesconto;
        }

        public FormasPagamento SelecionaFormaPagamento(string descricao)
        {
            return pagamentoDAO.SelecionaFormaPagamento(descricao);
        }

        public DataTable SelectAll ()
        {
            return pagamentoDAO.SelectAll();
        }

        public FormasPagamento BuscaPorId (int id)
        {
            return pagamentoDAO.BuscaPorId(id);
        }
    }
}
