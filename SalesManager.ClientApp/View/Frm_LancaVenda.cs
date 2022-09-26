using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaVendas.Model;
using SistemaVendas.Utilitario;

namespace SistemaVendas.View
{
    public partial class Frm_LancaVenda : Form
    {
        // Variáveis globais
        private Clientes _cliente = new Clientes();
        private Produtos _produto = new Produtos();
        private Venda _venda = new Venda();
        private FormasPagamento pagamento = new FormasPagamento();
        private readonly Frm_BuscarVendas _frm_Buscar;
        private readonly ItensDaVenda _itens = new ItensDaVenda();
        
        // Propriedades
        public Venda Venda { get { return _venda; } set { _venda = value; } }

        public Frm_LancaVenda (Frm_BuscarVendas frm_Buscar)
        {
            _frm_Buscar = frm_Buscar;
            InitializeComponent();
        }

        private void Frm_LancaVenda_Load (object sender, EventArgs e)
        {
            CarregaEventoLoad();
        }

        private void Btn_BuscarCliente_Click (object sender, EventArgs e)
        {
            using (Frm_BuscaClientes frm = new Frm_BuscaClientes())
            {
                frm.ShowDialog();
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.Cliente.Id == 0)
                    _cliente = null;
                else
                    _cliente = frm.Cliente;
            }
            if (_cliente != null)
                Txt_Cliente.Text = $"{_cliente.Id:D4} - {_cliente.Nome}";
        }

