namespace WindowsFormsApp1
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertarExamen = new System.Windows.Forms.Button();
            this.btnListExamen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListExamen);
            this.panel1.Controls.Add(this.btnInsertarExamen);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnInsertarExamen
            // 
            this.btnInsertarExamen.Location = new System.Drawing.Point(56, 52);
            this.btnInsertarExamen.Name = "btnInsertarExamen";
            this.btnInsertarExamen.Size = new System.Drawing.Size(108, 23);
            this.btnInsertarExamen.TabIndex = 0;
            this.btnInsertarExamen.Text = "Insertar Examen";
            this.btnInsertarExamen.UseVisualStyleBackColor = true;
            this.btnInsertarExamen.Click += new System.EventHandler(this.btnInsertarExamen_Click);
            // 
            // btnListExamen
            // 
            this.btnListExamen.Location = new System.Drawing.Point(170, 52);
            this.btnListExamen.Name = "btnListExamen";
            this.btnListExamen.Size = new System.Drawing.Size(98, 23);
            this.btnListExamen.TabIndex = 1;
            this.btnListExamen.Text = "Listado Examen";
            this.btnListExamen.UseVisualStyleBackColor = true;
            this.btnListExamen.Click += new System.EventHandler(this.btnListExamen_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 147);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListExamen;
        private System.Windows.Forms.Button btnInsertarExamen;
    }
}

