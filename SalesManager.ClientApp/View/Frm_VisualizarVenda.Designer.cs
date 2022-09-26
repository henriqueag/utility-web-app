
namespace SistemaVendas.View
{
    partial class Frm_VisualizarVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Dtp_DataVenda = new System.Windows.Forms.DateTimePicker();
            this.Gb_InformacoesVenda = new System.Windows.Forms.GroupBox();
            this.Txt_Pagamento = new System.Windows.Forms.TextBox();
            this.Lbl_formaPagamento = new System.Windows.Forms.Label();
            this.Lbl_DataVenda = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Dgv_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.Txt_totalGeral = new System.Windows.Forms.TextBox();
            this.Txt_TotalItens = new System.Windows.Forms.TextBox();
            this.Lbl_TotalGeral = new System.Windows.Forms.Label();
            this.Lbl_TotalItens = new System.Windows.Forms.Label();
            this.Lbl_Acrescimo = new System.Windows.Forms.Label();
            this.Lbl_Desconto = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Txt_Acrescimo = new SistemaVendas.Componentes.TextBoxNumero();
            this.Txt_Desconto = new SistemaVendas.Componentes.TextBoxNumero();
            this.Gb_InformacoesVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaProdutos)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_cliente.Location = new System.Drawing.Point(263, 35);
            this.Lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(58, 20);
            this.Lbl_cliente.TabIndex = 0;
            this.Lbl_cliente.Text = "Cliente";
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.BackColor = System.Drawing.Color.White;
            this.Txt_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Cliente.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_Cliente.Location = new System.Drawing.Point(267, 62);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Cliente.MaxLength = 255;
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.Size = new System.Drawing.Size(335, 26);
            this.Txt_Cliente.TabIndex = 1;
            this.Txt_Cliente.TabStop = false;
            // 
            // Dtp_DataVenda
            // 
            this.Dtp_DataVenda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataVenda.Location = new System.Drawing.Point(138, 62);
            this.Dtp_DataVenda.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Dtp_DataVenda.Name = "Dtp_DataVenda";
            this.Dtp_DataVenda.Size = new System.Drawing.Size(109, 26);
            this.Dtp_DataVenda.TabIndex = 1;
            // 
            // Gb_InformacoesVenda
            // 
            this.Gb_InformacoesVenda.Controls.Add(this.Txt_Pagamento);
            this.Gb_InformacoesVenda.Controls.Add(this.Txt_Cliente);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_cliente);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_formaPagamento);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_DataVenda);
            this.Gb_InformacoesVenda.Controls.Add(this.Txt_Codigo);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_Codigo);
            this.Gb_InformacoesVenda.Controls.Add(this.Dtp_DataVenda);
            this.Gb_InformacoesVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_InformacoesVenda.Location = new System.Drawing.Point(22, 73);
            this.Gb_InformacoesVenda.Name = "Gb_InformacoesVenda";
            this.Gb_InformacoesVenda.Size = new System.Drawing.Size(837, 114);
            this.Gb_InformacoesVenda.TabIndex = 1;
            this.Gb_InformacoesVenda.TabStop = false;
            this.Gb_InformacoesVenda.Text = "Informação da venda";
            // 
            // Txt_Pagamento
            // 
            this.Txt_Pagamento.BackColor = System.Drawing.Color.White;
            this.Txt_Pagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Pagamento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_Pagamento.Location = new System.Drawing.Point(628, 62);
            this.Txt_Pagamento.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Pagamento.MaxLength = 255;
            this.Txt_Pagamento.Name = "Txt_Pagamento";
            this.Txt_Pagamento.ReadOnly = true;
            this.Txt_Pagamento.Size = new System.Drawing.Size(186, 26);
            this.Txt_Pagamento.TabIndex = 1;
            this.Txt_Pagamento.TabStop = false;
            // 
            // Lbl_formaPagamento
            // 
            this.Lbl_formaPagamento.AutoSize = true;
            this.Lbl_formaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_formaPagamento.Location = new System.Drawing.Point(624, 35);
            this.Lbl_formaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_formaPagamento.Name = "Lbl_formaPagamento";
            this.Lbl_formaPagamento.Size = new System.Drawing.Size(140, 20);
            this.Lbl_formaPagamento.TabIndex = 0;
            this.Lbl_formaPagamento.Text = "Forma pagamento";
            // 
            // Lbl_DataVenda
            // 
            this.Lbl_DataVenda.AutoSize = true;
            this.Lbl_DataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataVenda.Location = new System.Drawing.Point(134, 35);
            this.Lbl_DataVenda.Name = "Lbl_DataVenda";
            this.Lbl_DataVenda.Size = new System.Drawing.Size(91, 20);
            this.Lbl_DataVenda.TabIndex = 2;
            this.Lbl_DataVenda.Text = "Data venda";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(19, 62);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Codigo.MaxLength = 5;
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.ReadOnly = true;
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.Txt_Codigo.TabIndex = 1;
            this.Txt_Codigo.TabStop = false;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo.Location = new System.Drawing.Point(15, 35);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Codigo.TabIndex = 0;
            this.Lbl_Codigo.Text = "Código";
            // 
            // Dgv_ListaProdutos
            // 
            this.Dgv_ListaProdutos.AllowUserToAddRows = false;
            this.Dgv_ListaProdutos.AllowUserToDeleteRows = false;
            this.Dgv_ListaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_ListaProdutos.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ListaProdutos.Location = new System.Drawing.Point(22, 208);
            this.Dgv_ListaProdutos.Name = "Dgv_ListaProdutos";
            this.Dgv_ListaProdutos.ReadOnly = true;
            this.Dgv_ListaProdutos.Size = new System.Drawing.Size(547, 230);
            this.Dgv_ListaProdutos.TabIndex = 2;
            this.Dgv_ListaProdutos.TabStop = false;
            // 
            // Txt_totalGeral
            // 
            this.Txt_totalGeral.BackColor = System.Drawing.Color.White;
            this.Txt_totalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_totalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_totalGeral.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_totalGeral.Location = new System.Drawing.Point(723, 305);
            this.Txt_totalGeral.Margin = new System.Windows.Forms.Padding(6, 7, 3, 3);
            this.Txt_totalGeral.MaxLength = 255;
            this.Txt_totalGeral.Name = "Txt_totalGeral";
            this.Txt_totalGeral.ReadOnly = true;
            this.Txt_totalGeral.Size = new System.Drawing.Size(113, 26);
            this.Txt_totalGeral.TabIndex = 1;
            this.Txt_totalGeral.TabStop = false;
            // 
            // Txt_TotalItens
            // 
            this.Txt_TotalItens.BackColor = System.Drawing.Color.White;
            this.Txt_TotalItens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_TotalItens.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_TotalItens.Location = new System.Drawing.Point(589, 305);
            this.Txt_TotalItens.Margin = new System.Windows.Forms.Padding(6, 7, 3, 3);
            this.Txt_TotalItens.MaxLength = 255;
            this.Txt_TotalItens.Name = "Txt_TotalItens";
            this.Txt_TotalItens.ReadOnly = true;
            this.Txt_TotalItens.Size = new System.Drawing.Size(113, 26);
            this.Txt_TotalItens.TabIndex = 1;
            this.Txt_TotalItens.TabStop = false;
            // 
            // Lbl_TotalGeral
            // 
            this.Lbl_TotalGeral.AutoSize = true;
            this.Lbl_TotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_TotalGeral.Location = new System.Drawing.Point(719, 278);
            this.Lbl_TotalGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TotalGeral.Name = "Lbl_TotalGeral";
            this.Lbl_TotalGeral.Size = new System.Drawing.Size(83, 20);
            this.Lbl_TotalGeral.TabIndex = 0;
            this.Lbl_TotalGeral.Text = "Total geral";
            // 
            // Lbl_TotalItens
            // 
            this.Lbl_TotalItens.AutoSize = true;
            this.Lbl_TotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_TotalItens.Location = new System.Drawing.Point(585, 278);
            this.Lbl_TotalItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TotalItens.Name = "Lbl_TotalItens";
            this.Lbl_TotalItens.Size = new System.Drawing.Size(82, 20);
            this.Lbl_TotalItens.TabIndex = 0;
            this.Lbl_TotalItens.Text = "Total itens";
            // 
            // Lbl_Acrescimo
            // 
            this.Lbl_Acrescimo.AutoSize = true;
            this.Lbl_Acrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Acrescimo.Location = new System.Drawing.Point(719, 208);
            this.Lbl_Acrescimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Acrescimo.Name = "Lbl_Acrescimo";
            this.Lbl_Acrescimo.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Acrescimo.TabIndex = 0;
            this.Lbl_Acrescimo.Text = "Acréscimo";
            // 
            // Lbl_Desconto
            // 
            this.Lbl_Desconto.AutoSize = true;
            this.Lbl_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Desconto.Location = new System.Drawing.Point(585, 208);
            this.Lbl_Desconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Desconto.Name = "Lbl_Desconto";
            this.Lbl_Desconto.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Desconto.TabIndex = 0;
            this.Lbl_Desconto.Text = "Desconto";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTitle.Controls.Add(this.Btn_Fechar);
            this.PanelTitle.Controls.Add(this.Lbl_Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(884, 53);
            this.PanelTitle.TabIndex = 5;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(17, 19);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(229, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Lançamento de vendas";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.FlatAppearance.BorderSize = 0;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Image = global::SistemaVendas.Properties.Resources.fechar;
            this.Btn_Fechar.Location = new System.Drawing.Point(834, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Fechar.TabIndex = 1;
            this.Btn_Fechar.TabStop = false;
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Txt_Acrescimo
            // 
            this.Txt_Acrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Acrescimo.Location = new System.Drawing.Point(723, 235);
            this.Txt_Acrescimo.Margin = new System.Windows.Forms.Padding(6, 7, 3, 3);
            this.Txt_Acrescimo.MaxLength = 5;
            this.Txt_Acrescimo.Name = "Txt_Acrescimo";
            this.Txt_Acrescimo.Size = new System.Drawing.Size(113, 26);
            this.Txt_Acrescimo.TabIndex = 10;
            this.Txt_Acrescimo.TabStop = false;
            this.Txt_Acrescimo.Text = "0,00";
            this.Txt_Acrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Desconto
            // 
            this.Txt_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Desconto.Location = new System.Drawing.Point(588, 235);
            this.Txt_Desconto.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Desconto.MaxLength = 5;
            this.Txt_Desconto.Name = "Txt_Desconto";
            this.Txt_Desconto.Size = new System.Drawing.Size(113, 26);
            this.Txt_Desconto.TabIndex = 9;
            this.Txt_Desconto.TabStop = false;
            this.Txt_Desconto.Text = "0,00";
            this.Txt_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_VisualizarVenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 472);
            this.Controls.Add(this.Txt_totalGeral);
            this.Controls.Add(this.Txt_Acrescimo);
            this.Controls.Add(this.Txt_TotalItens);
            this.Controls.Add(this.Dgv_ListaProdutos);
            this.Controls.Add(this.Lbl_TotalGeral);
            this.Controls.Add(this.Txt_Desconto);
            this.Controls.Add(this.Lbl_TotalItens);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.Gb_InformacoesVenda);
            this.Controls.Add(this.Lbl_Acrescimo);
            this.Controls.Add(this.Lbl_Desconto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_VisualizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de venda";
            this.Load += new System.EventHandler(this.Frm_VisualizarVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_VisualizarVenda_KeyDown);
            this.Gb_InformacoesVenda.ResumeLayout(false);
            this.Gb_InformacoesVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaProdutos)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.DateTimePicker Dtp_DataVenda;
        private System.Windows.Forms.GroupBox Gb_InformacoesVenda;
        private System.Windows.Forms.Label Lbl_DataVenda;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.DataGridView Dgv_ListaProdutos;
        private System.Windows.Forms.Label Lbl_Acrescimo;
        private System.Windows.Forms.Label Lbl_Desconto;
        private System.Windows.Forms.TextBox Txt_totalGeral;
        private System.Windows.Forms.TextBox Txt_TotalItens;
        private System.Windows.Forms.Label Lbl_TotalGeral;
        private System.Windows.Forms.Label Lbl_TotalItens;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_formaPagamento;
        private Componentes.TextBoxNumero Txt_Acrescimo;
        private Componentes.TextBoxNumero Txt_Desconto;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.TextBox Txt_Pagamento;
        public System.Windows.Forms.TextBox Txt_Codigo;
    }
}