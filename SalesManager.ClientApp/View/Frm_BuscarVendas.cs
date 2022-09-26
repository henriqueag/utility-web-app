using SistemaVendas.Model;
using SistemaVendas.Report;
using SistemaVendas.Utilitario;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.View
{
    public partial class Frm_BuscarVendas : Form
    {
        // Variáveis globais
        private Venda _venda = new Venda();
        private Clientes _cliente = new Clientes();
        private readonly Frm_Principal _frm_Principal;
        
        // Propriedades
        public int BotaoClicado { get; set; }
        public int ProximoId { get { return _venda.ProximaIdVenda(); } }

        public Frm_BuscarVendas (Frm_Principal frm_Principal)
        {
            InitializeComponent();
            _frm_Principal = frm_Principal;
        }

        private void Frm_BuscarVendas_Load (object sender, EventArgs e)
        {
            PreencheGridLoad();
            LimparFiltros();
        }

        private void Btn_Fechar_Click (object sender, EventArgs e)
        {
            Close();
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

        private void Btn_Filtrar_Click (object sender, EventArgs e)
        {
            try
            {
                string cliente = String.IsNullOrWhiteSpace(Txt_Cliente.Text) ? string.Empty : Txt_Cliente.Text.Substring(0, 4);
                var filtro = _venda.FiltroVenda(cliente, Dtp_Inicio.Value, Dtp_Fim.Value, Txt_numVendaInicio.Text, Txt_NumVendaFim.Text);
                AjusteDataGridView.DataGrid_BuscaVenda(Dgv_VendaAnteriores, filtro);
            }
            catch (Exception)
            {
                _venda.GravaLogErro(_venda.VendaDAO.MensagemErro);
            }
        }

        private void Btn_LimparFiltro_Click (object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void Frm_BuscarVendas_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F10)
            {
                Btn_LimparFiltro_Click(sender, e);
            }
            if (e.KeyData == Keys.F9)
            {
                Btn_Filtrar_Click(sender, e);
            }
        }

        #region Tratamento campos de busca por id da venda
        private void Txt_NumVendaFim_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Txt_numVendaInicio_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Txt_numVendaInicio_Leave (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_numVendaInicio.Text))
                Txt_numVendaInicio.Text = Convert.ToInt32(Txt_numVendaInicio.Text).ToString("D4");
        }

        private void Txt_NumVendaFim_Leave (object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_NumVendaFim.Text))
                Txt_NumVendaFim.Text = Convert.ToInt32(Txt_NumVendaFim.Text).ToString("D4");
        }

        private void Txt_numVendaInicio_Enter (object sender, EventArgs e)
        {
            Txt_numVendaInicio.SelectAll();
        }

        private void Txt_NumVendaFim_Click (object sender, EventArgs e)
        {
            Txt_NumVendaFim.SelectAll();
        }

        private void Txt_numVendaInicio_Click (object sender, EventArgs e)
        {
            Txt_numVendaInicio.SelectAll();
        }
        #endregion

        private void PreencheGridLoad ()
        {
            try
            {
                AjusteDataGridView.DataGrid_BuscaVenda(Dgv_VendaAnteriores, _venda.BuscaVendas30Dias());
            }
            catch (Exception)
            {
                _venda.GravaLogErro(_venda.VendaDAO.MensagemErro);
            }
        }

        private void LimparFiltros ()
        {
            Txt_Cliente.Text = string.Empty;
            Dtp_Inicio.Value = DateTime.Today - TimeSpan.FromDays(30);
            Dtp_Fim.Value = DateTime.Today.AddDays(1);
            Txt_numVendaInicio.Text = string.Empty;
            Txt_NumVendaFim.Text = string.Empty;
        }

        private void Dgv_VendaAnteriores_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            DataRowView row = (DataRowView)Dgv_VendaAnteriores.CurrentRow.DataBoundItem;
            _venda = _venda.BuscaVendaPorId(Convert.ToInt32(row["idVenda"]));
            Frm_VisualizarVenda frm = new Frm_VisualizarVenda()
            {
                Venda = _venda
            };
            frm.BringToFront();
            frm.ShowDialog();
            if (!frm.IsDisposed)
            {
                frm.Dispose();
                AjusteDataGridView.DataGrid_BuscaVenda(Dgv_VendaAnteriores, _venda.BuscaVendas30Dias());
            }
        }

        private void Btn_NovaVenda_Click (object sender, EventArgs e)
        {
            BotaoClicado = 1;
            Frm_LancaVenda frm = new Frm_LancaVenda(this)
            {
                TopLevel = false
            };
            _frm_Principal.PanelFrames.Controls.Add(frm);
            frm.BringToFront();
            Hide();
            frm.Show();
        }

        private void Btn_ExcluirVenda_Click (object sender, EventArgs e)
        {
            var selecionada = (DataRowView)Dgv_VendaAnteriores.CurrentRow.DataBoundItem;
            var mensagem = MessageBox.Show("Deseja realmente excluir a venda selecionada?", "Exclusão de registro",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (mensagem == DialogResult.OK)
            {
                _venda.ExcluirLancamentoVenda(Convert.ToInt32(selecionada["idVenda"]));
                AjusteDataGridView.DataGrid_BuscaVenda(Dgv_VendaAnteriores, _venda.BuscaVendas30Dias());
            }
            else
                MessageBox.Show("Operação cancelada pelo usuário.", "Exclusão de registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Alterar_Click (object sender, EventArgs e)
        {
            BotaoClicado = 2;

            DataRowView row = (DataRowView)Dgv_VendaAnteriores.CurrentRow.DataBoundItem;
            _venda = _venda.BuscaVendaPorId(Convert.ToInt32(row["idVenda"]));

            Frm_LancaVenda frm = new Frm_LancaVenda(this)
            {
                Venda = _venda,
                TopLevel = false
            };
            _frm_Principal.PanelFrames.Controls.Add(frm);
            
            ItensDaVenda itens = new ItensDaVenda();
            itens.VoltarEstoqueProdutos(_venda.IdVenda);

            Hide();
            frm.BringToFront();
            frm.Show();
        }

        private void Btn_Imprimir_Click (object sender, EventArgs e)
        {
            Frm_Relatorio rel = new Frm_Relatorio();
            venda_resumo relData = new venda_resumo();
            rel.Crv_Relatorio.ReportSource = relData;
            rel.BringToFront();
            rel.Show();
        }
    }
}
