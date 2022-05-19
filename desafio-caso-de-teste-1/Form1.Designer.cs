namespace desafio_caso_de_teste_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTrasfere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrasfere)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 45);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 29;
            this.dgvProdutos.Size = new System.Drawing.Size(414, 302);
            this.dgvProdutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendas";
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(12, 373);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersWidth = 51;
            this.dgvVendas.RowTemplate.Height = 29;
            this.dgvVendas.Size = new System.Drawing.Size(781, 234);
            this.dgvVendas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trasfere";
            // 
            // dgvTrasfere
            // 
            this.dgvTrasfere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrasfere.Location = new System.Drawing.Point(432, 45);
            this.dgvTrasfere.Name = "dgvTrasfere";
            this.dgvTrasfere.RowHeadersWidth = 51;
            this.dgvTrasfere.RowTemplate.Height = 29;
            this.dgvTrasfere.Size = new System.Drawing.Size(977, 322);
            this.dgvTrasfere.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTrasfere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Form1";
            this.Text = "Desafio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrasfere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProdutos;
        private Label label1;
        private Label label2;
        private DataGridView dgvVendas;
        private Label label3;
        private DataGridView dgvTrasfere;
    }
}