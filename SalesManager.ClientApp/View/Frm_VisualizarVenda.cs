using SistemaVendas.Model;
using SistemaVendas.Report;
using SistemaVendas.Utilitario;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SistemaVendas.View
{
    public partial class Frm_VisualizarVenda : Form
    {
        public Venda Venda { get; set; } = new Venda();
        public ItensDaVenda ItensVenda { get; set; } = new ItensDaVenda();

        public Frm_VisualizarVenda ()
        {
            InitializeComponent();
        }

        private void Frm_VisualizarVenda_Load (object sender, EventArgs e)
        {
            PreencheLoad();
        }

        private void Frm_VisualizarVenda_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.Alt && e.KeyCode == Keys.P)
                Btn_Imprimir_Click(sender, e);
        }

        private void Btn_Fechar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Imprimir_Click (object sender, EventArgs e)
        {
            ExportarRelatorioPDF();
        }

        private void Btn_ExcluirVenda_Click (object sender, EventArgs e)
        {
            var mensagem1 = MessageBox.Show("Deseja realmente excluir essa venda?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(mensagem1 == DialogResult.OK)
            {
                Venda.ExcluirLancamentoVenda(Convert.ToInt32(Txt_Codigo.Text));
                var mensagem2 = MessageBox.Show("Venda excluída com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mensagem2 == DialogResult.OK)
                    Close();
            }
            else
                MessageBox.Show("Operação cancelada pelo usuário.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ExportarRelatorioPDF ()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "Arquivo PDF (*.pdf)|*.pdf|All files (*.*)|*.*",
                    Title = "Salvar relatório de venda",
                    InitialDirectory = "C:\\",
                    FileName = $"Resumo_venda_{Txt_Codigo.Text}.pdf",
                    FilterIndex = 0,
                    RestoreDirectory = true
                };
                string path = save.FileName;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    venda_resumo relatorio = new venda_resumo();
                    relatorio.SetDatabaseLogon("Santos", "admin");
                    relatorio.SetParameterValue("filtroPorIdVenda", Convert.ToInt32(Txt_Codigo.Text));

                    CrystalDecisions.Shared.DiskFileDestinationOptions diskFileDestination = new CrystalDecisions.Shared.DiskFileDestinationOptions()
                    {
                        DiskFileName = path
                    };
                    CrystalDecisions.Shared.ExportOptions createPdf = new CrystalDecisions.Shared.ExportOptions()
                    {
                        ExportDestinationOptions = diskFileDestination,
                        ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                        ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                    };
                    relatorio.Export(createPdf);
                    
                    var mensagem = MessageBox.Show($"Nota de venda exportada para o caminho {save.FileName}.\r\nDeseja abri o arquivo?", "Caminho do arquivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if(mensagem == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PreencheLoad ()
        {
            Txt_Codigo.ReadOnly = true;
            Txt_Codigo.BackColor = Color.White;
            Dtp_DataVenda.Enabled = false;
            Txt_Cliente.ReadOnly = true;
            Txt_Cliente.BackColor = Color.White;
            Txt_Acrescimo.BackColor = Color.White;
            Txt_Acrescimo.ReadOnly = true;
            Txt_Desconto.BackColor = Color.White;
            Txt_Desconto.ReadOnly = true;
            Txt_TotalItens.BackColor = Color.White;
            Txt_TotalItens.ReadOnly = true;
            Txt_totalGeral.BackColor = Color.White;
            Txt_totalGeral.ReadOnly = true;
            Txt_Pagamento.BackColor = Color.White;
            Txt_Pagamento.ReadOnly = true;
            Dgv_ListaProdutos.ReadOnly = true;

            AjusteDataGridView.DataGrid_AlterarVenda(Dgv_ListaProdutos, ItensVenda.BuscaItensPorIdVenda(Venda.IdVenda));
            Txt_Codigo.Text = Venda.IdVenda.ToString("D4");
            Dtp_DataVenda.Value = Venda.DataLancamento;
            Txt_Cliente.Text = Venda.Cliente.Id + " - " + Venda.Cliente.Nome;
            Txt_Acrescimo.Text = Venda.Acrescimo.ToString("C2");
            Txt_Desconto.Text = Venda.Desconto.ToString("C2");
            Txt_TotalItens.Text = Venda.Total_itens.ToString("C2");
            Txt_totalGeral.Text = Venda.Total_geral.ToString("C2");
            Txt_Pagamento.Text = Venda.Pagamento.Descricao;
        }
    }
}
