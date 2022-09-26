
namespace SistemaVendas.View
{
    partial class Frm_BuscaProduto
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
            this.Dgv_BuscaProdutos = new System.Windows.Forms.DataGridView();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Lbl_InfoSelect = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BuscaProdutos)).BeginInit();
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
            this.PanelTitle.Size = new System.Drawing.Size(771, 66);
            this.PanelTitle.TabIndex = 6;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(19, 18);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(100, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Produtos";
            // 
            // Dgv_BuscaProdutos
            // 
            this.Dgv_BuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_BuscaProdutos.Location = new System.Drawing.Point(15, 142);
            this.Dgv_BuscaProdutos.Margin = new System.Windows.Forms.Padding(6);
            this.Dgv_BuscaProdutos.Name = "Dgv_BuscaProdutos";
            this.Dgv_BuscaProdutos.Size = new System.Drawing.Size(741, 247);
            this.Dgv_BuscaProdutos.TabIndex = 7;
            this.Dgv_BuscaProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_BuscaProdutos_CellDoubleClick);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Location = new System.Drawing.Point(13, 80);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Buscar.TabIndex = 8;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(15, 105);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Buscar.MaxLength = 150;
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(562, 26);
            this.Txt_Buscar.TabIndex = 9;
            this.Txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Buscar_KeyPress);
            // 
            // Lbl_InfoSelect
            // 
            this.Lbl_InfoSelect.BackColor = System.Drawing.Color.White;
            this.Lbl_InfoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.Lbl_InfoSelect.Image = global::SistemaVendas.Properties.Resources.Selecionar;
            this.Lbl_InfoSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_InfoSelect.Location = new System.Drawing.Point(584, 105);
            this.Lbl_InfoSelect.Name = "Lbl_InfoSelect";
            this.Lbl_InfoSelect.Size = new System.Drawing.Size(144, 26);
            this.Lbl_InfoSelect.TabIndex = 11;
            this.Lbl_InfoSelect.Text = "F2 - Selecionar";
            this.Lbl_InfoSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_BuscaProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.Lbl_InfoSelect);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Dgv_BuscaProdutos);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscaProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de produtos";
            this.Load += new System.EventHandler(this.Frm_BuscaClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_BuscaProduto_KeyDown);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BuscaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.DataGridView Dgv_BuscaProdutos;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label Lbl_InfoSelect;
    }
}