
namespace SistemaVendas.View
{
    partial class Frm_BuscarVendas
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
            this.Dgv_VendaAnteriores = new System.Windows.Forms.DataGridView();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Gb_FiltroAvancado = new System.Windows.Forms.GroupBox();
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.Txt_NumVendaFim = new System.Windows.Forms.TextBox();
            this.Txt_numVendaInicio = new System.Windows.Forms.TextBox();
            this.Dtp_Fim = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscarCliente = new System.Windows.Forms.Button();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Comp = new System.Windows.Forms.Label();
            this.Lbl_FormaPagamento = new System.Windows.Forms.Label();
            this.Lbl_DataLancamento = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Btn_ExcluirVenda = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Exportar = new System.Windows.Forms.Button();
            this.Btn_NovaVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VendaAnteriores)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.Gb_FiltroAvancado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_VendaAnteriores
            // 
            this.Dgv_VendaAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_VendaAnteriores.Location = new System.Drawing.Point(12, 190);
            this.Dgv_VendaAnteriores.Name = "Dgv_VendaAnteriores";
            this.Dgv_VendaAnteriores.Size = new System.Drawing.Size(907, 362);
            this.Dgv_VendaAnteriores.TabIndex = 0;
            this.Dgv_VendaAnteriores.TabStop = false;
            this.Dgv_VendaAnteriores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_VendaAnteriores_CellDoubleClick);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTitle.Controls.Add(this.Btn_Fechar);
            this.PanelTitle.Controls.Add(this.Lbl_Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(931, 53);
            this.PanelTitle.TabIndex = 6;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.FlatAppearance.BorderSize = 0;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Image = global::SistemaVendas.Properties.Resources.fechar;
            this.Btn_Fechar.Location = new System.Drawing.Point(877, 14);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Fechar.TabIndex = 1;
            this.Btn_Fechar.TabStop = false;
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(17, 19);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(185, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Vendas anteriores";
            // 
            // Gb_FiltroAvancado
            // 
            this.Gb_FiltroAvancado.Controls.Add(this.Btn_LimparFiltro);
            this.Gb_FiltroAvancado.Controls.Add(this.Btn_Filtrar);
            this.Gb_FiltroAvancado.Controls.Add(this.Txt_NumVendaFim);
            this.Gb_FiltroAvancado.Controls.Add(this.Txt_numVendaInicio);
            this.Gb_FiltroAvancado.Controls.Add(this.Dtp_Fim);
            this.Gb_FiltroAvancado.Controls.Add(this.Dtp_Inicio);
            this.Gb_FiltroAvancado.Controls.Add(this.Btn_BuscarCliente);
            this.Gb_FiltroAvancado.Controls.Add(this.Txt_Cliente);
            this.Gb_FiltroAvancado.Controls.Add(this.label1);
            this.Gb_FiltroAvancado.Controls.Add(this.Lbl_Comp);
            this.Gb_FiltroAvancado.Controls.Add(this.Lbl_FormaPagamento);
            this.Gb_FiltroAvancado.Controls.Add(this.Lbl_DataLancamento);
            this.Gb_FiltroAvancado.Controls.Add(this.Lbl_Cliente);
            this.Gb_FiltroAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Gb_FiltroAvancado.Location = new System.Drawing.Point(12, 60);
            this.Gb_FiltroAvancado.Name = "Gb_FiltroAvancado";
            this.Gb_FiltroAvancado.Size = new System.Drawing.Size(907, 124);
            this.Gb_FiltroAvancado.TabIndex = 0;
            this.Gb_FiltroAvancado.TabStop = false;
            this.Gb_FiltroAvancado.Text = "Filtro avançado";
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LimparFiltro.Image = global::SistemaVendas.Properties.Resources.UnFilter;
            this.Btn_LimparFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(655, 82);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(118, 30);
            this.Btn_LimparFiltro.TabIndex = 7;
            this.Btn_LimparFiltro.Text = "F10 - Limpar";
            this.Btn_LimparFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filtrar.Image = global::SistemaVendas.Properties.Resources.Filtro;
            this.Btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Filtrar.Location = new System.Drawing.Point(779, 82);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(105, 30);
            this.Btn_Filtrar.TabIndex = 7;
            this.Btn_Filtrar.Text = "F9 - Filtrar";
            this.Btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Filtrar.UseVisualStyleBackColor = true;
            this.Btn_Filtrar.Click += new System.EventHandler(this.Btn_Filtrar_Click);
            // 
            // Txt_NumVendaFim
            // 
            this.Txt_NumVendaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_NumVendaFim.Location = new System.Drawing.Point(800, 47);
            this.Txt_NumVendaFim.MaxLength = 4;
            this.Txt_NumVendaFim.Name = "Txt_NumVendaFim";
            this.Txt_NumVendaFim.Size = new System.Drawing.Size(84, 26);
            this.Txt_NumVendaFim.TabIndex = 4;
            this.Txt_NumVendaFim.Click += new System.EventHandler(this.Txt_NumVendaFim_Click);
            this.Txt_NumVendaFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NumVendaFim_KeyPress);
            this.Txt_NumVendaFim.Leave += new System.EventHandler(this.Txt_NumVendaFim_Leave);
            // 
            // Txt_numVendaInicio
            // 
            this.Txt_numVendaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_numVendaInicio.Location = new System.Drawing.Point(689, 47);
            this.Txt_numVendaInicio.MaxLength = 4;
            this.Txt_numVendaInicio.Name = "Txt_numVendaInicio";
            this.Txt_numVendaInicio.Size = new System.Drawing.Size(84, 26);
            this.Txt_numVendaInicio.TabIndex = 3;
            this.Txt_numVendaInicio.Click += new System.EventHandler(this.Txt_numVendaInicio_Click);
            this.Txt_numVendaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numVendaInicio_KeyPress);
            this.Txt_numVendaInicio.Leave += new System.EventHandler(this.Txt_numVendaInicio_Leave);
            // 
            // Dtp_Fim
            // 
            this.Dtp_Fim.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dtp_Fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dtp_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fim.Location = new System.Drawing.Point(565, 47);
            this.Dtp_Fim.Name = "Dtp_Fim";
            this.Dtp_Fim.Size = new System.Drawing.Size(106, 26);
            this.Dtp_Fim.TabIndex = 2;
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dtp_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Inicio.Location = new System.Drawing.Point(432, 47);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(106, 26);
            this.Dtp_Inicio.TabIndex = 1;
            // 
            // Btn_BuscarCliente
            // 
            this.Btn_BuscarCliente.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarCliente.Image = global::SistemaVendas.Properties.Resources.buscar;
            this.Btn_BuscarCliente.Location = new System.Drawing.Point(390, 47);
            this.Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            this.Btn_BuscarCliente.Size = new System.Drawing.Size(25, 26);
            this.Btn_BuscarCliente.TabIndex = 0;
            this.Btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.Btn_BuscarCliente.Click += new System.EventHandler(this.Btn_BuscarCliente_Click);
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Cliente.Location = new System.Drawing.Point(13, 47);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.Size = new System.Drawing.Size(371, 26);
            this.Txt_Cliente.TabIndex = 1;
            this.Txt_Cliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(778, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // Lbl_Comp
            // 
            this.Lbl_Comp.AutoSize = true;
            this.Lbl_Comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Comp.Location = new System.Drawing.Point(543, 50);
            this.Lbl_Comp.Name = "Lbl_Comp";
            this.Lbl_Comp.Size = new System.Drawing.Size(18, 20);
            this.Lbl_Comp.TabIndex = 0;
            this.Lbl_Comp.Text = "a";
            // 
            // Lbl_FormaPagamento
            // 
            this.Lbl_FormaPagamento.AutoSize = true;
            this.Lbl_FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_FormaPagamento.Location = new System.Drawing.Point(686, 23);
            this.Lbl_FormaPagamento.Name = "Lbl_FormaPagamento";
            this.Lbl_FormaPagamento.Size = new System.Drawing.Size(87, 18);
            this.Lbl_FormaPagamento.TabIndex = 0;
            this.Lbl_FormaPagamento.Text = "Nº da venda";
            // 
            // Lbl_DataLancamento
            // 
            this.Lbl_DataLancamento.AutoSize = true;
            this.Lbl_DataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_DataLancamento.Location = new System.Drawing.Point(429, 23);
            this.Lbl_DataLancamento.Name = "Lbl_DataLancamento";
            this.Lbl_DataLancamento.Size = new System.Drawing.Size(120, 18);
            this.Lbl_DataLancamento.TabIndex = 0;
            this.Lbl_DataLancamento.Text = "Data lançamento";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_Cliente.Location = new System.Drawing.Point(10, 23);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(53, 18);
            this.Lbl_Cliente.TabIndex = 0;
            this.Lbl_Cliente.Text = "Cliente";
            // 
            // Btn_ExcluirVenda
            // 
            this.Btn_ExcluirVenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_ExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExcluirVenda.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_ExcluirVenda.Image = global::SistemaVendas.Properties.Resources.DeletarVenda;
            this.Btn_ExcluirVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirVenda.Location = new System.Drawing.Point(264, 565);
            this.Btn_ExcluirVenda.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.Btn_ExcluirVenda.Name = "Btn_ExcluirVenda";
            this.Btn_ExcluirVenda.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Btn_ExcluirVenda.Size = new System.Drawing.Size(113, 48);
            this.Btn_ExcluirVenda.TabIndex = 8;
            this.Btn_ExcluirVenda.Text = "Excluir";
            this.Btn_ExcluirVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExcluirVenda.UseVisualStyleBackColor = false;
            this.Btn_ExcluirVenda.Click += new System.EventHandler(this.Btn_ExcluirVenda_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Alterar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Alterar.Image = global::SistemaVendas.Properties.Resources.Editar;
            this.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Alterar.Location = new System.Drawing.Point(138, 565);
            this.Btn_Alterar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.Btn_Alterar.Size = new System.Drawing.Size(113, 48);
            this.Btn_Alterar.TabIndex = 9;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Imprimir.Image = global::SistemaVendas.Properties.Resources.Impressora;
            this.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Imprimir.Location = new System.Drawing.Point(523, 565);
            this.Btn_Imprimir.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(120, 48);
            this.Btn_Imprimir.TabIndex = 10;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Exportar
            // 
            this.Btn_Exportar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exportar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Exportar.Image = global::SistemaVendas.Properties.Resources.Exportar;
            this.Btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Exportar.Location = new System.Drawing.Point(390, 565);
            this.Btn_Exportar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.Btn_Exportar.Name = "Btn_Exportar";
            this.Btn_Exportar.Size = new System.Drawing.Size(120, 48);
            this.Btn_Exportar.TabIndex = 10;
            this.Btn_Exportar.Text = "Exportar";
            this.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Exportar.UseVisualStyleBackColor = false;
            // 
            // Btn_NovaVenda
            // 
            this.Btn_NovaVenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_NovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovaVenda.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_NovaVenda.Image = global::SistemaVendas.Properties.Resources.Novo;
            this.Btn_NovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovaVenda.Location = new System.Drawing.Point(12, 565);
            this.Btn_NovaVenda.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
            this.Btn_NovaVenda.Name = "Btn_NovaVenda";
            this.Btn_NovaVenda.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Btn_NovaVenda.Size = new System.Drawing.Size(113, 48);
            this.Btn_NovaVenda.TabIndex = 7;
            this.Btn_NovaVenda.Text = "Novo";
            this.Btn_NovaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NovaVenda.UseVisualStyleBackColor = false;
            this.Btn_NovaVenda.Click += new System.EventHandler(this.Btn_NovaVenda_Click);
            // 
            // Frm_BuscarVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(931, 630);
            this.Controls.Add(this.Btn_ExcluirVenda);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Exportar);
            this.Controls.Add(this.Btn_NovaVenda);
            this.Controls.Add(this.Gb_FiltroAvancado);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.Dgv_VendaAnteriores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_BuscarVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas anteriores";
            this.Load += new System.EventHandler(this.Frm_BuscarVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_BuscarVendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VendaAnteriores)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.Gb_FiltroAvancado.ResumeLayout(false);
            this.Gb_FiltroAvancado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_VendaAnteriores;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.GroupBox Gb_FiltroAvancado;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.DateTimePicker Dtp_Fim;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.Button Btn_BuscarCliente;
        private System.Windows.Forms.Label Lbl_Comp;
        private System.Windows.Forms.Label Lbl_DataLancamento;
        private System.Windows.Forms.Label Lbl_FormaPagamento;
        private System.Windows.Forms.TextBox Txt_NumVendaFim;
        private System.Windows.Forms.TextBox Txt_numVendaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        private System.Windows.Forms.Button Btn_NovaVenda;
        private System.Windows.Forms.Button Btn_ExcluirVenda;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Exportar;
        private System.Windows.Forms.Button Btn_Imprimir;
    }
}