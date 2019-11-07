namespace Dll_Karina
{
    partial class MantenimientoDepartamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventana1 = new ventanaDiseno.ventana();
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.Txt_codAsignacion = new System.Windows.Forms.TextBox();
            this.Lbl_codAsignacion = new System.Windows.Forms.Label();
            this.Lbl_nombreProyecto = new System.Windows.Forms.Label();
            this.Lbl_nombreDepto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Dgv_deptos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deptos)).BeginInit();
            this.SuspendLayout();
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 0;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load);
            // 
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(99, 125);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(910, 65);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Txt_codAsignacion
            // 
            this.Txt_codAsignacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codAsignacion.Location = new System.Drawing.Point(264, 275);
            this.Txt_codAsignacion.Name = "Txt_codAsignacion";
            this.Txt_codAsignacion.Size = new System.Drawing.Size(199, 29);
            this.Txt_codAsignacion.TabIndex = 13;
            this.Txt_codAsignacion.Tag = "1";
            this.Txt_codAsignacion.TextChanged += new System.EventHandler(this.Txt_codRecurso_TextChanged);
            // 
            // Lbl_codAsignacion
            // 
            this.Lbl_codAsignacion.AutoSize = true;
            this.Lbl_codAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_codAsignacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codAsignacion.Location = new System.Drawing.Point(139, 274);
            this.Lbl_codAsignacion.Name = "Lbl_codAsignacion";
            this.Lbl_codAsignacion.Size = new System.Drawing.Size(60, 21);
            this.Lbl_codAsignacion.TabIndex = 14;
            this.Lbl_codAsignacion.Text = "Código";
            // 
            // Lbl_nombreProyecto
            // 
            this.Lbl_nombreProyecto.AutoSize = true;
            this.Lbl_nombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreProyecto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreProyecto.Location = new System.Drawing.Point(139, 326);
            this.Lbl_nombreProyecto.Name = "Lbl_nombreProyecto";
            this.Lbl_nombreProyecto.Size = new System.Drawing.Size(68, 21);
            this.Lbl_nombreProyecto.TabIndex = 16;
            this.Lbl_nombreProyecto.Text = "Nombre";
            // 
            // Lbl_nombreDepto
            // 
            this.Lbl_nombreDepto.AutoSize = true;
            this.Lbl_nombreDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreDepto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreDepto.Location = new System.Drawing.Point(139, 373);
            this.Lbl_nombreDepto.Name = "Lbl_nombreDepto";
            this.Lbl_nombreDepto.Size = new System.Drawing.Size(91, 21);
            this.Lbl_nombreDepto.TabIndex = 17;
            this.Lbl_nombreDepto.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(264, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.Tag = "2";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(264, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 29);
            this.textBox2.TabIndex = 19;
            this.textBox2.Tag = "3";
            // 
            // Dgv_deptos
            // 
            this.Dgv_deptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dgv_deptos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_deptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_deptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deptos.EnableHeadersVisualStyles = false;
            this.Dgv_deptos.Location = new System.Drawing.Point(546, 245);
            this.Dgv_deptos.Name = "Dgv_deptos";
            this.Dgv_deptos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_deptos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_deptos.Size = new System.Drawing.Size(491, 208);
            this.Dgv_deptos.TabIndex = 42;
            // 
            // MantenimientoDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Dgv_deptos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_nombreDepto);
            this.Controls.Add(this.Lbl_nombreProyecto);
            this.Controls.Add(this.Lbl_codAsignacion);
            this.Controls.Add(this.Txt_codAsignacion);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoDepartamentos";
            this.Text = "MantenimientoDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.TextBox Txt_codAsignacion;
        private System.Windows.Forms.Label Lbl_codAsignacion;
        private System.Windows.Forms.Label Lbl_nombreProyecto;
        private System.Windows.Forms.Label Lbl_nombreDepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView Dgv_deptos;
    }
}