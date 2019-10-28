namespace CapaDiseno
{
    partial class GraficasAvance
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_crear_grafica = new System.Windows.Forms.Button();
            this.Lbl_seleccionar_dominio = new System.Windows.Forms.Label();
            this.Cbo_dominios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_crear_grafica
            // 
            this.Btn_crear_grafica.Location = new System.Drawing.Point(872, 98);
            this.Btn_crear_grafica.Name = "Btn_crear_grafica";
            this.Btn_crear_grafica.Size = new System.Drawing.Size(206, 23);
            this.Btn_crear_grafica.TabIndex = 6;
            this.Btn_crear_grafica.Text = "Crear gráfica";
            this.Btn_crear_grafica.UseVisualStyleBackColor = true;
            // 
            // Lbl_seleccionar_dominio
            // 
            this.Lbl_seleccionar_dominio.AutoSize = true;
            this.Lbl_seleccionar_dominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccionar_dominio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionar_dominio.Location = new System.Drawing.Point(80, 94);
            this.Lbl_seleccionar_dominio.Name = "Lbl_seleccionar_dominio";
            this.Lbl_seleccionar_dominio.Size = new System.Drawing.Size(192, 28);
            this.Lbl_seleccionar_dominio.TabIndex = 5;
            this.Lbl_seleccionar_dominio.Text = "Seleccionar Objetivo";
            // 
            // Cbo_dominios
            // 
            this.Cbo_dominios.FormattingEnabled = true;
            this.Cbo_dominios.Location = new System.Drawing.Point(280, 98);
            this.Cbo_dominios.Name = "Cbo_dominios";
            this.Cbo_dominios.Size = new System.Drawing.Size(586, 24);
            this.Cbo_dominios.TabIndex = 4;
            this.Cbo_dominios.SelectedIndexChanged += new System.EventHandler(this.Cbo_dominios_SelectedIndexChanged);
            // 
            // GraficasAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.Btn_crear_grafica);
            this.Controls.Add(this.Lbl_seleccionar_dominio);
            this.Controls.Add(this.Cbo_dominios);
            this.Name = "GraficasAvance";
            this.Size = new System.Drawing.Size(1140, 643);
            this.Load += new System.EventHandler(this.GraficasAvance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_crear_grafica;
        private System.Windows.Forms.Label Lbl_seleccionar_dominio;
        private System.Windows.Forms.ComboBox Cbo_dominios;
    }
}
