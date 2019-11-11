namespace mantenimientosSeguridad
{
    partial class mantenimientoAplicaciones
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Encabezado = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Lbl_loginPass = new System.Windows.Forms.Label();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboModulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoModulo = new System.Windows.Forms.TextBox();
            this.dgAplicaciones = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiNavegador.Navegador();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAplicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lbl_Encabezado);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 59);
            this.panel2.TabIndex = 61;
            // 
            // lbl_Encabezado
            // 
            this.lbl_Encabezado.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encabezado.ForeColor = System.Drawing.Color.White;
            this.lbl_Encabezado.Location = new System.Drawing.Point(10, 8);
            this.lbl_Encabezado.Name = "lbl_Encabezado";
            this.lbl_Encabezado.Size = new System.Drawing.Size(489, 45);
            this.lbl_Encabezado.TabIndex = 2;
            this.lbl_Encabezado.Text = "MANTENIMIENTO APLICACION";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button3.Location = new System.Drawing.Point(936, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 53);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Lbl_loginPass
            // 
            this.Lbl_loginPass.AutoSize = true;
            this.Lbl_loginPass.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_loginPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginPass.Location = new System.Drawing.Point(249, 252);
            this.Lbl_loginPass.Name = "Lbl_loginPass";
            this.Lbl_loginPass.Size = new System.Drawing.Size(116, 21);
            this.Lbl_loginPass.TabIndex = 65;
            this.Lbl_loginPass.Text = "DESCRIPCION: ";
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(249, 184);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(77, 21);
            this.Lbl_loginUser.TabIndex = 64;
            this.Lbl_loginUser.Text = "CODIGO: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(253, 208);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(454, 25);
            this.txtCodigo.TabIndex = 62;
            this.txtCodigo.Tag = "1";
            this.txtCodigo.EnabledChanged += new System.EventHandler(this.TxtCodigo_EnabledChanged);
            // 
            // cboModulo
            // 
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.Location = new System.Drawing.Point(253, 353);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.Size = new System.Drawing.Size(223, 21);
            this.cboModulo.TabIndex = 66;
            this.cboModulo.SelectedIndexChanged += new System.EventHandler(this.CboModulo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(249, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 67;
            this.label1.Text = "MODULO: ";
            // 
            // txtCodigoModulo
            // 
            this.txtCodigoModulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoModulo.Location = new System.Drawing.Point(496, 352);
            this.txtCodigoModulo.MaxLength = 30;
            this.txtCodigoModulo.Name = "txtCodigoModulo";
            this.txtCodigoModulo.Size = new System.Drawing.Size(51, 25);
            this.txtCodigoModulo.TabIndex = 68;
            this.txtCodigoModulo.Tag = "3";
            this.txtCodigoModulo.UseSystemPasswordChar = true;
            this.txtCodigoModulo.TextChanged += new System.EventHandler(this.TxtCodigoModulo_TextChanged);
            // 
            // dgAplicaciones
            // 
            this.dgAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAplicaciones.Location = new System.Drawing.Point(242, 418);
            this.dgAplicaciones.Name = "dgAplicaciones";
            this.dgAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAplicaciones.Size = new System.Drawing.Size(483, 148);
            this.dgAplicaciones.TabIndex = 70;
            this.dgAplicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAplicaciones_CellContentClick);
            this.dgAplicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAplicaciones_CellDoubleClick);
            this.dgAplicaciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgAplicaciones_RowsAdded);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(253, 276);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(454, 25);
            this.txtDescripcion.TabIndex = 71;
            this.txtDescripcion.Tag = "2";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(27, 88);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 72;
            // 
            // mantenimientoAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(960, 623);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dgAplicaciones);
            this.Controls.Add(this.txtCodigoModulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModulo);
            this.Controls.Add(this.Lbl_loginPass);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimientoAplicaciones";
            this.Text = "mantenimientoAplicaciones";
            this.Load += new System.EventHandler(this.MantenimientoAplicaciones_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAplicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Encabezado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lbl_loginPass;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoModulo;
        private System.Windows.Forms.DataGridView dgAplicaciones;
        private System.Windows.Forms.TextBox txtDescripcion;
        private CapaDiNavegador.Navegador navegador1;
    }
}