        private void Btn_BuscarProduto_Click (object sender, EventArgs e)
        {
            using (Frm_BuscaProduto frm = new Frm_BuscaProduto())
            {
                frm.ShowDialog();
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.Produto.Id == 0)
                    _produto = null;
                else
                    _produto = frm.Produto;
            }
            if (_produto != null)
            {
                Txt_Produto.Text = $"{_produto.Id:D4} - {_produto.NomeProduto}\r\nESTOQUE: {_produto.Estoque:F2}\r\nPREÇO: {_produto.Preco:C2}";
                Txt_Quantidade.Text = "1,00";
                Txt_VlrUnitario.Text = _produto.Preco.ToString("F2");
            }
        }

        private void Btn_AdicionarProduto_Click (object sender, EventArgs e)
        {
            if (_produto == null)
            {
                MessageBox.Show("Selecione o produto antes de clicar aqui.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_produto.Estoque < Convert.ToDecimal(Txt_Quantidade.Text))
            {
                MessageBox.Show("Não foi possível inserir o produto pois deixará seu estoque negatico.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Quantidade.Focus();
            }
            else
            {
                Dgv_ListaProdutos.Rows.Add(_produto.Id.ToString("D4"), _produto.NomeProduto, Txt_Quantidade.Text, Convert.ToDecimal(Txt_VlrUnitario.Text));
                CalcularTotalItens();
                Btn_BuscarProduto.Focus();
            }
        }

        private void Btn_RemoverProduto_Click (object sender, EventArgs e)
        {
            if (Dgv_ListaProdutos.Rows.Count > 0)
            {
                Dgv_ListaProdutos.Rows.Remove(Dgv_ListaProdutos.CurrentRow);
                CalcularTotalItens();
            }
            else
                MessageBox.Show("Não há produtos para serem removidos.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Cancelar_Click (object sender, EventArgs e)
        {
            Btn_Fechar_Click(sender, e);
        }

        private void Btn_Gravar_Click (object sender, EventArgs e)
        {
            if (Dgv_ListaProdutos.RowCount < 1)
            {
                MessageBox.Show("Adicione um produto a lista de itens.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(Txt_Cliente.Text))
            {
                MessageBox.Show("Selecione um cliente por favor.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_frm_Buscar.BotaoClicado == 1)
                {
                    PreenchaItensDaVenda();
                    PreencheVenda();

                    var sucesso = MessageBox.Show("Venda gravada com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _venda.LancamentoDeVenda(_venda, _itens);
                    if (sucesso == DialogResult.OK)
                    {
                        _frm_Buscar.Show();
                        Close();
                    }
                }
                else
                {
                    PreenchaItensDaVenda();
                    PreencheVenda();
                    _venda.UpdateLancamentoVenda(_venda, _itens);
                    var sucesso = MessageBox.Show("Venda alterada com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (sucesso == DialogResult.OK)
                    {
                        _frm_Buscar.Show();
                        Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Venda não gravada.\n{_venda.VendaDAO.MensagemErro}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _venda.GravaLogErro(_venda.VendaDAO.MensagemErro);
            }
        }

        private void Btn_Fechar_Click (object sender, EventArgs e)
        {
            var cancelar = MessageBox.Show("Deseja realmente cancela esse novo lançamento?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cancelar == DialogResult.Yes)
            {
                if (_frm_Buscar.BotaoClicado == 2)
                {
                    Venda.CancelaUpdateVenda(Venda.IdVenda);
                    _frm_Buscar.Show();
                    Close();
                }
                else
                {
                    _frm_Buscar.Show();
                    Close();
                }
            }
        }

        private void Dgv_ListaProdutos_CellEnter (object sender, DataGridViewCellEventArgs e)
        {
            _produto = _produto.BuscaProdutoPorId(Convert.ToInt32(Dgv_ListaProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString()));
            Txt_Produto.Text = $"{_produto.Id:D4} - {_produto.NomeProduto}\r\nESTOQUE: {_produto.Estoque:F2}\r\nPREÇO: {_produto.Preco:C2}";
        }

        private void Cbx_Pagamento_SelectedIndexChanged (object sender, EventArgs e)
        {
            var item = (DataRowView)Cbx_Pagamento.SelectedItem;
            if (item["permitir_desconto"].Equals(true) || item["permitir_desconto"].Equals(true))
            {
                Txt_Desconto.ReadOnly = false;
                Txt_Acrescimo.ReadOnly = true;
                Txt_Acrescimo.Text = "0,00";
            }
            else
            {
                Txt_Desconto.ReadOnly = true;
                Txt_Acrescimo.ReadOnly = false;
                Txt_Desconto.Text = "0,00";
            }
        }

        private void Lbl_Desconto_DoubleClick (object sender, EventArgs e)
        {
            CalculaTotalGeral();
        }

        private void Lbl_Acrescimo_DoubleClick (object sender, EventArgs e)
        {
            CalculaTotalGeral();
        }

        private void CalcularTotalItens ()
        {
            try
            {
                decimal somatorio = Dgv_ListaProdutos.Rows.Cast<DataGridViewRow>().
                                Sum(totalItens => Convert.ToDecimal((totalItens.Cells["vlrUnitario"].Value?.ToString().Replace("R$ ", ""))) * Convert.ToDecimal(totalItens.Cells["quantidade"].Value));
                Txt_TotalItens.Text = somatorio.ToString("C2");
                Txt_totalGeral.Text = somatorio.ToString("C2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro na conversão de valores\r\n - {ex.Message}", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreenchaItensDaVenda ()
        {
            try
            {
                int idVenda = Convert.ToInt32(Txt_Codigo.Text);
                foreach (DataGridViewRow row in Dgv_ListaProdutos.Rows)
                {
                    _produto = _produto.BuscaProdutoPorId(Convert.ToInt32(row.Cells["id"].Value));
                    _itens.ListItens.Add(new ItensDaVenda(Convert.ToInt32(Txt_Codigo.Text), _produto,
                        Convert.ToDecimal(row.Cells["quantidade"].Value), Convert.ToDecimal(row.Cells["vlrUnitario"].Value.ToString().Replace("R$ ", ""))));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro na conversão de valores\r\n - {ex.Message}", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheVenda ()
        {
            try
            {
                _cliente = _cliente.BuscaPorId(Convert.ToInt32(Txt_Cliente.Text.Substring(0, 4)));
                var pagamentoSelecionado = (DataRowView)Cbx_Pagamento.SelectedItem;
                pagamento = new FormasPagamento(Convert.ToInt32(pagamentoSelecionado["id"]), pagamentoSelecionado["descricao"].ToString(), Convert.ToBoolean(pagamentoSelecionado["permitir_desconto"]));

                decimal desconto = (Convert.ToDecimal(Txt_Desconto.Text) / 100) * Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", ""));
                decimal acrescimo = (Convert.ToDecimal(Txt_Acrescimo.Text) / 100) * Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", ""));

                _venda = new Venda(Convert.ToInt32(Txt_Codigo.Text), _cliente, Dtp_DataVenda.Value,
                    pagamento, desconto, acrescimo,
                    Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", "")), Convert.ToDecimal(Txt_totalGeral.Text.Replace("R$ ", "")));
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro na conversão de valores\r\n - {ex.Message}", "Erro de conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocorreu um erro ao executar o método {nameof(_cliente._clienteDAO.BuscaPorId)}\r\n" +
                    $"{_cliente._clienteDAO.MensagemErro}", "Evento de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculaTotalGeral ()
        {
            if (String.IsNullOrEmpty(Txt_TotalItens.Text))
                return;

            decimal totalGeral = Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", ""));
            var item = (DataRowView)Cbx_Pagamento.SelectedItem;
            if (item["descricao"].Equals("DINHEIRO") || item["descricao"].Equals("DÉBITO"))
            {
                totalGeral -= Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", "")) * (Convert.ToDecimal(Txt_Desconto.Text) / 100);
                Txt_totalGeral.Text = totalGeral.ToString("C2");
            }
            else if (item["descricao"].Equals("CRÉDITO 1X") || item["descricao"].Equals("CRÉDITO 2X"))
            {
                totalGeral += Convert.ToDecimal(Txt_TotalItens.Text.Replace("R$ ", "")) * (Convert.ToDecimal(Txt_Acrescimo.Text) / 100);
                Txt_totalGeral.Text = totalGeral.ToString("C2");
            }
        }
        
        private void CarregaEventoLoad ()
        {
            if (_frm_Buscar.BotaoClicado == 1)
            {
                Txt_Codigo.Text = _frm_Buscar.ProximoId.ToString("D4");
                AjusteDataGridView.DataGrid_NovaVenda(Dgv_ListaProdutos);
                Cbx_Pagamento.DataSource = pagamento.SelectAll();
                Cbx_Pagamento.DisplayMember = pagamento.SelectAll().Columns["descricao"].ToString();
            }
            else
            {
                Cbx_Pagamento.DataSource = pagamento.SelectAll();
                Txt_Codigo.Text = _venda.IdVenda.ToString("D4");
                Dtp_DataVenda.Value = Venda.DataLancamento;
                Txt_Cliente.Text = $"{Venda.Cliente.Id:D4} - {Venda.Cliente.Nome}";
                Txt_Desconto.Text = Venda.Desconto.ToString("F2");
                Txt_Acrescimo.Text = Venda.Acrescimo.ToString("F2");
                Txt_TotalItens.Text = Venda.Total_itens.ToString("C2");
                Txt_totalGeral.Text = Venda.Total_geral.ToString("C2");

                var itensVenda = _itens.BuscaItensPorIdVenda(Venda.IdVenda);
                AjusteDataGridView.DataGrid_AlterarVenda(Dgv_ListaProdutos, itensVenda);
            }
        }

        private void Frm_LancaVenda_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Btn_Fechar_Click(sender, e);

            if (e.KeyCode == Keys.F2)
                Btn_Gravar_Click(sender, e);

            if (e.Alt && e.KeyCode == Keys.C)
                Btn_BuscarCliente_Click(sender, e);

            if (e.Alt && e.KeyCode == Keys.P)
                Btn_BuscarProduto_Click(sender, e);
        }
    }
}