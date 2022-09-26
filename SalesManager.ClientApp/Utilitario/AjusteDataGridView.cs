using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.Utilitario
{
    public class AjusteDataGridView
    {
        public static void DataGrid_AlterarVenda (DataGridView dataGrid, DataTable data)
        {
            dataGrid.BackgroundColor = Color.White;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.MultiSelect = false;
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Arial", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.Highlight,
                WrapMode = DataGridViewTriState.True
            };
            dataGrid.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 11F),
                ForeColor = SystemColors.ControlText,
                Padding = new Padding(3, 0, 0, 0),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column1.Name = "id";
            column2.Name = "descricao";
            column3.Name = "quantidade";
            column4.Name = "vlrUnitario";
            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            // 
            // codigo produto
            // 
            dataGrid.Columns["id"].HeaderText = "Código";
            dataGrid.Columns["id"].Width = 73;
            dataGrid.Columns["id"].DisplayIndex = 0;
            dataGrid.Columns["id"].DefaultCellStyle.Format = "0000";
            dataGrid.Columns["id"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // descricao produto
            // 
            dataGrid.Columns["descricao"].HeaderText = "Descrição";
            dataGrid.Columns["descricao"].DisplayIndex = 1;
            dataGrid.Columns["descricao"].Width = 260;
            dataGrid.Columns["descricao"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // quantidade
            // 
            dataGrid.Columns["quantidade"].HeaderText = "Quantidade";
            dataGrid.Columns["quantidade"].DisplayIndex = 2;
            dataGrid.Columns["quantidade"].Width = 105;
            dataGrid.Columns["quantidade"].DefaultCellStyle.Format = "F2";
            dataGrid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Columns["quantidade"].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            dataGrid.Columns["quantidade"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // vlr_unitario
            // 
            dataGrid.Columns["vlrUnitario"].HeaderText = "Vlr unitário";
            dataGrid.Columns["vlrUnitario"].DisplayIndex = 3;
            dataGrid.Columns["vlrUnitario"].Width = 103;
            dataGrid.Columns["vlrUnitario"].DefaultCellStyle.Format = "C2";
            dataGrid.Columns["vlrUnitario"].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            dataGrid.Columns["vlrUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Columns["vlrUnitario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // idVenda
            //
            //dataGrid.Columns["idVenda"].Visible = false;

            foreach (DataRow row in data.Rows)
                dataGrid.Rows.Add(row[1], row[2], row[3], row[4]);
        }

        public static void DataGrid_NovaVenda (DataGridView dataGrid)
        {
            dataGrid.BackgroundColor = Color.White;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.MultiSelect = false;
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Arial", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.Highlight,
                WrapMode = DataGridViewTriState.True
            };
            dataGrid.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 11F),
                ForeColor = SystemColors.ControlText,
                Padding = new Padding(3, 0, 0, 0),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            // adicionando as colunas
            //
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column1.Name = "id";
            column2.Name = "descricao";
            column3.Name = "quantidade";
            column4.Name = "vlrUnitario";
            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            // 
            // codigo
            // 
            dataGrid.Columns["id"].HeaderText = "Código";
            dataGrid.Columns["id"].Width = 73;
            dataGrid.Columns["id"].DefaultCellStyle.Format = "0000";
            dataGrid.Columns["id"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // descricao produto
            // 
            dataGrid.Columns["descricao"].HeaderText = "Descrição";
            dataGrid.Columns["descricao"].DisplayIndex = 1;
            dataGrid.Columns["descricao"].Width = 274;
            dataGrid.Columns["descricao"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // quantidade
            // 
            dataGrid.Columns["quantidade"].HeaderText = "Quantidade";
            dataGrid.Columns["quantidade"].DisplayIndex = 2;
            dataGrid.Columns["quantidade"].Width = 105;
            dataGrid.Columns["quantidade"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // vlrUnitario
            // 
            dataGrid.Columns["vlrUnitario"].HeaderText = "Vlr unitário";
            dataGrid.Columns["vlrUnitario"].DisplayIndex = 3;
            dataGrid.Columns["vlrUnitario"].Width = 103;
            dataGrid.Columns["vlrUnitario"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public static void DataGrid_BuscaVenda (DataGridView dataGrid, DataTable data)
        {
            dataGrid.DataSource = data;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.MultiSelect = false;
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Arial", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.Highlight,
                WrapMode = DataGridViewTriState.True
            };
            dataGrid.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 11F),
                ForeColor = SystemColors.ControlText,
                Padding = new Padding(3, 0, 0, 0),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // idVenda
            // 
            dataGrid.Columns["idVenda"].HeaderText = "Código";
            dataGrid.Columns["idVenda"].Width = 73;
            dataGrid.Columns["idVenda"].DefaultCellStyle.Format = "0000";
            dataGrid.Columns["idVenda"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cliente
            // 
            dataGrid.Columns["cliente"].HeaderText = "Cliente";
            dataGrid.Columns["cliente"].DisplayIndex = 1;
            dataGrid.Columns["cliente"].Width = 350;
            dataGrid.Columns["cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataLancamento
            // 
            dataGrid.Columns["dataLancamento"].HeaderText = "Data da venda";
            dataGrid.Columns["dataLancamento"].DisplayIndex = 2;
            dataGrid.Columns["dataLancamento"].Width = 120;
            dataGrid.Columns["dataLancamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGrid.Columns["dataLancamento"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // forma_pag
            // 
            dataGrid.Columns["forma_pag"].HeaderText = "Pagamento";
            dataGrid.Columns["forma_pag"].DisplayIndex = 3;
            dataGrid.Columns["forma_pag"].Width = 110;
            dataGrid.Columns["forma_pag"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // desconto
            //
            dataGrid.Columns["desconto"].HeaderText = "Desconto";
            dataGrid.Columns["desconto"].DisplayIndex = 4;
            dataGrid.Columns["desconto"].Width = 90;
            dataGrid.Columns["desconto"].DefaultCellStyle.Format = "R$ #,##0.00";
            dataGrid.Columns["desconto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // acrescimo
            //
            dataGrid.Columns["acrescimo"].HeaderText = "Acréscimo";
            dataGrid.Columns["acrescimo"].DisplayIndex = 5;
            dataGrid.Columns["acrescimo"].Width = 100;
            dataGrid.Columns["acrescimo"].DefaultCellStyle.Format = "R$ #,##0.00";
            dataGrid.Columns["acrescimo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // totalItens
            //
            dataGrid.Columns["totalItens"].HeaderText = "Total Itens";
            dataGrid.Columns["totalItens"].DisplayIndex = 6;
            dataGrid.Columns["totalItens"].Width = 100;
            dataGrid.Columns["totalItens"].DefaultCellStyle.Format = "R$ #,##0.00";
            dataGrid.Columns["totalItens"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // totalDaVenda
            //
            dataGrid.Columns["totalDaVenda"].HeaderText = "Total Venda";
            dataGrid.Columns["totalDaVenda"].DisplayIndex = 7;
            dataGrid.Columns["totalDaVenda"].Width = 100;
            dataGrid.Columns["totalDaVenda"].DefaultCellStyle.Format = "R$ #,##0.00";
            dataGrid.Columns["totalDaVenda"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public static void DataGrid_ListaProdutos (DataGridView dataGrid, DataTable data)
        {
            dataGrid.DataSource = data;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.MultiSelect = false;
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Arial", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.Highlight,
                WrapMode = DataGridViewTriState.True
            };
            dataGrid.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 11F),
                ForeColor = SystemColors.ControlText,
                Padding = new Padding(3, 0, 0, 0),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // id
            // 
            dataGrid.Columns["id"].HeaderText = "Código";
            dataGrid.Columns["id"].Width = 73;
            dataGrid.Columns["id"].DefaultCellStyle.Format = "0000";
            dataGrid.Columns["id"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // nomeProduto
            // 
            dataGrid.Columns["nome_produto"].HeaderText = "Descrição";
            dataGrid.Columns["nome_produto"].DisplayIndex = 1;
            dataGrid.Columns["nome_produto"].Width = 454;
            dataGrid.Columns["nome_produto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // estoque
            // 
            dataGrid.Columns["estoque"].HeaderText = "Estoque";
            dataGrid.Columns["estoque"].DisplayIndex = 2;
            dataGrid.Columns["estoque"].Width = 94;
            dataGrid.Columns["estoque"].DefaultCellStyle.Format = "#,##0.00";
            dataGrid.Columns["estoque"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // preco
            // 
            dataGrid.Columns["preco"].HeaderText = "Preço";
            dataGrid.Columns["preco"].DisplayIndex = 3;
            dataGrid.Columns["preco"].Width = 100;
            dataGrid.Columns["preco"].DefaultCellStyle.Format = "R$ #,##0.00";
            dataGrid.Columns["preco"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // ativo
            //
            dataGrid.Columns["ativo"].Visible = false;
        }

        public static void DataGrid_ListaClientes (DataGridView dataGrid, DataTable data)
        {
            dataGrid.DataSource = data;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.MultiSelect = false;
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Arial", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.Highlight,
                WrapMode = DataGridViewTriState.True
            };
            dataGrid.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 11F),
                ForeColor = SystemColors.ControlText,
                Padding = new Padding(3, 0, 0, 0),
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // codigo
            // 
            dataGrid.Columns["id"].HeaderText = "Código";
            dataGrid.Columns["id"].Width = 73;
            dataGrid.Columns["id"].DefaultCellStyle.Format = "0000";
            dataGrid.Columns["id"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // nome_completo
            // 
            dataGrid.Columns["nome"].HeaderText = "Nome";
            dataGrid.Columns["nome"].DisplayIndex = 1;
            dataGrid.Columns["nome"].Width = 305;
            dataGrid.Columns["nome"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cpf
            // 
            dataGrid.Columns["cpf"].HeaderText = "CPF";
            dataGrid.Columns["cpf"].DisplayIndex = 2;
            dataGrid.Columns["cpf"].Width = 123;
            dataGrid.Columns["cpf"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // data_nasc
            // 
            dataGrid.Columns["data_nasc"].HeaderText = "Nascimento";
            dataGrid.Columns["data_nasc"].DisplayIndex = 3;
            dataGrid.Columns["data_nasc"].Width = 100;
            dataGrid.Columns["data_nasc"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGrid.Columns["data_nasc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // telefone
            // 
            dataGrid.Columns["telefone"].HeaderText = "Telefone";
            dataGrid.Columns["telefone"].DisplayIndex = 4;
            dataGrid.Columns["telefone"].Width = 130;
            dataGrid.Columns["telefone"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // email
            //
            dataGrid.Columns["email"].Visible = false;
        }
    }
}
