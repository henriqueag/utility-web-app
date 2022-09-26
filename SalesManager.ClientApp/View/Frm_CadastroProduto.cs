using SistemaVendas.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas.Utilitario;
using SistemaVendas.Model;

namespace SistemaVendas.View
{
    public partial class Frm_CadastroProduto : Form
    {
        private Produtos _produto = new Produtos();

        public Frm_CadastroProduto ()
        {
            InitializeComponent();
        }

        private void Frm_CadastroProduto_Load (object sender, EventArgs e)
        {

        }

        private void Btn_Novo_Click (object sender, EventArgs e)
        {
            Txt_codigo.Text = _produto.BuscaProximoId().ToString("D4");
        }

        private void Btn_Buscar_Click (object sender, EventArgs e)
        {
            using (Frm_BuscaProduto frm = new Frm_BuscaProduto())
            {
                frm.BringToFront();
                frm.ShowDialog();
                if (frm.Produto.Id == 0)
                    return;
                else
                    _produto = frm.Produto;
            }
            if (_produto != null)
            {
                Txt_codigo.Text = _produto.Id.ToString("D4");
                Txt_Descricao.Text = _produto.NomeProduto;
                Txt_Estoque.Text = _produto.Estoque.ToString("F2");
                Txt_VlrUnitario.Text = _produto.Preco.ToString("F2");
                Check_Ativo.Checked = _produto.Ativo;
                Check_Ativo.CheckState = Check_Ativo.Checked == true ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        private void Btn_Gravar_Click (object sender, EventArgs e)
        {
            try
            {
                PreencheProduto();
                _produto.InsertProduto(_produto);
                MessageBox.Show("Produto cadastrado com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar cadastrar o produto no banco de dados.\n{_produto.produtoDAO.MensagemErro}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheProduto ()
        {
            bool ativo = false;
            if (Check_Ativo.Checked)
                ativo = true;
            _produto = new Produtos(Convert.ToInt32(Txt_codigo.Text), Txt_Descricao.Text, Convert.ToDecimal(Txt_Estoque.Text), Convert.ToDecimal(Txt_VlrUnitario.Text), ativo);
        }

        private void Btn_Excluir_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_codigo.Text))
            {
                MessageBox.Show("Selecione o produto que deseja excluir.", "Exclusão de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var mensagem = MessageBox.Show("Deseja realmente excluir esse produto?", "Exclusão de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (mensagem == DialogResult.OK)
            {
                try
                {
                    _produto.DeleteProduto(Convert.ToInt32(Txt_codigo.Text));
                    MessageBox.Show("Produto excluído com sucesso.", "Exclusão de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar excluir o produto do banco de dados.\n{_produto.produtoDAO.MensagemErro}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Alterar_Click (object sender, EventArgs e)
        {
            if (_produto != null && _produto.Id != 0)
            {
                try
                {
                    PreencheProduto();
                    _produto.UpdateProduto(_produto);
                    MessageBox.Show("Cadastro alterado com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar alterar o cadastro do produto.\n{_produto.produtoDAO.MensagemErro}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Estoque_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_codigo.Text))
            {
                MessageBox.Show("Selecione o produto que deseja movimentar o estoque.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Frm_ControleEstoque frm = new Frm_ControleEstoque(this);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Produto = _produto;
            frm.BringToFront();
            frm.ShowDialog();
        }
    }
}
