using SistemaVendas.Model;
using System;
using System.Windows.Forms;

namespace SistemaVendas.View
{
    public partial class Frm_CadEmailEmitente : Form
    {
        private Email_emitente _emitente = new Email_emitente();

        public Frm_CadEmailEmitente ()
        {
            InitializeComponent();
            Btn_Gravar.Enabled = false;
        }

        private void Btn_Testar_Click (object sender, EventArgs e)
        {
            bool enableSSL = false;
            if (Check_SSL.CheckState == CheckState.Checked)            
                enableSSL = true;

            try
            {
                _emitente = new Email_emitente(Txt_Smtp.Text, Txt_email.Text, Txt_Senha.Text, Convert.ToInt32(Txt_Porta.Text), enableSSL);
                _emitente.EnviarEmail(_emitente, "Teste de envio de email", "Realizado teste de envio de email", _emitente.Email);
                Btn_Gravar.Enabled = true;
                MessageBox.Show("E-mail teste enviado com sucesso", "E-mail do emitente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao envia o email, verifique os dados e tente novamente.", "E-mail do emitente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Porta_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Btn_Gravar_Click (object sender, EventArgs e)
        {
            try
            {
                _emitente.InsertEmail(_emitente);
                MessageBox.Show("E-mail cadastrado com sucesso", "E-mail do emitente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "E-mail do emitente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_CadEmailEmitente_Load (object sender, EventArgs e)
        {
            try
            {
                _emitente = _emitente.SelectEmail();
                Txt_Smtp.Text = _emitente.ServidorSMTP;
                Txt_email.Text = _emitente.Email;
                Txt_Porta.Text = _emitente.Porta.ToString();
                Txt_Senha.Text = _emitente.SenhaEmail;
                Check_SSL.Checked = _emitente.EnableSSL == true ? Check_SSL.Checked = true : Check_SSL.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
