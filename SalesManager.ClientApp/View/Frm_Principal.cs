using System;
using System.Windows.Forms;

namespace SistemaVendas.View
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal ()
        {
            InitializeComponent();
        }

        private void Btn_Vendas_Click (object sender, EventArgs e)
        {
            Frm_BuscarVendas frm = new Frm_BuscarVendas(this)
            {
                TopLevel = false
            };
            PanelFrames.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Frm_Principal_FormClosing (object sender, FormClosingEventArgs e)
        {
            DAO.Conexao.BackupBancoDados();
        }
    }
}
