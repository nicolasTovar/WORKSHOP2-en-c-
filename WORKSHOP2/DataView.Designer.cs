namespace WORKSHOP2
{
    partial class FrmDataView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgSql = new System.Windows.Forms.DataGridView();
            this.gbFdos = new System.Windows.Forms.GroupBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.lstFiltro = new System.Windows.Forms.ListBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIInicial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSql)).BeginInit();
            this.gbFdos.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSql
            // 
            this.dgSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSql.Location = new System.Drawing.Point(68, 153);
            this.dgSql.Name = "dgSql";
            this.dgSql.Size = new System.Drawing.Size(664, 286);
            this.dgSql.TabIndex = 5;
            this.dgSql.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSql_CellContentClick);
            // 
            // gbFdos
            // 
            this.gbFdos.BackColor = System.Drawing.Color.Khaki;
            this.gbFdos.Controls.Add(this.btnDesc);
            this.gbFdos.Controls.Add(this.btnAsc);
            this.gbFdos.Controls.Add(this.lstFiltro);
            this.gbFdos.Location = new System.Drawing.Point(452, 11);
            this.gbFdos.Name = "gbFdos";
            this.gbFdos.Size = new System.Drawing.Size(245, 136);
            this.gbFdos.TabIndex = 4;
            this.gbFdos.TabStop = false;
            this.gbFdos.Text = "Filtros II";
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(142, 59);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 6;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(142, 19);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 5;
            this.btnAsc.Text = "Asc";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // lstFiltro
            // 
            this.lstFiltro.FormattingEnabled = true;
            this.lstFiltro.Location = new System.Drawing.Point(6, 19);
            this.lstFiltro.Name = "lstFiltro";
            this.lstFiltro.Size = new System.Drawing.Size(120, 95);
            this.lstFiltro.TabIndex = 5;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Khaki;
            this.gbFiltros.Controls.Add(this.txtMostrar);
            this.gbFiltros.Controls.Add(this.cbCategoria);
            this.gbFiltros.Controls.Add(this.btnQuitar);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.lbIInicial);
            this.gbFiltros.Location = new System.Drawing.Point(68, 11);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(332, 136);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros I";
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(137, 16);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(100, 20);
            this.txtMostrar.TabIndex = 5;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(137, 43);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 4;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(6, 77);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar filtros";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(251, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoría:";
            // 
            // lbIInicial
            // 
            this.lbIInicial.AutoSize = true;
            this.lbIInicial.Location = new System.Drawing.Point(18, 16);
            this.lbIInicial.Name = "lbIInicial";
            this.lbIInicial.Size = new System.Drawing.Size(99, 13);
            this.lbIInicial.TabIndex = 0;
            this.lbIInicial.Text = "Inicial del producto:";
            // 
            // FrmDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSql);
            this.Controls.Add(this.gbFdos);
            this.Controls.Add(this.gbFiltros);
            this.Name = "FrmDataView";
            this.Text = "DataView";
            this.Load += new System.EventHandler(this.DataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSql)).EndInit();
            this.gbFdos.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSql;
        private System.Windows.Forms.GroupBox gbFdos;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.ListBox lstFiltro;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIInicial;
    }
}