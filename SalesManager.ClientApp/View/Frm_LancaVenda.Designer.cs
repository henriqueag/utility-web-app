
namespace SistemaVendas.View
{
    partial class Frm_LancaVenda
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
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Dtp_DataVenda = new System.Windows.Forms.DateTimePicker();
            this.Gb_InformacoesVenda = new System.Windows.Forms.GroupBox();
            this.Cbx_Pagamento = new System.Windows.Forms.ComboBox();
            this.Lbl_DataVenda = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Btn_BuscarCliente = new System.Windows.Forms.Button();
            this.Lbl_formaPagamento = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Gb_Produtos = new System.Windows.Forms.GroupBox();
            this.Txt_VlrUnitario = new SistemaVendas.Componentes.TextBoxNumero();
            this.Txt_Quantidade = new SistemaVendas.Componentes.TextBoxNumero();
            this.Dgv_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.Btn_RemoverProduto = new System.Windows.Forms.Button();
            this.Txt_Produto = new System.Windows.Forms.TextBox();
            this.Btn_AdicionarProduto = new System.Windows.Forms.Button();
            this.Btn_BuscarProduto = new System.Windows.Forms.Button();
            this.Lbl_ValorUnitario = new System.Windows.Forms.Label();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Gb_DetalhesVenda = new System.Windows.Forms.GroupBox();
            this.Txt_Acrescimo = new SistemaVendas.Componentes.TextBoxNumero();
            this.Txt_Desconto = new SistemaVendas.Componentes.TextBoxNumero();
            this.Txt_totalGeral = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Txt_TotalItens = new System.Windows.Forms.TextBox();
            this.Lbl_TotalGeral = new System.Windows.Forms.Label();
            this.Lbl_TotalItens = new System.Windows.Forms.Label();
            this.Lbl_Acrescimo = new System.Windows.Forms.Label();
            this.Lbl_Desconto = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Gb_InformacoesVenda.SuspendLayout();
            this.Gb_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaProdutos)).BeginInit();
            this.Gb_DetalhesVenda.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_cliente.Location = new System.Drawing.Point(497, 35);
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
            this.Txt_Cliente.Location = new System.Drawing.Point(501, 62);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Cliente.MaxLength = 255;
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.Size = new System.Drawing.Size(320, 26);
            this.Txt_Cliente.TabIndex = 1;
            this.Txt_Cliente.TabStop = false;
            // 
            // Dtp_DataVenda
            // 
            this.Dtp_DataVenda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataVenda.Location = new System.Drawing.Point(150, 62);
            this.Dtp_DataVenda.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Dtp_DataVenda.Name = "Dtp_DataVenda";
            this.Dtp_DataVenda.Size = new System.Drawing.Size(109, 26);
            this.Dtp_DataVenda.TabIndex = 1;
            // 
            // Gb_InformacoesVenda
            // 
            this.Gb_InformacoesVenda.Controls.Add(this.Cbx_Pagamento);
            this.Gb_InformacoesVenda.Controls.Add(this.Txt_Cliente);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_cliente);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_DataVenda);
            this.Gb_InformacoesVenda.Controls.Add(this.Txt_Codigo);
            this.Gb_InformacoesVenda.Controls.Add(this.Btn_BuscarCliente);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_formaPagamento);
            this.Gb_InformacoesVenda.Controls.Add(this.Lbl_Codigo);
            this.Gb_InformacoesVenda.Controls.Add(this.Dtp_DataVenda);
            this.Gb_InformacoesVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_InformacoesVenda.Location = new System.Drawing.Point(22, 73);
            this.Gb_InformacoesVenda.Name = "Gb_InformacoesVenda";
            this.Gb_InformacoesVenda.Size = new System.Drawing.Size(885, 114);
            this.Gb_InformacoesVenda.TabIndex = 1;
            this.Gb_InformacoesVenda.TabStop = false;
            this.Gb_InformacoesVenda.Text = "Informação da venda";
            // 
            // Cbx_Pagamento
            // 
            this.Cbx_Pagamento.BackColor = System.Drawing.Color.White;
            this.Cbx_Pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Cbx_Pagamento.FormattingEnabled = true;
            this.Cbx_Pagamento.Location = new System.Drawing.Point(284, 62);
            this.Cbx_Pagamento.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Cbx_Pagamento.Name = "Cbx_Pagamento";
            this.Cbx_Pagamento.Size = new System.Drawing.Size(186, 26);
            this.Cbx_Pagamento.TabIndex = 2;
            this.Cbx_Pagamento.SelectedIndexChanged += new System.EventHandler(this.Cbx_Pagamento_SelectedIndexChanged);
            // 
            // Lbl_DataVenda
            // 
            this.Lbl_DataVenda.AutoSize = true;
            this.Lbl_DataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataVenda.Location = new System.Drawing.Point(146, 35);
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
            // Btn_BuscarCliente
            // 
            this.Btn_BuscarCliente.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarCliente.Image = global::SistemaVendas.Properties.Resources.buscar;
            this.Btn_BuscarCliente.Location = new System.Drawing.Point(827, 62);
            this.Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            this.Btn_BuscarCliente.Size = new System.Drawing.Size(25, 26);
            this.Btn_BuscarCliente.TabIndex = 3;
            this.Btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.Btn_BuscarCliente.Click += new System.EventHandler(this.Btn_BuscarCliente_Click);
            // 
            // Lbl_formaPagamento
            // 
            this.Lbl_formaPagamento.AutoSize = true;
            this.Lbl_formaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_formaPagamento.Location = new System.Drawing.Point(280, 35);
            this.Lbl_formaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_formaPagamento.Name = "Lbl_formaPagamento";
            this.Lbl_formaPagamento.Size = new System.Drawing.Size(140, 20);
            this.Lbl_formaPagamento.TabIndex = 0;
            this.Lbl_formaPagamento.Text = "Forma pagamento";
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
            // Gb_Produtos
            // 
            this.Gb_Produtos.Controls.Add(this.Txt_VlrUnitario);
            this.Gb_Produtos.Controls.Add(this.Txt_Quantidade);
            this.Gb_Produtos.Controls.Add(this.Dgv_ListaProdutos);
            this.Gb_Produtos.Controls.Add(this.Btn_RemoverProduto);
            this.Gb_Produtos.Controls.Add(this.Txt_Produto);
            this.Gb_Produtos.Controls.Add(this.Btn_AdicionarProduto);
            this.Gb_Produtos.Controls.Add(this.Btn_BuscarProduto);
            this.Gb_Produtos.Controls.Add(this.Lbl_ValorUnitario);
            this.Gb_Produtos.Controls.Add(this.Lbl_Quantidade);
            this.Gb_Produtos.Controls.Add(this.Lbl_Produto);
            this.Gb_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Produtos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Gb_Produtos.Location = new System.Drawing.Point(22, 193);
            this.Gb_Produtos.Name = "Gb_Produtos";
            this.Gb_Produtos.Size = new System.Drawing.Size(885, 300);
            this.Gb_Produtos.TabIndex = 2;
            this.Gb_Produtos.TabStop = false;
            this.Gb_Produtos.Text = "Produtos";
            // 
            // Txt_VlrUnitario
            // 
            this.Txt_VlrUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_VlrUnitario.Location = new System.Drawing.Point(743, 167);
            this.Txt_VlrUnitario.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_VlrUnitario.MaxLength = 20;
            this.Txt_VlrUnitario.Name = "Txt_VlrUnitario";
            this.Txt_VlrUnitario.Size = new System.Drawing.Size(117, 26);
            this.Txt_VlrUnitario.TabIndex = 6;
            this.Txt_VlrUnitario.Text = "0,00";
            this.Txt_VlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Quantidade.Location = new System.Drawing.Point(609, 167);
            this.Txt_Quantidade.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Quantidade.MaxLength = 20;
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(117, 26);
            this.Txt_Quantidade.TabIndex = 5;
            this.Txt_Quantidade.Text = "0,00";
            this.Txt_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Dgv_ListaProdutos
            // 
            this.Dgv_ListaProdutos.AllowUserToAddRows = false;
            this.Dgv_ListaProdutos.AllowUserToDeleteRows = false;
            this.Dgv_ListaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListaProdutos.Location = new System.Drawing.Point(19, 140);
            this.Dgv_ListaProdutos.Name = "Dgv_ListaProdutos";
            this.Dgv_ListaProdutos.ReadOnly = true;
            this.Dgv_ListaProdutos.Size = new System.Drawing.Size(569, 142);
            this.Dgv_ListaProdutos.TabIndex = 2;
            this.Dgv_ListaProdutos.TabStop = false;
            this.Dgv_ListaProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ListaProdutos_CellEnter);
            // 
            // Btn_RemoverProduto
            // 
            this.Btn_RemoverProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Btn_RemoverProduto.Location = new System.Drawing.Point(743, 209);
            this.Btn_RemoverProduto.Name = "Btn_RemoverProduto";
            this.Btn_RemoverProduto.Size = new System.Drawing.Size(117, 36);
            this.Btn_RemoverProduto.TabIndex = 8;
            this.Btn_RemoverProduto.Text = "Remover";
            this.Btn_RemoverProduto.UseVisualStyleBackColor = true;
            this.Btn_RemoverProduto.Click += new System.EventHandler(this.Btn_RemoverProduto_Click);
            // 
            // Txt_Produto
            // 
            this.Txt_Produto.BackColor = System.Drawing.Color.White;
            this.Txt_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Produto.Location = new System.Drawing.Point(20, 58);
            this.Txt_Produto.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Produto.Multiline = true;
            this.Txt_Produto.Name = "Txt_Produto";
            this.Txt_Produto.ReadOnly = true;
            this.Txt_Produto.Size = new System.Drawing.Size(841, 70);
            this.Txt_Produto.TabIndex = 1;
            this.Txt_Produto.TabStop = false;
            // 
            // Btn_AdicionarProduto
            // 
            this.Btn_AdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Btn_AdicionarProduto.Location = new System.Drawing.Point(609, 209);
            this.Btn_AdicionarProduto.Name = "Btn_AdicionarProduto";
            this.Btn_AdicionarProduto.Size = new System.Drawing.Size(117, 36);
            this.Btn_AdicionarProduto.TabIndex = 7;
            this.Btn_AdicionarProduto.Text = "Adicionar";
            this.Btn_AdicionarProduto.UseVisualStyleBackColor = true;
            this.Btn_AdicionarProduto.Click += new System.EventHandler(this.Btn_AdicionarProduto_Click);
            // 
            // Btn_BuscarProduto
            // 
            this.Btn_BuscarProduto.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarProduto.Image = global::SistemaVendas.Properties.Resources.buscar;
            this.Btn_BuscarProduto.Location = new System.Drawing.Point(87, 25);
            this.Btn_BuscarProduto.Name = "Btn_BuscarProduto";
            this.Btn_BuscarProduto.Size = new System.Drawing.Size(25, 26);
            this.Btn_BuscarProduto.TabIndex = 4;
            this.Btn_BuscarProduto.UseVisualStyleBackColor = true;
            this.Btn_BuscarProduto.Click += new System.EventHandler(this.Btn_BuscarProduto_Click);
            // 
            // Lbl_ValorUnitario
            // 
            this.Lbl_ValorUnitario.AutoSize = true;
            this.Lbl_ValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_ValorUnitario.Location = new System.Drawing.Point(739, 140);
            this.Lbl_ValorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ValorUnitario.Name = "Lbl_ValorUnitario";
            this.Lbl_ValorUnitario.Size = new System.Drawing.Size(102, 20);
            this.Lbl_ValorUnitario.TabIndex = 0;
            this.Lbl_ValorUnitario.Text = "Valor unitário";
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.AutoSize = true;
            this.Lbl_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Quantidade.Location = new System.Drawing.Point(605, 140);
            this.Lbl_Quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Quantidade.TabIndex = 0;
            this.Lbl_Quantidade.Text = "Quantidade";
            // 
            // Lbl_Produto
            // 
            this.Lbl_Produto.AutoSize = true;
            this.Lbl_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Produto.Location = new System.Drawing.Point(15, 31);
            this.Lbl_Produto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(65, 20);
            this.Lbl_Produto.TabIndex = 0;
            this.Lbl_Produto.Text = "Produto";
            // 
            // Gb_DetalhesVenda
            // 
            this.Gb_DetalhesVenda.Controls.Add(this.Txt_Acrescimo);
            this.Gb_DetalhesVenda.Controls.Add(this.Txt_Desconto);
            this.Gb_DetalhesVenda.Controls.Add(this.Txt_totalGeral);
            this.Gb_DetalhesVenda.Controls.Add(this.Btn_Cancelar);
            this.Gb_DetalhesVenda.Controls.Add(this.Btn_Gravar);
            this.Gb_DetalhesVenda.Controls.Add(this.Txt_TotalItens);
            this.Gb_DetalhesVenda.Controls.Add(this.Lbl_TotalGeral);
            this.Gb_DetalhesVenda.Controls.Add(this.Lbl_TotalItens);
            this.Gb_DetalhesVenda.Controls.Add(this.Lbl_Acrescimo);
            this.Gb_DetalhesVenda.Controls.Add(this.Lbl_Desconto);
            this.Gb_DetalhesVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_DetalhesVenda.Location = new System.Drawing.Point(22, 499);
            this.Gb_DetalhesVenda.Name = "Gb_DetalhesVenda";
            this.Gb_DetalhesVenda.Size = new System.Drawing.Size(885, 109);
            this.Gb_DetalhesVenda.TabIndex = 0;
            this.Gb_DetalhesVenda.TabStop = false;
            this.Gb_DetalhesVenda.Text = "Detalhes da venda";
            // 
            // Txt_Acrescimo
            // 
            this.Txt_Acrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Acrescimo.Location = new System.Drawing.Point(141, 62);
            this.Txt_Acrescimo.Margin = new System.Windows.Forms.Padding(6, 7, 3, 3);
            this.Txt_Acrescimo.MaxLength = 5;
            this.Txt_Acrescimo.Name = "Txt_Acrescimo";
            this.Txt_Acrescimo.Size = new System.Drawing.Size(113, 26);
            this.Txt_Acrescimo.TabIndex = 10;
            this.Txt_Acrescimo.Text = "0,00";
            this.Txt_Acrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Desconto
            // 
            this.Txt_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Desconto.Location = new System.Drawing.Point(19, 62);
            this.Txt_Desconto.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.Txt_Desconto.MaxLength = 5;
            this.Txt_Desconto.Name = "Txt_Desconto";
            this.Txt_Desconto.Size = new System.Drawing.Size(113, 26);
            this.Txt_Desconto.TabIndex = 9;
            this.Txt_Desconto.Text = "0,00";
            this.Txt_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_totalGeral
            // 
            this.Txt_totalGeral.BackColor = System.Drawing.Color.White;
            this.Txt_totalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_totalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_totalGeral.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_totalGeral.Location = new System.Drawing.Point(385, 62);
            this.Txt_totalGeral.Margin = new System.Windows.Forms.Padding(6, 7, 3, 3);
            this.Txt_totalGeral.MaxLength = 255;
            this.Txt_totalGeral.Name = "Txt_totalGeral";
            this.Txt_totalGeral.ReadOnly = true;
            this.Txt_totalGeral.Size = new System.Drawing.Size(113, 26);
            this.Txt_totalGeral.TabIndex = 1;
            this.Txt_totalGeral.TabStop = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::SistemaVendas.Properties.Resources.Cancelar;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancelar.Location = new System.Drawing.Point(743, 38);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Btn_Cancelar.Size = new System.Drawing.Size(117, 50);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gravar.Image = global::SistemaVendas.Properties.Resources.Salvar;
            this.Btn_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Gravar.Location = new System.Drawing.Point(618, 38);
            this.Btn_Gravar.Margin = new System.Windows.Forms.Padding(7, 3, 10, 3);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Btn_Gravar.Size = new System.Drawing.Size(108, 50);
            this.Btn_Gravar.TabIndex = 11;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Gravar.UseVisualStyleBackColor = false;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Txt_TotalItens
            // 
            this.Txt_TotalItens.BackColor = System.Drawing.Color.White;
            this.Txt_TotalItens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_TotalItens.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Txt_TotalItens.Location = new System.Drawing.Point(263, 62);
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
            this.Lbl_TotalGeral.Location = new System.Drawing.Point(381, 35);
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
            this.Lbl_TotalItens.Location = new System.Drawing.Point(259, 35);
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
            this.Lbl_Acrescimo.Location = new System.Drawing.Point(137, 35);
            this.Lbl_Acrescimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Acrescimo.Name = "Lbl_Acrescimo";
            this.Lbl_Acrescimo.Size = new System.Drawing.Size(101, 20);
            this.Lbl_Acrescimo.TabIndex = 0;
            this.Lbl_Acrescimo.Text = "Acréscimo %";
            this.Lbl_Acrescimo.DoubleClick += new System.EventHandler(this.Lbl_Acrescimo_DoubleClick);
            // 
            // Lbl_Desconto
            // 
            this.Lbl_Desconto.AutoSize = true;
            this.Lbl_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Desconto.Location = new System.Drawing.Point(16, 35);
            this.Lbl_Desconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Desconto.Name = "Lbl_Desconto";
            this.Lbl_Desconto.Size = new System.Drawing.Size(96, 20);
            this.Lbl_Desconto.TabIndex = 0;
            this.Lbl_Desconto.Text = "Desconto %";
            this.Lbl_Desconto.DoubleClick += new System.EventHandler(this.Lbl_Desconto_DoubleClick);
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
            this.PanelTitle.TabIndex = 5;
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
            this.Lbl_Title.Size = new System.Drawing.Size(229, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Lançamento de vendas";
            // 
            // Frm_LancaVenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 626);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.Gb_DetalhesVenda);
            this.Controls.Add(this.Gb_Produtos);
            this.Controls.Add(this.Gb_InformacoesVenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_LancaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de venda";
            this.Load += new System.EventHandler(this.Frm_LancaVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_LancaVenda_KeyDown);
            this.Gb_InformacoesVenda.ResumeLayout(false);
            this.Gb_InformacoesVenda.PerformLayout();
            this.Gb_Produtos.ResumeLayout(false);
            this.Gb_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaProdutos)).EndInit();
            this.Gb_DetalhesVenda.ResumeLayout(false);
            this.Gb_DetalhesVenda.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Button Btn_BuscarCliente;
        private System.Windows.Forms.DateTimePicker Dtp_DataVenda;
        private System.Windows.Forms.GroupBox Gb_InformacoesVenda;
        private System.Windows.Forms.Label Lbl_DataVenda;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.GroupBox Gb_Produtos;
        private System.Windows.Forms.GroupBox Gb_DetalhesVenda;
        private System.Windows.Forms.DataGridView Dgv_ListaProdutos;
        private System.Windows.Forms.Button Btn_RemoverProduto;
        private System.Windows.Forms.TextBox Txt_Produto;
        private System.Windows.Forms.Button Btn_AdicionarProduto;
        private System.Windows.Forms.Label Lbl_ValorUnitario;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.Label Lbl_Acrescimo;
        private System.Windows.Forms.Label Lbl_Desconto;
        private System.Windows.Forms.TextBox Txt_totalGeral;
        private System.Windows.Forms.TextBox Txt_TotalItens;
        private System.Windows.Forms.Label Lbl_TotalGeral;
        private System.Windows.Forms.Label Lbl_TotalItens;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_BuscarProduto;
        private System.Windows.Forms.Label Lbl_formaPagamento;
        private Componentes.TextBoxNumero Txt_VlrUnitario;
        private Componentes.TextBoxNumero Txt_Quantidade;
        private Componentes.TextBoxNumero Txt_Acrescimo;
        private Componentes.TextBoxNumero Txt_Desconto;
        private System.Windows.Forms.ComboBox Cbx_Pagamento;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}