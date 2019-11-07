namespace mantenimientos_SB
{
    partial class mantenimiento_asignacionRecursosTI
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
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.Lbl_TipoRecurso = new System.Windows.Forms.Label();
            this.Cmb_tipoRecurso = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Dtg_datos = new System.Windows.Forms.DataGridView();
            this.Txt_NoAsignación = new System.Windows.Forms.TextBox();
            this.Lbl_NoRecurso = new System.Windows.Forms.Label();
            this.Lbl_NameProyect = new System.Windows.Forms.Label();
            this.Cmb_Proyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Rubrica = new System.Windows.Forms.ComboBox();
            this.txt_noProyecto = new System.Windows.Forms.TextBox();
            this.TxtRecurso = new System.Windows.Forms.TextBox();
            this.Txt_Rubrica = new System.Windows.Forms.TextBox();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(127, 84);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(910, 65);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Lbl_TipoRecurso
            // 
            this.Lbl_TipoRecurso.AutoSize = true;
            this.Lbl_TipoRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_TipoRecurso.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_TipoRecurso.Location = new System.Drawing.Point(63, 291);
            this.Lbl_TipoRecurso.Name = "Lbl_TipoRecurso";
            this.Lbl_TipoRecurso.Size = new System.Drawing.Size(103, 21);
            this.Lbl_TipoRecurso.TabIndex = 32;
            this.Lbl_TipoRecurso.Text = "Tipo Recurso:";
            this.Lbl_TipoRecurso.Click += new System.EventHandler(this.Lbl_TipoRecurso_Click);
            // 
            // Cmb_tipoRecurso
            // 
            this.Cmb_tipoRecurso.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Cmb_tipoRecurso.FormattingEnabled = true;
            this.Cmb_tipoRecurso.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.Cmb_tipoRecurso.Location = new System.Drawing.Point(217, 291);
            this.Cmb_tipoRecurso.Name = "Cmb_tipoRecurso";
            this.Cmb_tipoRecurso.Size = new System.Drawing.Size(281, 29);
            this.Cmb_tipoRecurso.TabIndex = 31;
            this.Cmb_tipoRecurso.Tag = "3";
            this.Cmb_tipoRecurso.SelectedIndexChanged += new System.EventHandler(this.Cmb_tipoRecurso_SelectedIndexChanged);
            this.Cmb_tipoRecurso.Click += new System.EventHandler(this.Cmb_tipoRecurso_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.textBox1.Location = new System.Drawing.Point(217, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 68);
            this.textBox1.TabIndex = 30;
            this.textBox1.Tag = "2";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_descripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_descripcion.Location = new System.Drawing.Point(63, 332);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(94, 21);
            this.Lbl_descripcion.TabIndex = 29;
            this.Lbl_descripcion.Text = "Descripción:";
            // 
            // Dtg_datos
            // 
            this.Dtg_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dtg_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dtg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_datos.EnableHeadersVisualStyles = false;
            this.Dtg_datos.Location = new System.Drawing.Point(523, 202);
            this.Dtg_datos.Name = "Dtg_datos";
            this.Dtg_datos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtg_datos.Size = new System.Drawing.Size(591, 322);
            this.Dtg_datos.TabIndex = 26;
            // 
            // Txt_NoAsignación
            // 
            this.Txt_NoAsignación.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Txt_NoAsignación.Location = new System.Drawing.Point(217, 213);
            this.Txt_NoAsignación.Name = "Txt_NoAsignación";
            this.Txt_NoAsignación.Size = new System.Drawing.Size(281, 29);
            this.Txt_NoAsignación.TabIndex = 25;
            this.Txt_NoAsignación.Tag = "1";
            // 
            // Lbl_NoRecurso
            // 
            this.Lbl_NoRecurso.AutoSize = true;
            this.Lbl_NoRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NoRecurso.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NoRecurso.Location = new System.Drawing.Point(63, 210);
            this.Lbl_NoRecurso.Name = "Lbl_NoRecurso";
            this.Lbl_NoRecurso.Size = new System.Drawing.Size(117, 21);
            this.Lbl_NoRecurso.TabIndex = 24;
            this.Lbl_NoRecurso.Text = "No. Asignación:";
            // 
            // Lbl_NameProyect
            // 
            this.Lbl_NameProyect.AutoSize = true;
            this.Lbl_NameProyect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameProyect.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NameProyect.Location = new System.Drawing.Point(63, 248);
            this.Lbl_NameProyect.Name = "Lbl_NameProyect";
            this.Lbl_NameProyect.Size = new System.Drawing.Size(74, 21);
            this.Lbl_NameProyect.TabIndex = 23;
            this.Lbl_NameProyect.Text = "Proyecto:";
            // 
            // Cmb_Proyecto
            // 
            this.Cmb_Proyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Cmb_Proyecto.FormattingEnabled = true;
            this.Cmb_Proyecto.Location = new System.Drawing.Point(217, 248);
            this.Cmb_Proyecto.Name = "Cmb_Proyecto";
            this.Cmb_Proyecto.Size = new System.Drawing.Size(281, 29);
            this.Cmb_Proyecto.TabIndex = 22;
            this.Cmb_Proyecto.Tag = "4";
            this.Cmb_Proyecto.SelectedValueChanged += new System.EventHandler(this.Cmb_Proyecto_SelectedValueChanged);
            this.Cmb_Proyecto.Click += new System.EventHandler(this.Cmb_Proyecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label1.Location = new System.Drawing.Point(63, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rúbrica:";
            // 
            // Cmb_Rubrica
            // 
            this.Cmb_Rubrica.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Cmb_Rubrica.FormattingEnabled = true;
            this.Cmb_Rubrica.Location = new System.Drawing.Point(217, 418);
            this.Cmb_Rubrica.Name = "Cmb_Rubrica";
            this.Cmb_Rubrica.Size = new System.Drawing.Size(281, 29);
            this.Cmb_Rubrica.TabIndex = 33;
            this.Cmb_Rubrica.Tag = "5";
            this.Cmb_Rubrica.SelectedIndexChanged += new System.EventHandler(this.Cmb_Rubrica_SelectedIndexChanged);
            this.Cmb_Rubrica.ValueMemberChanged += new System.EventHandler(this.Cmb_Rubrica_Click);
            this.Cmb_Rubrica.SelectedValueChanged += new System.EventHandler(this.Cmb_Rubrica_SelectedValueChanged);
            this.Cmb_Rubrica.Click += new System.EventHandler(this.Cmb_Rubrica_Click);
            // 
            // txt_noProyecto
            // 
            this.txt_noProyecto.Enabled = false;
            this.txt_noProyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.txt_noProyecto.Location = new System.Drawing.Point(197, 250);
            this.txt_noProyecto.Name = "txt_noProyecto";
            this.txt_noProyecto.Size = new System.Drawing.Size(10, 27);
            this.txt_noProyecto.TabIndex = 35;
            this.txt_noProyecto.Tag = "";
            this.txt_noProyecto.Visible = false;
            this.txt_noProyecto.TextChanged += new System.EventHandler(this.txt_noProyecto_TextChanged);
            // 
            // TxtRecurso
            // 
            this.TxtRecurso.Enabled = false;
            this.TxtRecurso.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.TxtRecurso.Location = new System.Drawing.Point(197, 292);
            this.TxtRecurso.Name = "TxtRecurso";
            this.TxtRecurso.Size = new System.Drawing.Size(10, 27);
            this.TxtRecurso.TabIndex = 36;
            this.TxtRecurso.Tag = "";
            this.TxtRecurso.Visible = false;
            this.TxtRecurso.TextChanged += new System.EventHandler(this.TxtRecurso_TextChanged);
            // 
            // Txt_Rubrica
            // 
            this.Txt_Rubrica.Enabled = false;
            this.Txt_Rubrica.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_Rubrica.Location = new System.Drawing.Point(197, 418);
            this.Txt_Rubrica.Name = "Txt_Rubrica";
            this.Txt_Rubrica.Size = new System.Drawing.Size(10, 27);
            this.Txt_Rubrica.TabIndex = 37;
            this.Txt_Rubrica.Tag = "";
            this.Txt_Rubrica.Visible = false;
            this.Txt_Rubrica.TextChanged += new System.EventHandler(this.Txt_Rubrica_TextChanged);
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
            // mantenimiento_asignacionRecursosTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Txt_Rubrica);
            this.Controls.Add(this.TxtRecurso);
            this.Controls.Add(this.txt_noProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Rubrica);
            this.Controls.Add(this.Lbl_TipoRecurso);
            this.Controls.Add(this.Cmb_tipoRecurso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Dtg_datos);
            this.Controls.Add(this.Txt_NoAsignación);
            this.Controls.Add(this.Lbl_NoRecurso);
            this.Controls.Add(this.Lbl_NameProyect);
            this.Controls.Add(this.Cmb_Proyecto);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimiento_asignacionRecursosTI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.Label Lbl_TipoRecurso;
        private System.Windows.Forms.ComboBox Cmb_tipoRecurso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.DataGridView Dtg_datos;
        private System.Windows.Forms.TextBox Txt_NoAsignación;
        private System.Windows.Forms.Label Lbl_NoRecurso;
        private System.Windows.Forms.Label Lbl_NameProyect;
        private System.Windows.Forms.ComboBox Cmb_Proyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Rubrica;
        private System.Windows.Forms.TextBox txt_noProyecto;
        private System.Windows.Forms.TextBox TxtRecurso;
        private System.Windows.Forms.TextBox Txt_Rubrica;
        private ventanaDiseno.ventana ventana1;
    }
}