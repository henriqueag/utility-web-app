using SistemaVendas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Model
{
    public class Venda
    {
        public int IdVenda { get; private set; }
        public Clientes Cliente { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public FormasPagamento Pagamento { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Acrescimo { get; private set; }
        public decimal Total_itens { get; private set; }
        public decimal Total_geral { get; private set; }
        public VendaDAO VendaDAO { get; } = new VendaDAO();

        public Venda ()
        {
        }

        public Venda (int idVenda, Clientes cliente, DateTime dataLancamento, FormasPagamento pagamento, decimal desconto, decimal acrescimo, decimal total_itens, decimal total_geral)
        {
            IdVenda = idVenda;
            Cliente = cliente;
            DataLancamento = dataLancamento;
            Pagamento = pagamento;
            Desconto = desconto;
            Acrescimo = acrescimo;
            Total_itens = total_itens;
            Total_geral = total_geral;
        }

        public Venda BuscaVendaPorId (int id)
        {
            return VendaDAO.BuscaVendaPorId(id);
        }

        public int ProximaIdVenda ()
        {
            return VendaDAO.ProximaIdVenda();
        }

        public void LancamentoDeVenda (Venda venda, ItensDaVenda itens)
        {
            VendaDAO.LancamentoDeVenda(venda, itens);
        }

        public DataTable BuscaVendas30Dias ()
        {
            return VendaDAO.BuscaVendas30Dias();
        }

        public DataTable FiltroVenda (string idCliente, DateTime inicial, DateTime final, string vendaIni, string vendaFim)
        {
            return VendaDAO.FiltroVenda(idCliente, inicial, final, vendaIni, vendaFim);
        }

        public void GravaLogErro (string erro)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("logErro.txt", true))
                {
                    sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm} --- {erro}");
                }
            }
            catch (IOException ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ocorreu um erro na aplicação.\r\n{ex.Message}", "Evento de erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void ExcluirLancamentoVenda (int idVenda)
        {
            VendaDAO.ExcluirLancamentoVenda(idVenda);
        }

        public void UpdateLancamentoVenda (Venda venda, ItensDaVenda itens)
        {
            VendaDAO.UpdateLancamentoVenda(venda, itens);
        }

        public void CancelaUpdateVenda (int idVenda)
        {
            VendaDAO.CancelaUpdateVenda(idVenda);
        }
    }
}
