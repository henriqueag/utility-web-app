using SistemaVendas.Model;
using System;
using System.Data;
using System.Windows.Forms;
using SistemaVendas.Utilitario;

namespace SistemaVendas.View
{
    public partial class Frm_BuscaClientes : Form
    {
        public Clientes Cliente { get; private set; } = new Clientes();

        public Frm_BuscaClientes ()
        {
            InitializeComponent();
        }

        private void Frm_BuscaClientes_Load (object sender, EventArgs e)
        {
            AjusteDataGridView.DataGrid_ListaClientes(Dgv_BuscaClientes, Cliente.SelectAll());
        }

        private void Frm_BuscaClientes_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                DataRowView row = (DataRowView)Dgv_BuscaClientes.CurrentRow.DataBoundItem;
                Cliente = new Clientes(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), Convert.ToDateTime(row[3]), row[4].ToString());
                Close();
            }
        }

        private void Txt_Buscar_KeyPress (object sender, KeyPressEventArgs e)
        {
            AjusteDataGridView.DataGrid_ListaClientes(Dgv_BuscaClientes, Cliente.FiltroCliente(Txt_Buscar.Text));
        }

        private void Dgv_BuscaClientes_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_BuscaClientes.SelectedRows.Count < 1)
                return;

            if (Dgv_BuscaClientes.Rows[e.RowIndex].DataBoundItem != null)
            {
                DataRowView row = (DataRowView)Dgv_BuscaClientes.CurrentRow.DataBoundItem;
                Cliente = new Clientes(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), Convert.ToDateTime(row[3]), row[4].ToString());
                Close();
            }
            else
                MessageBox.Show("Por favor selecione um cliente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
