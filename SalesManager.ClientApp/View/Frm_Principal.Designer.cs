
namespace SistemaVendas.View
{
    partial class Frm_Principal
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
            this.PanelFrames = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Vendas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFrames
            // 
            this.PanelFrames.Location = new System.Drawing.Point(258, 34);
            this.PanelFrames.Margin = new System.Windows.Forms.Padding(25);
            this.PanelFrames.Name = "PanelFrames";
            this.PanelFrames.Size = new System.Drawing.Size(947, 665);
            this.PanelFrames.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.Btn_Vendas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 740);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Vendas
            // 
            this.Btn_Vendas.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Vendas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Vendas.Image = global::SistemaVendas.Properties.Resources.Venda;
            this.Btn_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Vendas.Location = new System.Drawing.Point(23, 185);
            this.Btn_Vendas.Name = "Btn_Vendas";
            this.Btn_Vendas.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Btn_Vendas.Size = new System.Drawing.Size(166, 69);
            this.Btn_Vendas.TabIndex = 0;
            this.Btn_Vendas.Text = "Venda";
            this.Btn_Vendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vendas.UseVisualStyleBackColor = false;
            this.Btn_Vendas.Click += new System.EventHandler(this.Btn_Vendas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1239, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelFrames);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Vendas;
        public System.Windows.Forms.Panel PanelFrames;
    }
}