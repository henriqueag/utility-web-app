using SistemaVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.View
{

    public partial class Frm_ControleEstoque : Form
    {
        public Produtos Produto { get; set; } = new Produtos();
        private Frm_CadastroProduto _frm_CadastroProduto;

        public Frm_ControleEstoque (Frm_CadastroProduto frm_CadastroProduto)
        {
            _frm_CadastroProduto = frm_CadastroProduto;
            InitializeComponent();
        }

        private void Frm_ControleEstoque_Load (object sender, EventArgs e)
        {
            Lbl_ProdDescr.Text = $"" +
                $"CODIGO...: {Produto.Id:D4}\r\n" +
                $"DESCRIÇÃO: {Produto.NomeProduto}\n\r" +
                $"ESTOQUE..: {Produto.Estoque:F2}";
        }

        private void Btn_ok_Click (object sender, EventArgs e)
        {
            try
            {
                if (Rb_entrada.Checked)
                    Produto.UpdateEstoque(Produto.Id, Convert.ToDecimal(Txt_valor.Text), "Entrada");

                if (Rb_saida.Checked)
                    Produto.UpdateEstoque(Produto.Id, Convert.ToDecimal(Txt_valor.Text), "Saída");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
