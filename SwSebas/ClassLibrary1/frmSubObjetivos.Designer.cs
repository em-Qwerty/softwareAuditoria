namespace ClassLibrary1
{
    partial class frmSubObjetivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventana1 = new ventanaDiseno.ventana();
            this.Dgv_subobjetivos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_auditores = new System.Windows.Forms.ComboBox();
            this.Lbl_subobj = new System.Windows.Forms.Label();
            this.Btn_asignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_subobjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 1;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load);
            // 
            // Dgv_subobjetivos
            // 
            this.Dgv_subobjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_subobjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_subobjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_subobjetivos.EnableHeadersVisualStyles = false;
            this.Dgv_subobjetivos.Location = new System.Drawing.Point(98, 174);
            this.Dgv_subobjetivos.Name = "Dgv_subobjetivos";
            this.Dgv_subobjetivos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_subobjetivos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_subobjetivos.Size = new System.Drawing.Size(953, 120);
            this.Dgv_subobjetivos.TabIndex = 2;
            this.Dgv_subobjetivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_subobjetivos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub-objetivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sub-objetivo seleccionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Auditores: ";
            // 
            // Cbo_auditores
            // 
            this.Cbo_auditores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_auditores.FormattingEnabled = true;
            this.Cbo_auditores.Location = new System.Drawing.Point(331, 406);
            this.Cbo_auditores.Name = "Cbo_auditores";
            this.Cbo_auditores.Size = new System.Drawing.Size(191, 29);
            this.Cbo_auditores.TabIndex = 6;
            this.Cbo_auditores.Tag = "2";
            // 
            // Lbl_subobj
            // 
            this.Lbl_subobj.AutoSize = true;
            this.Lbl_subobj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_subobj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subobj.Location = new System.Drawing.Point(327, 351);
            this.Lbl_subobj.Name = "Lbl_subobj";
            this.Lbl_subobj.Size = new System.Drawing.Size(0, 21);
            this.Lbl_subobj.TabIndex = 7;
            // 
            // Btn_asignar
            // 
            this.Btn_asignar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_asignar.Location = new System.Drawing.Point(524, 507);
            this.Btn_asignar.Name = "Btn_asignar";
            this.Btn_asignar.Size = new System.Drawing.Size(174, 58);
            this.Btn_asignar.TabIndex = 8;
            this.Btn_asignar.Text = "Asignar";
            this.Btn_asignar.UseVisualStyleBackColor = true;
            this.Btn_asignar.Click += new System.EventHandler(this.Btn_asignar_Click);
            // 
            // frmSubObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Btn_asignar);
            this.Controls.Add(this.Lbl_subobj);
            this.Controls.Add(this.Cbo_auditores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_subobjetivos);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubObjetivos";
            this.Text = "frmSubObjetivos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_subobjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ventanaDiseno.ventana ventana1;
        private System.Windows.Forms.DataGridView Dgv_subobjetivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_auditores;
        private System.Windows.Forms.Label Lbl_subobj;
        private System.Windows.Forms.Button Btn_asignar;
    }
}