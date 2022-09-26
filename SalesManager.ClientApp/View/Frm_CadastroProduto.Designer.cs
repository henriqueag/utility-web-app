
namespace SistemaVendas.View
{
    partial class Frm_CadastroProduto
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
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Check_Ativo = new System.Windows.Forms.CheckBox();
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.Lbl_Estoque = new System.Windows.Forms.Label();
            this.Txt_Estoque = new System.Windows.Forms.TextBox();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.PanelComp = new System.Windows.Forms.Panel();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Estoque = new System.Windows.Forms.Button();
            this.Txt_VlrUnitario = new SistemaVendas.Componentes.TextBoxNumero();
            this.PanelTitle.SuspendLayout();
            this.PanelComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTitle.Controls.Add(this.Lbl_Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(631, 66);
            this.PanelTitle.TabIndex = 7;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(19, 20);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(217, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Cadastro de produtos";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo.Location = new System.Drawing.Point(20, 15);
            this.Lbl_Codigo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(71, 23);
            this.Lbl_Codigo.TabIndex = 8;
            this.Lbl_Codigo.Text = "Código";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Txt_codigo.Location = new System.Drawing.Point(24, 46);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_codigo.MaxLength = 5;
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.ReadOnly = true;
            this.Txt_codigo.Size = new System.Drawing.Size(100, 30);
            this.Txt_codigo.TabIndex = 9;
            this.Txt_codigo.TabStop = false;
            // 
            // Check_Ativo
            // 
            this.Check_Ativo.AutoSize = true;
            this.Check_Ativo.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Check_Ativo.Location = new System.Drawing.Point(433, 128);
            this.Check_Ativo.Name = "Check_Ativo";
            this.Check_Ativo.Size = new System.Drawing.Size(72, 27);
            this.Check_Ativo.TabIndex = 11;
            this.Check_Ativo.Text = "Ativo";
            this.Check_Ativo.UseVisualStyleBackColor = true;
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.AutoSize = true;
            this.Lbl_Descricao.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descricao.Location = new System.Drawing.Point(165, 15);
            this.Lbl_Descricao.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(94, 23);
            this.Lbl_Descricao.TabIndex = 8;
            this.Lbl_Descricao.Text = "Descrição";
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Descricao.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Txt_Descricao.Location = new System.Drawing.Point(169, 46);
            this.Txt_Descricao.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_Descricao.MaxLength = 180;
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(432, 30);
            this.Txt_Descricao.TabIndex = 9;
            // 
            // Lbl_Estoque
            // 
            this.Lbl_Estoque.AutoSize = true;
            this.Lbl_Estoque.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estoque.Location = new System.Drawing.Point(20, 94);
            this.Lbl_Estoque.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Estoque.Name = "Lbl_Estoque";
            this.Lbl_Estoque.Size = new System.Drawing.Size(79, 23);
            this.Lbl_Estoque.TabIndex = 8;
            this.Lbl_Estoque.Text = "Estoque";
            // 
            // Txt_Estoque
            // 
            this.Txt_Estoque.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Txt_Estoque.Location = new System.Drawing.Point(24, 125);
            this.Txt_Estoque.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Txt_Estoque.MaxLength = 15;
            this.Txt_Estoque.Name = "Txt_Estoque";
            this.Txt_Estoque.ReadOnly = true;
            this.Txt_Estoque.Size = new System.Drawing.Size(163, 30);
            this.Txt_Estoque.TabIndex = 9;
            this.Txt_Estoque.TabStop = false;
            this.Txt_Estoque.Text = "0,00";
            this.Txt_Estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.Location = new System.Drawing.Point(243, 94);
            this.Lbl_Preco.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(129, 23);
            this.Lbl_Preco.TabIndex = 8;
            this.Lbl_Preco.Text = "Preço Unitário";
            // 
            // PanelComp
            // 
            this.PanelComp.Controls.Add(this.Txt_VlrUnitario);
            this.PanelComp.Controls.Add(this.Check_Ativo);
            this.PanelComp.Controls.Add(this.Txt_Estoque);
            this.PanelComp.Controls.Add(this.Txt_Descricao);
            this.PanelComp.Controls.Add(this.Btn_Estoque);
            this.PanelComp.Controls.Add(this.Lbl_Preco);
            this.PanelComp.Controls.Add(this.Lbl_Estoque);
            this.PanelComp.Controls.Add(this.Txt_codigo);
            this.PanelComp.Controls.Add(this.Lbl_Descricao);
            this.PanelComp.Controls.Add(this.Lbl_Codigo);
            this.PanelComp.Location = new System.Drawing.Point(0, 69);
            this.PanelComp.Name = "PanelComp";
            this.PanelComp.Size = new System.Drawing.Size(631, 281);
            this.PanelComp.TabIndex = 14;
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Gravar.Image = global::SistemaVendas.Properties.Resources.Salvar;
            this.Btn_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Gravar.Location = new System.Drawing.Point(367, 255);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Gravar.Size = new System.Drawing.Size(114, 55);
            this.Btn_Gravar.TabIndex = 13;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Gravar.UseVisualStyleBackColor = false;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Excluir.Image = global::SistemaVendas.Properties.Resources.DeletarVenda;
            this.Btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Excluir.Location = new System.Drawing.Point(247, 255);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Excluir.Size = new System.Drawing.Size(114, 55);
            this.Btn_Excluir.TabIndex = 13;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Excluir.UseVisualStyleBackColor = false;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.Image = global::SistemaVendas.Properties.Resources.Novo;
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.Location = new System.Drawing.Point(487, 255);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Buscar.Size = new System.Drawing.Size(114, 55);
            this.Btn_Buscar.TabIndex = 13;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Novo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Novo.Image = global::SistemaVendas.Properties.Resources.Novo;
            this.Btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Novo.Location = new System.Drawing.Point(24, 255);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Novo.Size = new System.Drawing.Size(97, 55);
            this.Btn_Novo.TabIndex = 13;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Novo.UseVisualStyleBackColor = false;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Alterar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Alterar.Image = global::SistemaVendas.Properties.Resources.Editar;
            this.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Alterar.Location = new System.Drawing.Point(127, 255);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Alterar.Size = new System.Drawing.Size(114, 55);
            this.Btn_Alterar.TabIndex = 13;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Estoque
            // 
            this.Btn_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Estoque.FlatAppearance.BorderSize = 0;
            this.Btn_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estoque.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_Estoque.Image = global::SistemaVendas.Properties.Resources.Estoque;
            this.Btn_Estoque.Location = new System.Drawing.Point(196, 125);
            this.Btn_Estoque.Name = "Btn_Estoque";
            this.Btn_Estoque.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Btn_Estoque.Size = new System.Drawing.Size(30, 30);
            this.Btn_Estoque.TabIndex = 13;
            this.Btn_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estoque.UseVisualStyleBackColor = false;
            this.Btn_Estoque.Click += new System.EventHandler(this.Btn_Estoque_Click);
            // 
            // Txt_VlrUnitario
            // 
            this.Txt_VlrUnitario.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Txt_VlrUnitario.Location = new System.Drawing.Point(247, 125);
            this.Txt_VlrUnitario.Name = "Txt_VlrUnitario";
            this.Txt_VlrUnitario.Size = new System.Drawing.Size(146, 30);
            this.Txt_VlrUnitario.TabIndex = 12;
            this.Txt_VlrUnitario.Text = "0,00";
            this.Txt_VlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_CadastroProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 351);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelComp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.Frm_CadastroProduto_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelComp.ResumeLayout(false);
            this.PanelComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.CheckBox Check_Ativo;
        private System.Windows.Forms.Label Lbl_Descricao;
        private System.Windows.Forms.TextBox Txt_Descricao;
        private System.Windows.Forms.Label Lbl_Estoque;
        private System.Windows.Forms.TextBox Txt_Estoque;
        private Componentes.TextBoxNumero Txt_VlrUnitario;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Panel PanelComp;
        private System.Windows.Forms.Button Btn_Estoque;
    }
}