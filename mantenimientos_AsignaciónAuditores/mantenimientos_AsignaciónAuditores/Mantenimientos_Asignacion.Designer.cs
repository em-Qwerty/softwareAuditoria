namespace mantenimientos_AsignaciónAuditores
{
    partial class Mantenimientos_Asignacion
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
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.Cmb_Proyecto = new System.Windows.Forms.ComboBox();
            this.Cmb_Auditor = new System.Windows.Forms.ComboBox();
            this.Lbl_NameProyect = new System.Windows.Forms.Label();
            this.Lbl_NameAuditor = new System.Windows.Forms.Label();
            this.Lbl_NoAsignacion = new System.Windows.Forms.Label();
            this.Txt_NoAsignación = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(103, 74);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 1;
            // 
            // Cmb_Proyecto
            // 
            this.Cmb_Proyecto.FormattingEnabled = true;
            this.Cmb_Proyecto.Location = new System.Drawing.Point(285, 357);
            this.Cmb_Proyecto.Name = "Cmb_Proyecto";
            this.Cmb_Proyecto.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Proyecto.TabIndex = 2;
            // 
            // Cmb_Auditor
            // 
            this.Cmb_Auditor.FormattingEnabled = true;
            this.Cmb_Auditor.Location = new System.Drawing.Point(285, 400);
            this.Cmb_Auditor.Name = "Cmb_Auditor";
            this.Cmb_Auditor.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Auditor.TabIndex = 3;
            // 
            // Lbl_NameProyect
            // 
            this.Lbl_NameProyect.AutoSize = true;
            this.Lbl_NameProyect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameProyect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NameProyect.Location = new System.Drawing.Point(131, 357);
            this.Lbl_NameProyect.Name = "Lbl_NameProyect";
            this.Lbl_NameProyect.Size = new System.Drawing.Size(83, 21);
            this.Lbl_NameProyect.TabIndex = 4;
            this.Lbl_NameProyect.Text = "Proyecto:";
            // 
            // Lbl_NameAuditor
            // 
            this.Lbl_NameAuditor.AutoSize = true;
            this.Lbl_NameAuditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameAuditor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NameAuditor.Location = new System.Drawing.Point(131, 400);
            this.Lbl_NameAuditor.Name = "Lbl_NameAuditor";
            this.Lbl_NameAuditor.Size = new System.Drawing.Size(73, 21);
            this.Lbl_NameAuditor.TabIndex = 5;
            this.Lbl_NameAuditor.Text = "Auditor:";
            // 
            // Lbl_NoAsignacion
            // 
            this.Lbl_NoAsignacion.AutoSize = true;
            this.Lbl_NoAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NoAsignacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoAsignacion.Location = new System.Drawing.Point(131, 311);
            this.Lbl_NoAsignacion.Name = "Lbl_NoAsignacion";
            this.Lbl_NoAsignacion.Size = new System.Drawing.Size(131, 21);
            this.Lbl_NoAsignacion.TabIndex = 6;
            this.Lbl_NoAsignacion.Text = "No. Asignación:";
            // 
            // Txt_NoAsignación
            // 
            this.Txt_NoAsignación.Location = new System.Drawing.Point(285, 314);
            this.Txt_NoAsignación.Name = "Txt_NoAsignación";
            this.Txt_NoAsignación.Size = new System.Drawing.Size(200, 20);
            this.Txt_NoAsignación.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(509, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(484, 322);
            this.dataGridView1.TabIndex = 8;
            // 
            // Mantenimientos_Asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_NoAsignación);
            this.Controls.Add(this.Lbl_NoAsignacion);
            this.Controls.Add(this.Lbl_NameAuditor);
            this.Controls.Add(this.Lbl_NameProyect);
            this.Controls.Add(this.Cmb_Auditor);
            this.Controls.Add(this.Cmb_Proyecto);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mantenimientos_Asignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos_Asignacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox Cmb_Proyecto;
        private System.Windows.Forms.ComboBox Cmb_Auditor;
        private System.Windows.Forms.Label Lbl_NameProyect;
        private System.Windows.Forms.Label Lbl_NameAuditor;
        private System.Windows.Forms.Label Lbl_NoAsignacion;
        private System.Windows.Forms.TextBox Txt_NoAsignación;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}