namespace CapaDiseno
{
    partial class Avance
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
            this.ventana1 = new ventanaDiseno.ventana();
            this.Cbo_dominios = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccionar_dominio = new System.Windows.Forms.Label();
            this.Btn_crear_grafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 0;
            // 
            // Cbo_dominios
            // 
            this.Cbo_dominios.FormattingEnabled = true;
            this.Cbo_dominios.Location = new System.Drawing.Point(240, 97);
            this.Cbo_dominios.Name = "Cbo_dominios";
            this.Cbo_dominios.Size = new System.Drawing.Size(615, 24);
            this.Cbo_dominios.TabIndex = 1;
            // 
            // Lbl_seleccionar_dominio
            // 
            this.Lbl_seleccionar_dominio.AutoSize = true;
            this.Lbl_seleccionar_dominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccionar_dominio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionar_dominio.Location = new System.Drawing.Point(40, 93);
            this.Lbl_seleccionar_dominio.Name = "Lbl_seleccionar_dominio";
            this.Lbl_seleccionar_dominio.Size = new System.Drawing.Size(194, 28);
            this.Lbl_seleccionar_dominio.TabIndex = 2;
            this.Lbl_seleccionar_dominio.Text = "Seleccionar dominio:";
            this.Lbl_seleccionar_dominio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Btn_crear_grafica
            // 
            this.Btn_crear_grafica.Location = new System.Drawing.Point(861, 97);
            this.Btn_crear_grafica.Name = "Btn_crear_grafica";
            this.Btn_crear_grafica.Size = new System.Drawing.Size(206, 23);
            this.Btn_crear_grafica.TabIndex = 3;
            this.Btn_crear_grafica.Text = "Crear gráfica";
            this.Btn_crear_grafica.UseVisualStyleBackColor = true;
            // 
            // Avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Btn_crear_grafica);
            this.Controls.Add(this.Lbl_seleccionar_dominio);
            this.Controls.Add(this.Cbo_dominios);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avance";
            this.Text = "Avance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private System.Windows.Forms.ComboBox Cbo_dominios;
        private System.Windows.Forms.Label Lbl_seleccionar_dominio;
        private System.Windows.Forms.Button Btn_crear_grafica;
    }
}