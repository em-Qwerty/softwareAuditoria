namespace mantenimientos_SB
{
    partial class mantenimiento_asignacionAuditorProyecto
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
            this.Dtg_datos = new System.Windows.Forms.DataGridView();
            this.Txt_NoAsignación = new System.Windows.Forms.TextBox();
            this.Lbl_NoAsignacion = new System.Windows.Forms.Label();
            this.Lbl_NameAuditor = new System.Windows.Forms.Label();
            this.Lbl_NameProyect = new System.Windows.Forms.Label();
            this.Cmb_Auditor = new System.Windows.Forms.ComboBox();
            this.Cmb_Proyecto = new System.Windows.Forms.ComboBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_observacion = new System.Windows.Forms.TextBox();
            this.txt_noProyecto = new System.Windows.Forms.TextBox();
            this.Txt_auditor = new System.Windows.Forms.TextBox();
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).BeginInit();
            this.SuspendLayout();
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
            this.Dtg_datos.Location = new System.Drawing.Point(542, 217);
            this.Dtg_datos.Name = "Dtg_datos";
            this.Dtg_datos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtg_datos.Size = new System.Drawing.Size(519, 310);
            this.Dtg_datos.TabIndex = 15;
            // 
            // Txt_NoAsignación
            // 
            this.Txt_NoAsignación.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_NoAsignación.Location = new System.Drawing.Point(230, 261);
            this.Txt_NoAsignación.Name = "Txt_NoAsignación";
            this.Txt_NoAsignación.Size = new System.Drawing.Size(283, 27);
            this.Txt_NoAsignación.TabIndex = 14;
            this.Txt_NoAsignación.Tag = "1";
            // 
            // Lbl_NoAsignacion
            // 
            this.Lbl_NoAsignacion.AutoSize = true;
            this.Lbl_NoAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NoAsignacion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoAsignacion.Location = new System.Drawing.Point(93, 258);
            this.Lbl_NoAsignacion.Name = "Lbl_NoAsignacion";
            this.Lbl_NoAsignacion.Size = new System.Drawing.Size(117, 21);
            this.Lbl_NoAsignacion.TabIndex = 13;
            this.Lbl_NoAsignacion.Text = "No. Asignación:";
            // 
            // Lbl_NameAuditor
            // 
            this.Lbl_NameAuditor.AutoSize = true;
            this.Lbl_NameAuditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameAuditor.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NameAuditor.Location = new System.Drawing.Point(93, 347);
            this.Lbl_NameAuditor.Name = "Lbl_NameAuditor";
            this.Lbl_NameAuditor.Size = new System.Drawing.Size(65, 21);
            this.Lbl_NameAuditor.TabIndex = 12;
            this.Lbl_NameAuditor.Text = "Auditor:";
            this.Lbl_NameAuditor.Click += new System.EventHandler(this.Lbl_NameAuditor_Click);
            // 
            // Lbl_NameProyect
            // 
            this.Lbl_NameProyect.AutoSize = true;
            this.Lbl_NameProyect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameProyect.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NameProyect.Location = new System.Drawing.Point(93, 304);
            this.Lbl_NameProyect.Name = "Lbl_NameProyect";
            this.Lbl_NameProyect.Size = new System.Drawing.Size(74, 21);
            this.Lbl_NameProyect.TabIndex = 11;
            this.Lbl_NameProyect.Text = "Proyecto:";
            // 
            // Cmb_Auditor
            // 
            this.Cmb_Auditor.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Cmb_Auditor.FormattingEnabled = true;
            this.Cmb_Auditor.Location = new System.Drawing.Point(230, 347);
            this.Cmb_Auditor.Name = "Cmb_Auditor";
            this.Cmb_Auditor.Size = new System.Drawing.Size(283, 28);
            this.Cmb_Auditor.TabIndex = 10;
            this.Cmb_Auditor.Tag = "4";
            this.Cmb_Auditor.SelectedIndexChanged += new System.EventHandler(this.Cmb_Auditor_SelectedIndexChanged);
            this.Cmb_Auditor.Click += new System.EventHandler(this.Cmb_Auditor_Click);
            // 
            // Cmb_Proyecto
            // 
            this.Cmb_Proyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Cmb_Proyecto.FormattingEnabled = true;
            this.Cmb_Proyecto.Location = new System.Drawing.Point(230, 304);
            this.Cmb_Proyecto.Name = "Cmb_Proyecto";
            this.Cmb_Proyecto.Size = new System.Drawing.Size(283, 28);
            this.Cmb_Proyecto.TabIndex = 9;
            this.Cmb_Proyecto.Tag = "3";
            this.Cmb_Proyecto.SelectedIndexChanged += new System.EventHandler(this.Cmb_Proyecto_SelectedIndexChanged);
            this.Cmb_Proyecto.SelectedValueChanged += new System.EventHandler(this.Cmb_Proyecto_SelectedValueChanged);
            this.Cmb_Proyecto.Click += new System.EventHandler(this.Cmb_Proyecto_Click);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_Descripcion.Location = new System.Drawing.Point(93, 400);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(100, 21);
            this.Lbl_Descripcion.TabIndex = 16;
            this.Lbl_Descripcion.Text = "Observación:";
            // 
            // Txt_observacion
            // 
            this.Txt_observacion.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_observacion.Location = new System.Drawing.Point(230, 398);
            this.Txt_observacion.Multiline = true;
            this.Txt_observacion.Name = "Txt_observacion";
            this.Txt_observacion.Size = new System.Drawing.Size(283, 94);
            this.Txt_observacion.TabIndex = 17;
            this.Txt_observacion.Tag = "2";
            // 
            // txt_noProyecto
            // 
            this.txt_noProyecto.Enabled = false;
            this.txt_noProyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.txt_noProyecto.Location = new System.Drawing.Point(208, 305);
            this.txt_noProyecto.Name = "txt_noProyecto";
            this.txt_noProyecto.Size = new System.Drawing.Size(15, 27);
            this.txt_noProyecto.TabIndex = 18;
            this.txt_noProyecto.Tag = "";
            this.txt_noProyecto.Visible = false;
            this.txt_noProyecto.TextChanged += new System.EventHandler(this.txt_noProyecto_TextChanged);
            // 
            // Txt_auditor
            // 
            this.Txt_auditor.Enabled = false;
            this.Txt_auditor.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_auditor.Location = new System.Drawing.Point(208, 347);
            this.Txt_auditor.Name = "Txt_auditor";
            this.Txt_auditor.Size = new System.Drawing.Size(15, 27);
            this.Txt_auditor.TabIndex = 19;
            this.Txt_auditor.Tag = "";
            this.Txt_auditor.Visible = false;
            this.Txt_auditor.TextChanged += new System.EventHandler(this.Txt_auditor_TextChanged);
            // 
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(127, 84);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(910, 65);
            this.disenoNavegador1.TabIndex = 20;
            this.disenoNavegador1.Load += new System.EventHandler(this.disenoNavegador1_Load);
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 21;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load_2);
            // 
            // mantenimiento_asignacionAuditorProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.Txt_auditor);
            this.Controls.Add(this.txt_noProyecto);
            this.Controls.Add(this.Txt_observacion);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Dtg_datos);
            this.Controls.Add(this.Txt_NoAsignación);
            this.Controls.Add(this.Lbl_NoAsignacion);
            this.Controls.Add(this.Lbl_NameAuditor);
            this.Controls.Add(this.Lbl_NameProyect);
            this.Controls.Add(this.Cmb_Auditor);
            this.Controls.Add(this.Cmb_Proyecto);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimiento_asignacionAuditorProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mantenimiento_asignacionAuditorProyecto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dtg_datos;
        private System.Windows.Forms.TextBox Txt_NoAsignación;
        private System.Windows.Forms.Label Lbl_NoAsignacion;
        private System.Windows.Forms.Label Lbl_NameAuditor;
        private System.Windows.Forms.Label Lbl_NameProyect;
        private System.Windows.Forms.ComboBox Cmb_Auditor;
        private System.Windows.Forms.ComboBox Cmb_Proyecto;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.TextBox Txt_observacion;
        private System.Windows.Forms.TextBox txt_noProyecto;
        private System.Windows.Forms.TextBox Txt_auditor;
        private Navegador_.DisenoNavegador disenoNavegador1;
        private ventanaDiseno.ventana ventana1;
    }
}