namespace Dll_Karina
{
    partial class AsignacionDeptos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventana1 = new ventanaDiseno.ventana();
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.Cmb_depto = new System.Windows.Forms.ComboBox();
            this.Cmb_proyecto = new System.Windows.Forms.ComboBox();
            this.Lbl_nombreDepto = new System.Windows.Forms.Label();
            this.Lbl_nombreProyecto = new System.Windows.Forms.Label();
            this.Lbl_codAsignacion = new System.Windows.Forms.Label();
            this.Txt_codAsignacion = new System.Windows.Forms.TextBox();
            this.Lbl_observacion = new System.Windows.Forms.Label();
            this.Txt_observacion = new System.Windows.Forms.TextBox();
            this.Txt_codProyecto = new System.Windows.Forms.TextBox();
            this.Txt_codDepto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
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
            this.disenoNavegador1.Location = new System.Drawing.Point(268, 109);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(674, 43);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dgv_asignacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_asignacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.EnableHeadersVisualStyles = false;
            this.Dgv_asignacion.Location = new System.Drawing.Point(563, 246);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_asignacion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_asignacion.Size = new System.Drawing.Size(486, 193);
            this.Dgv_asignacion.TabIndex = 41;
            // 
            // Cmb_depto
            // 
            this.Cmb_depto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_depto.FormattingEnabled = true;
            this.Cmb_depto.Location = new System.Drawing.Point(292, 345);
            this.Cmb_depto.Name = "Cmb_depto";
            this.Cmb_depto.Size = new System.Drawing.Size(241, 29);
            this.Cmb_depto.TabIndex = 47;
            this.Cmb_depto.SelectedIndexChanged += new System.EventHandler(this.Cmb_depto_SelectedIndexChanged);
            this.Cmb_depto.Click += new System.EventHandler(this.Cmb_depto_Click);
            // 
            // Cmb_proyecto
            // 
            this.Cmb_proyecto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_proyecto.FormattingEnabled = true;
            this.Cmb_proyecto.Location = new System.Drawing.Point(292, 298);
            this.Cmb_proyecto.Name = "Cmb_proyecto";
            this.Cmb_proyecto.Size = new System.Drawing.Size(241, 29);
            this.Cmb_proyecto.TabIndex = 46;
            this.Cmb_proyecto.SelectedIndexChanged += new System.EventHandler(this.Cmb_proyecto_SelectedIndexChanged);
            this.Cmb_proyecto.Click += new System.EventHandler(this.Cmb_proyecto_Click);
            // 
            // Lbl_nombreDepto
            // 
            this.Lbl_nombreDepto.AutoSize = true;
            this.Lbl_nombreDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreDepto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreDepto.Location = new System.Drawing.Point(124, 345);
            this.Lbl_nombreDepto.Name = "Lbl_nombreDepto";
            this.Lbl_nombreDepto.Size = new System.Drawing.Size(110, 21);
            this.Lbl_nombreDepto.TabIndex = 45;
            this.Lbl_nombreDepto.Text = "Departamento";
            this.Lbl_nombreDepto.Click += new System.EventHandler(this.Lbl_nombreDepto_Click);
            // 
            // Lbl_nombreProyecto
            // 
            this.Lbl_nombreProyecto.AutoSize = true;
            this.Lbl_nombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreProyecto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreProyecto.Location = new System.Drawing.Point(124, 298);
            this.Lbl_nombreProyecto.Name = "Lbl_nombreProyecto";
            this.Lbl_nombreProyecto.Size = new System.Drawing.Size(71, 21);
            this.Lbl_nombreProyecto.TabIndex = 44;
            this.Lbl_nombreProyecto.Text = "Proyecto";
            this.Lbl_nombreProyecto.Click += new System.EventHandler(this.Lbl_nombreProyecto_Click);
            // 
            // Lbl_codAsignacion
            // 
            this.Lbl_codAsignacion.AutoSize = true;
            this.Lbl_codAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_codAsignacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codAsignacion.Location = new System.Drawing.Point(124, 246);
            this.Lbl_codAsignacion.Name = "Lbl_codAsignacion";
            this.Lbl_codAsignacion.Size = new System.Drawing.Size(114, 21);
            this.Lbl_codAsignacion.TabIndex = 43;
            this.Lbl_codAsignacion.Text = "No. Asignación";
            this.Lbl_codAsignacion.Click += new System.EventHandler(this.Lbl_codAsignacion_Click);
            // 
            // Txt_codAsignacion
            // 
            this.Txt_codAsignacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codAsignacion.Location = new System.Drawing.Point(249, 246);
            this.Txt_codAsignacion.Name = "Txt_codAsignacion";
            this.Txt_codAsignacion.Size = new System.Drawing.Size(284, 29);
            this.Txt_codAsignacion.TabIndex = 42;
            this.Txt_codAsignacion.Tag = "1";
            this.Txt_codAsignacion.TextChanged += new System.EventHandler(this.Txt_codAsignacion_TextChanged);
            // 
            // Lbl_observacion
            // 
            this.Lbl_observacion.AutoSize = true;
            this.Lbl_observacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_observacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_observacion.Location = new System.Drawing.Point(124, 390);
            this.Lbl_observacion.Name = "Lbl_observacion";
            this.Lbl_observacion.Size = new System.Drawing.Size(91, 21);
            this.Lbl_observacion.TabIndex = 49;
            this.Lbl_observacion.Text = "Descripción";
            this.Lbl_observacion.Click += new System.EventHandler(this.Lbl_observacion_Click);
            // 
            // Txt_observacion
            // 
            this.Txt_observacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_observacion.Location = new System.Drawing.Point(249, 390);
            this.Txt_observacion.Multiline = true;
            this.Txt_observacion.Name = "Txt_observacion";
            this.Txt_observacion.Size = new System.Drawing.Size(284, 84);
            this.Txt_observacion.TabIndex = 48;
            this.Txt_observacion.Tag = "2";
            this.Txt_observacion.TextChanged += new System.EventHandler(this.Txt_observacion_TextChanged);
            // 
            // Txt_codProyecto
            // 
            this.Txt_codProyecto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codProyecto.Location = new System.Drawing.Point(249, 298);
            this.Txt_codProyecto.Name = "Txt_codProyecto";
            this.Txt_codProyecto.Size = new System.Drawing.Size(37, 29);
            this.Txt_codProyecto.TabIndex = 50;
            this.Txt_codProyecto.Tag = "3";
            this.Txt_codProyecto.TextChanged += new System.EventHandler(this.Txt_codProyecto_TextChanged);
            // 
            // Txt_codDepto
            // 
            this.Txt_codDepto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codDepto.Location = new System.Drawing.Point(249, 345);
            this.Txt_codDepto.Name = "Txt_codDepto";
            this.Txt_codDepto.Size = new System.Drawing.Size(37, 29);
            this.Txt_codDepto.TabIndex = 51;
            this.Txt_codDepto.Tag = "4";
            this.Txt_codDepto.TextChanged += new System.EventHandler(this.Txt_codDepto_TextChanged);
            // 
            // AsignacionDeptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Txt_codDepto);
            this.Controls.Add(this.Txt_codProyecto);
            this.Controls.Add(this.Lbl_observacion);
            this.Controls.Add(this.Txt_observacion);
            this.Controls.Add(this.Cmb_depto);
            this.Controls.Add(this.Cmb_proyecto);
            this.Controls.Add(this.Lbl_nombreDepto);
            this.Controls.Add(this.Lbl_nombreProyecto);
            this.Controls.Add(this.Lbl_codAsignacion);
            this.Controls.Add(this.Txt_codAsignacion);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignacionDeptos";
            this.Text = "AsignacionDeptos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.ComboBox Cmb_depto;
        private System.Windows.Forms.ComboBox Cmb_proyecto;
        private System.Windows.Forms.Label Lbl_nombreDepto;
        private System.Windows.Forms.Label Lbl_nombreProyecto;
        private System.Windows.Forms.Label Lbl_codAsignacion;
        private System.Windows.Forms.TextBox Txt_codAsignacion;
        private System.Windows.Forms.Label Lbl_observacion;
        private System.Windows.Forms.TextBox Txt_observacion;
        private System.Windows.Forms.TextBox Txt_codProyecto;
        private System.Windows.Forms.TextBox Txt_codDepto;
    }
}