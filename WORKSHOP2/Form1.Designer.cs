namespace WORKSHOP2
{
    partial class FrmAdo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConRel = new System.Windows.Forms.Button();
            this.btnSinRel = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConRel
            // 
            this.btnConRel.Location = new System.Drawing.Point(151, 55);
            this.btnConRel.Name = "btnConRel";
            this.btnConRel.Size = new System.Drawing.Size(183, 50);
            this.btnConRel.TabIndex = 1;
            this.btnConRel.Text = "Con Relacionamiento";
            this.btnConRel.UseVisualStyleBackColor = true;
            this.btnConRel.Click += new System.EventHandler(this.btnConRel_Click);
            // 
            // btnSinRel
            // 
            this.btnSinRel.Location = new System.Drawing.Point(485, 55);
            this.btnSinRel.Name = "btnSinRel";
            this.btnSinRel.Size = new System.Drawing.Size(202, 50);
            this.btnSinRel.TabIndex = 2;
            this.btnSinRel.Text = "Sin Relacionamiento ";
            this.btnSinRel.UseVisualStyleBackColor = true;
            this.btnSinRel.Click += new System.EventHandler(this.btnSinRel_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.DataMember = "";
            this.dgDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDatos.Location = new System.Drawing.Point(89, 164);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(598, 190);
            this.dgDatos.TabIndex = 3;
            // 
            // FrmAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnSinRel);
            this.Controls.Add(this.btnConRel);
            this.Name = "FrmAdo";
            this.Text = "ADO.NET";
            this.Load += new System.EventHandler(this.FrmAdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConRel;
        private System.Windows.Forms.Button btnSinRel;
        private System.Windows.Forms.DataGrid dgDatos;
    }
}

