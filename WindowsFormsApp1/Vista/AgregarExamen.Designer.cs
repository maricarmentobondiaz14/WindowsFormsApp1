namespace WindowsFormsApp1
{
    partial class AgregarExamen
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
            this.EditExamen = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.WebService = new System.Windows.Forms.GroupBox();
            this.rBDLL = new System.Windows.Forms.RadioButton();
            this.rBWebService = new System.Windows.Forms.RadioButton();
            this.EditExamen.SuspendLayout();
            this.WebService.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditExamen
            // 
            this.EditExamen.Controls.Add(this.WebService);
            this.EditExamen.Controls.Add(this.btnGuardar);
            this.EditExamen.Controls.Add(this.lblDescripcion);
            this.EditExamen.Controls.Add(this.lblNombre);
            this.EditExamen.Controls.Add(this.txtBDescripcion);
            this.EditExamen.Controls.Add(this.txtBNombre);
            this.EditExamen.Location = new System.Drawing.Point(0, 1);
            this.EditExamen.Name = "EditExamen";
            this.EditExamen.Size = new System.Drawing.Size(382, 234);
            this.EditExamen.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(139, 197);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(45, 98);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(117, 95);
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtBDescripcion.TabIndex = 3;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(117, 59);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(188, 20);
            this.txtBNombre.TabIndex = 2;
            // 
            // WebService
            // 
            this.WebService.Controls.Add(this.rBWebService);
            this.WebService.Controls.Add(this.rBDLL);
            this.WebService.Location = new System.Drawing.Point(93, 132);
            this.WebService.Name = "WebService";
            this.WebService.Size = new System.Drawing.Size(212, 49);
            this.WebService.TabIndex = 8;
            this.WebService.TabStop = false;
            this.WebService.Text = "Insertar Por:";
            // 
            // rBDLL
            // 
            this.rBDLL.AutoSize = true;
            this.rBDLL.Location = new System.Drawing.Point(127, 20);
            this.rBDLL.Name = "rBDLL";
            this.rBDLL.Size = new System.Drawing.Size(45, 17);
            this.rBDLL.TabIndex = 1;
            this.rBDLL.TabStop = true;
            this.rBDLL.Text = "DLL";
            this.rBDLL.UseVisualStyleBackColor = true;
            // 
            // rBWebService
            // 
            this.rBWebService.AutoSize = true;
            this.rBWebService.Location = new System.Drawing.Point(36, 20);
            this.rBWebService.Name = "rBWebService";
            this.rBWebService.Size = new System.Drawing.Size(84, 17);
            this.rBWebService.TabIndex = 2;
            this.rBWebService.TabStop = true;
            this.rBWebService.Text = "WebService";
            this.rBWebService.UseVisualStyleBackColor = true;
            // 
            // AgregarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 247);
            this.Controls.Add(this.EditExamen);
            this.Name = "AgregarExamen";
            this.Text = "Insertar Examen";
            this.EditExamen.ResumeLayout(false);
            this.EditExamen.PerformLayout();
            this.WebService.ResumeLayout(false);
            this.WebService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditExamen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.GroupBox WebService;
        private System.Windows.Forms.RadioButton rBWebService;
        private System.Windows.Forms.RadioButton rBDLL;
    }
}