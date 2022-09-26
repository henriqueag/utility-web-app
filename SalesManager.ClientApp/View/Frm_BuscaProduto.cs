using System;
using System.Data;
using System.Windows.Forms;
using SistemaVendas.Model;
using SistemaVendas.Utilitario;

namespace SistemaVendas.View
{
    public partial class Frm_BuscaProduto : Form
    {
        public Produtos Produto { get; private set; } = new Produtos();

        public Frm_BuscaProduto ()
        {
            InitializeComponent();
        }

        private void Frm_BuscaClientes_Load (object sender, EventArgs e)
        {
            AjusteDataGridView.DataGrid_ListaProdutos(Dgv_BuscaProdutos, Produto.SelectAll());
        }

        private void Frm_BuscaProduto_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                DataRowView row = (DataRowView)Dgv_BuscaProdutos.CurrentRow.DataBoundItem;
                Produto = new Produtos(Convert.ToInt32(row[0]), row[1].ToString(), Convert.ToDecimal(row[2]), Convert.ToDecimal(row[3]));
                Close();
            }
        }

        private void Txt_Buscar_KeyPress (object sender, KeyPressEventArgs e)
        {
            AjusteDataGridView.DataGrid_ListaProdutos(Dgv_BuscaProdutos, Produto.FiltroProduto(Txt_Buscar.Text));
        }

        private void Dgv_BuscaProdutos_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_BuscaProdutos.SelectedRows.Count < 1)
                return;

            if (Dgv_BuscaProdutos.Rows[e.RowIndex].DataBoundItem != null)
            {
                DataRowView row = (DataRowView)Dgv_BuscaProdutos.CurrentRow.DataBoundItem;
                Produto = new Produtos(Convert.ToInt32(row[0]), row[1].ToString(), Convert.ToDecimal(row[2]), Convert.ToDecimal(row[3]), Convert.ToBoolean(row[4]));
                Close();
            }
            else
                MessageBox.Show("Por favor selecione um produto.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
