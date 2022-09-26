
namespace SistemaVendas.View
{
    partial class Frm_ControleEstoque
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
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Rb_entrada = new System.Windows.Forms.RadioButton();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Lbl_ProdDescr = new System.Windows.Forms.Label();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.Txt_valor = new SistemaVendas.Componentes.TextBoxNumero();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Rb_saida = new System.Windows.Forms.RadioButton();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(19, 20);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(203, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Controle de estoque";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTitle.Controls.Add(this.Lbl_Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(454, 66);
            this.PanelTitle.TabIndex = 8;
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.AutoSize = true;
            this.Lbl_Descricao.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descricao.Location = new System.Drawing.Point(20, 91);
            this.Lbl_Descricao.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(210, 23);
            this.Lbl_Descricao.TabIndex = 10;
            this.Lbl_Descricao.Text = "Tipo de movimentação:";
            // 
            // Rb_entrada
            // 
            this.Rb_entrada.AutoSize = true;
            this.Rb_entrada.Checked = true;
            this.Rb_entrada.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Rb_entrada.Location = new System.Drawing.Point(236, 89);
            this.Rb_entrada.Name = "Rb_entrada";
            this.Rb_entrada.Size = new System.Drawing.Size(92, 27);
            this.Rb_entrada.TabIndex = 11;
            this.Rb_entrada.TabStop = true;
            this.Rb_entrada.Text = "Entrada";
            this.Rb_entrada.UseVisualStyleBackColor = true;
            // 
            // Lbl_Produto
            // 
            this.Lbl_Produto.AutoSize = true;
            this.Lbl_Produto.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produto.Location = new System.Drawing.Point(20, 129);
            this.Lbl_Produto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(77, 23);
            this.Lbl_Produto.TabIndex = 10;
            this.Lbl_Produto.Text = "Produto";
            // 
            // Lbl_ProdDescr
            // 
            this.Lbl_ProdDescr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_ProdDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_ProdDescr.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProdDescr.Location = new System.Drawing.Point(24, 160);
            this.Lbl_ProdDescr.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_ProdDescr.Name = "Lbl_ProdDescr";
            this.Lbl_ProdDescr.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Lbl_ProdDescr.Size = new System.Drawing.Size(385, 83);
            this.Lbl_ProdDescr.TabIndex = 10;
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.AutoSize = true;
            this.Lbl_Quantidade.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantidade.Location = new System.Drawing.Point(20, 275);
            this.Lbl_Quantidade.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(111, 23);
            this.Lbl_Quantidade.TabIndex = 10;
            this.Lbl_Quantidade.Text = "Quantidade:";
            // 
            // Txt_valor
            // 
            this.Txt_valor.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Txt_valor.Location = new System.Drawing.Point(137, 268);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(129, 30);
            this.Txt_valor.TabIndex = 12;
            this.Txt_valor.Text = "0,00";
            this.Txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_ok
            // 
            this.Btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ok.FlatAppearance.BorderSize = 2;
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ok.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ok.ForeColor = System.Drawing.Color.White;
            this.Btn_ok.Location = new System.Drawing.Point(334, 255);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 43);
            this.Btn_ok.TabIndex = 13;
            this.Btn_ok.Text = "Ok";
            this.Btn_ok.UseVisualStyleBackColor = false;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Rb_saida
            // 
            this.Rb_saida.AutoSize = true;
            this.Rb_saida.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.Rb_saida.Location = new System.Drawing.Point(334, 89);
            this.Rb_saida.Name = "Rb_saida";
            this.Rb_saida.Size = new System.Drawing.Size(75, 27);
            this.Rb_saida.TabIndex = 11;
            this.Rb_saida.Text = "Saída";
            this.Rb_saida.UseVisualStyleBackColor = true;
            // 
            // Frm_ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.Txt_valor);
            this.Controls.Add(this.Rb_saida);
            this.Controls.Add(this.Rb_entrada);
            this.Controls.Add(this.Lbl_ProdDescr);
            this.Controls.Add(this.Lbl_Produto);
            this.Controls.Add(this.Lbl_Quantidade);
            this.Controls.Add(this.Lbl_Descricao);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ControleEstoque";
            this.Text = "Controle de estoque";
            this.Load += new System.EventHandler(this.Frm_ControleEstoque_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Descricao;
        private System.Windows.Forms.RadioButton Rb_entrada;
        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.Label Lbl_ProdDescr;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private Componentes.TextBoxNumero Txt_valor;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.RadioButton Rb_saida;
    }
}