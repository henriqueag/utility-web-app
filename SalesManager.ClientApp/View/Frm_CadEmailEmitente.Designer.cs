
namespace SistemaVendas.View
{
    partial class Frm_CadEmailEmitente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Lbl_smtp = new System.Windows.Forms.Label();
            this.Txt_Smtp = new System.Windows.Forms.TextBox();
            this.Btn_Testar = new System.Windows.Forms.Button();
            this.Lbl_Porta = new System.Windows.Forms.Label();
            this.Txt_Porta = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Check_SSL = new System.Windows.Forms.CheckBox();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(19, 23);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(190, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "E-mail do emitente";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTitle.Controls.Add(this.Lbl_Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(422, 66);
            this.PanelTitle.TabIndex = 7;
            // 
            // Lbl_smtp
            // 
            this.Lbl_smtp.AutoSize = true;
            this.Lbl_smtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_smtp.Location = new System.Drawing.Point(22, 87);
            this.Lbl_smtp.Name = "Lbl_smtp";
            this.Lbl_smtp.Size = new System.Drawing.Size(132, 22);
            this.Lbl_smtp.TabIndex = 8;
            this.Lbl_smtp.Text = "Servidor SMTP";
            // 
            // Txt_Smtp
            // 
            this.Txt_Smtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Smtp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Smtp.Location = new System.Drawing.Point(26, 117);
            this.Txt_Smtp.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_Smtp.MaxLength = 24;
            this.Txt_Smtp.Name = "Txt_Smtp";
            this.Txt_Smtp.Size = new System.Drawing.Size(220, 26);
            this.Txt_Smtp.TabIndex = 1;
            // 
            // Btn_Testar
            // 
            this.Btn_Testar.AutoSize = true;
            this.Btn_Testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Testar.Location = new System.Drawing.Point(160, 291);
            this.Btn_Testar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Btn_Testar.Name = "Btn_Testar";
            this.Btn_Testar.Size = new System.Drawing.Size(108, 36);
            this.Btn_Testar.TabIndex = 6;
            this.Btn_Testar.Text = "Testar";
            this.Btn_Testar.UseVisualStyleBackColor = true;
            this.Btn_Testar.Click += new System.EventHandler(this.Btn_Testar_Click);
            // 
            // Lbl_Porta
            // 
            this.Lbl_Porta.AutoSize = true;
            this.Lbl_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_Porta.Location = new System.Drawing.Point(264, 87);
            this.Lbl_Porta.Name = "Lbl_Porta";
            this.Lbl_Porta.Size = new System.Drawing.Size(53, 22);
            this.Lbl_Porta.TabIndex = 8;
            this.Lbl_Porta.Text = "Porta";
            // 
            // Txt_Porta
            // 
            this.Txt_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Porta.Location = new System.Drawing.Point(268, 117);
            this.Txt_Porta.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_Porta.MaxLength = 10;
            this.Txt_Porta.Name = "Txt_Porta";
            this.Txt_Porta.Size = new System.Drawing.Size(124, 26);
            this.Txt_Porta.TabIndex = 2;
            this.Txt_Porta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Porta_KeyPress);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_Email.Location = new System.Drawing.Point(22, 154);
            this.Lbl_Email.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(60, 22);
            this.Lbl_Email.TabIndex = 8;
            this.Lbl_Email.Text = "E-mail";
            // 
            // Txt_email
            // 
            this.Txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_email.Location = new System.Drawing.Point(26, 184);
            this.Txt_email.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_email.MaxLength = 50;
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(366, 26);
            this.Txt_email.TabIndex = 3;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_Senha.Location = new System.Drawing.Point(22, 221);
            this.Lbl_Senha.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(62, 22);
            this.Lbl_Senha.TabIndex = 8;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Senha.Location = new System.Drawing.Point(26, 251);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_Senha.MaxLength = 24;
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(220, 26);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Check_SSL
            // 
            this.Check_SSL.AutoSize = true;
            this.Check_SSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Check_SSL.Location = new System.Drawing.Point(271, 251);
            this.Check_SSL.Name = "Check_SSL";
            this.Check_SSL.Size = new System.Drawing.Size(121, 24);
            this.Check_SSL.TabIndex = 5;
            this.Check_SSL.Text = "Habilitar SSL";
            this.Check_SSL.UseVisualStyleBackColor = true;
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.AutoSize = true;
            this.Btn_Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Gravar.Location = new System.Drawing.Point(286, 291);
            this.Btn_Gravar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(106, 36);
            this.Btn_Gravar.TabIndex = 7;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Frm_CadEmailEmitente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(422, 346);
            this.Controls.Add(this.Check_SSL);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Testar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Porta);
            this.Controls.Add(this.Lbl_Porta);
            this.Controls.Add(this.Txt_Smtp);
            this.Controls.Add(this.Lbl_smtp);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadEmailEmitente";
            this.ShowIcon = false;
            this.Text = "E-mail emitente";
            this.Load += new System.EventHandler(this.Frm_CadEmailEmitente_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_smtp;
        private System.Windows.Forms.TextBox Txt_Smtp;
        private System.Windows.Forms.Button Btn_Testar;
        private System.Windows.Forms.Label Lbl_Porta;
        private System.Windows.Forms.TextBox Txt_Porta;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.CheckBox Check_SSL;
        private System.Windows.Forms.Button Btn_Gravar;
    }
}