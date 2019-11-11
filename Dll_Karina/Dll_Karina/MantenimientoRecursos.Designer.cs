namespace Dll_Karina
{
    partial class MantenimientoRecursos
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
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.Lbl_nombreRecurso = new System.Windows.Forms.Label();
            this.Txt_nombreRecurso = new System.Windows.Forms.TextBox();
            this.Lbl_codRecurso = new System.Windows.Forms.Label();
            this.Txt_codRecurso = new System.Windows.Forms.TextBox();
            this.Dgv_recursos = new System.Windows.Forms.DataGridView();
            this.Lbl_TipoRecursos = new System.Windows.Forms.Label();
            this.Cmb_tipo = new System.Windows.Forms.ComboBox();
            this.Txt_codtipoRecurso = new System.Windows.Forms.TextBox();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_recursos)).BeginInit();
            this.SuspendLayout();
            // 
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(98, 93);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(910, 65);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Lbl_nombreRecurso
            // 
            this.Lbl_nombreRecurso.AutoSize = true;
            this.Lbl_nombreRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_nombreRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreRecurso.Location = new System.Drawing.Point(246, 252);
            this.Lbl_nombreRecurso.Name = "Lbl_nombreRecurso";
            this.Lbl_nombreRecurso.Size = new System.Drawing.Size(68, 21);
            this.Lbl_nombreRecurso.TabIndex = 12;
            this.Lbl_nombreRecurso.Text = "Nombre";
            // 
            // Txt_nombreRecurso
            // 
            this.Txt_nombreRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreRecurso.Location = new System.Drawing.Point(344, 248);
            this.Txt_nombreRecurso.Name = "Txt_nombreRecurso";
            this.Txt_nombreRecurso.Size = new System.Drawing.Size(199, 29);
            this.Txt_nombreRecurso.TabIndex = 11;
            this.Txt_nombreRecurso.Tag = "2";
            // 
            // Lbl_codRecurso
            // 
            this.Lbl_codRecurso.AutoSize = true;
            this.Lbl_codRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_codRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codRecurso.Location = new System.Drawing.Point(246, 200);
            this.Lbl_codRecurso.Name = "Lbl_codRecurso";
            this.Lbl_codRecurso.Size = new System.Drawing.Size(60, 21);
            this.Lbl_codRecurso.TabIndex = 10;
            this.Lbl_codRecurso.Text = "Código";
            // 
            // Txt_codRecurso
            // 
            this.Txt_codRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codRecurso.Location = new System.Drawing.Point(344, 200);
            this.Txt_codRecurso.Name = "Txt_codRecurso";
            this.Txt_codRecurso.Size = new System.Drawing.Size(199, 29);
            this.Txt_codRecurso.TabIndex = 9;
            this.Txt_codRecurso.Tag = "1";
            // 
            // Dgv_recursos
            // 
            this.Dgv_recursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dgv_recursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_recursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_recursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_recursos.EnableHeadersVisualStyles = false;
            this.Dgv_recursos.Location = new System.Drawing.Point(570, 189);
            this.Dgv_recursos.Name = "Dgv_recursos";
            this.Dgv_recursos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_recursos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_recursos.Size = new System.Drawing.Size(390, 228);
            this.Dgv_recursos.TabIndex = 40;
            // 
            // Lbl_TipoRecursos
            // 
            this.Lbl_TipoRecursos.AutoSize = true;
            this.Lbl_TipoRecursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_TipoRecursos.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoRecursos.Location = new System.Drawing.Point(247, 301);
            this.Lbl_TipoRecursos.Name = "Lbl_TipoRecursos";
            this.Lbl_TipoRecursos.Size = new System.Drawing.Size(40, 21);
            this.Lbl_TipoRecursos.TabIndex = 41;
            this.Lbl_TipoRecursos.Text = "Tipo";
            // 
            // Cmb_tipo
            // 
            this.Cmb_tipo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_tipo.FormattingEnabled = true;
            this.Cmb_tipo.Location = new System.Drawing.Point(344, 303);
            this.Cmb_tipo.Name = "Cmb_tipo";
            this.Cmb_tipo.Size = new System.Drawing.Size(199, 29);
            this.Cmb_tipo.TabIndex = 42;
            this.Cmb_tipo.Tag = "3";
            this.Cmb_tipo.SelectedValueChanged += new System.EventHandler(this.Cmb_tipo_SelectedValueChanged);
            this.Cmb_tipo.Click += new System.EventHandler(this.Cmb_tipo_Click);
            // 
            // Txt_codtipoRecurso
            // 
            this.Txt_codtipoRecurso.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codtipoRecurso.Location = new System.Drawing.Point(325, 303);
            this.Txt_codtipoRecurso.Name = "Txt_codtipoRecurso";
            this.Txt_codtipoRecurso.Size = new System.Drawing.Size(10, 29);
            this.Txt_codtipoRecurso.TabIndex = 43;
            this.Txt_codtipoRecurso.Tag = "";
            this.Txt_codtipoRecurso.TextChanged += new System.EventHandler(this.Txt_codtipoRecurso_TextChanged);
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 44;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load_1);
            // 
            // MantenimientoRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Txt_codtipoRecurso);
            this.Controls.Add(this.Cmb_tipo);
            this.Controls.Add(this.Lbl_TipoRecursos);
            this.Controls.Add(this.Dgv_recursos);
            this.Controls.Add(this.Lbl_nombreRecurso);
            this.Controls.Add(this.Txt_nombreRecurso);
            this.Controls.Add(this.Lbl_codRecurso);
            this.Controls.Add(this.Txt_codRecurso);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoRecursos";
            this.Text = "MantenimientoRecursos";
            this.Load += new System.EventHandler(this.MantenimientoRecursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_recursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.Label Lbl_nombreRecurso;
        private System.Windows.Forms.TextBox Txt_nombreRecurso;
        private System.Windows.Forms.Label Lbl_codRecurso;
        private System.Windows.Forms.TextBox Txt_codRecurso;
        private System.Windows.Forms.DataGridView Dgv_recursos;
        private System.Windows.Forms.Label Lbl_TipoRecursos;
        private System.Windows.Forms.ComboBox Cmb_tipo;
        private System.Windows.Forms.TextBox Txt_codtipoRecurso;
        private ventanaDiseno.ventana ventana1;
    }
}