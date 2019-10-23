namespace Dll_Karina
{
    partial class MantenimientoRecursosTI
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
            this.Txt_codtipoRecurso = new System.Windows.Forms.TextBox();
            this.Cmb_tipo = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoRecursos = new System.Windows.Forms.Label();
            this.Lbl_nombreRecurso = new System.Windows.Forms.Label();
            this.Txt_nombreRecurso = new System.Windows.Forms.TextBox();
            this.Lbl_codRecurso = new System.Windows.Forms.Label();
            this.Txt_codRecurso = new System.Windows.Forms.TextBox();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
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
            this.disenoNavegador1.Location = new System.Drawing.Point(243, 102);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(674, 43);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Txt_codtipoRecurso
            // 
            this.Txt_codtipoRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codtipoRecurso.Location = new System.Drawing.Point(271, 357);
            this.Txt_codtipoRecurso.Name = "Txt_codtipoRecurso";
            this.Txt_codtipoRecurso.Size = new System.Drawing.Size(40, 29);
            this.Txt_codtipoRecurso.TabIndex = 50;
            this.Txt_codtipoRecurso.Tag = "3";
            // 
            // Cmb_tipo
            // 
            this.Cmb_tipo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_tipo.FormattingEnabled = true;
            this.Cmb_tipo.Location = new System.Drawing.Point(317, 358);
            this.Cmb_tipo.Name = "Cmb_tipo";
            this.Cmb_tipo.Size = new System.Drawing.Size(153, 29);
            this.Cmb_tipo.TabIndex = 49;
            this.Cmb_tipo.SelectedValueChanged += new System.EventHandler(this.Cmb_tipo_SelectedValueChanged);
            // 
            // Lbl_TipoRecursos
            // 
            this.Lbl_TipoRecursos.AutoSize = true;
            this.Lbl_TipoRecursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_TipoRecursos.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoRecursos.Location = new System.Drawing.Point(174, 355);
            this.Lbl_TipoRecursos.Name = "Lbl_TipoRecursos";
            this.Lbl_TipoRecursos.Size = new System.Drawing.Size(40, 21);
            this.Lbl_TipoRecursos.TabIndex = 48;
            this.Lbl_TipoRecursos.Text = "Tipo";
            // 
            // Lbl_nombreRecurso
            // 
            this.Lbl_nombreRecurso.AutoSize = true;
            this.Lbl_nombreRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreRecurso.Location = new System.Drawing.Point(173, 306);
            this.Lbl_nombreRecurso.Name = "Lbl_nombreRecurso";
            this.Lbl_nombreRecurso.Size = new System.Drawing.Size(68, 21);
            this.Lbl_nombreRecurso.TabIndex = 47;
            this.Lbl_nombreRecurso.Text = "Nombre";
            // 
            // Txt_nombreRecurso
            // 
            this.Txt_nombreRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreRecurso.Location = new System.Drawing.Point(271, 302);
            this.Txt_nombreRecurso.Name = "Txt_nombreRecurso";
            this.Txt_nombreRecurso.Size = new System.Drawing.Size(199, 29);
            this.Txt_nombreRecurso.TabIndex = 46;
            this.Txt_nombreRecurso.Tag = "2";
            // 
            // Lbl_codRecurso
            // 
            this.Lbl_codRecurso.AutoSize = true;
            this.Lbl_codRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_codRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codRecurso.Location = new System.Drawing.Point(173, 254);
            this.Lbl_codRecurso.Name = "Lbl_codRecurso";
            this.Lbl_codRecurso.Size = new System.Drawing.Size(60, 21);
            this.Lbl_codRecurso.TabIndex = 45;
            this.Lbl_codRecurso.Text = "Código";
            // 
            // Txt_codRecurso
            // 
            this.Txt_codRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codRecurso.Location = new System.Drawing.Point(271, 254);
            this.Txt_codRecurso.Name = "Txt_codRecurso";
            this.Txt_codRecurso.Size = new System.Drawing.Size(199, 29);
            this.Txt_codRecurso.TabIndex = 44;
            this.Txt_codRecurso.Tag = "1";
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
            this.Dgv_asignacion.Location = new System.Drawing.Point(531, 228);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_asignacion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_asignacion.Size = new System.Drawing.Size(333, 174);
            this.Dgv_asignacion.TabIndex = 51;
            // 
            // MantenimientoRecursosTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Txt_codtipoRecurso);
            this.Controls.Add(this.Cmb_tipo);
            this.Controls.Add(this.Lbl_TipoRecursos);
            this.Controls.Add(this.Lbl_nombreRecurso);
            this.Controls.Add(this.Txt_nombreRecurso);
            this.Controls.Add(this.Lbl_codRecurso);
            this.Controls.Add(this.Txt_codRecurso);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoRecursosTI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoRecursosTI";
            this.Load += new System.EventHandler(this.MantenimientoRecursosTI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.TextBox Txt_codtipoRecurso;
        private System.Windows.Forms.ComboBox Cmb_tipo;
        private System.Windows.Forms.Label Lbl_TipoRecursos;
        private System.Windows.Forms.Label Lbl_nombreRecurso;
        private System.Windows.Forms.TextBox Txt_nombreRecurso;
        private System.Windows.Forms.Label Lbl_codRecurso;
        private System.Windows.Forms.TextBox Txt_codRecurso;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
    }
}