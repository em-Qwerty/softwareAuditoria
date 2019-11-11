namespace mantenimientosSeguridad
{
    partial class mantenimientoPerfilAplicacion
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
            this.dgAplicaciones = new System.Windows.Forms.DataGridView();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Encabezado = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboModulo = new System.Windows.Forms.ComboBox();
            this.txtCodigoApliacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgAplicaciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAplicaciones
            // 
            this.dgAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAplicaciones.Location = new System.Drawing.Point(95, 386);
            this.dgAplicaciones.Name = "dgAplicaciones";
            this.dgAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAplicaciones.Size = new System.Drawing.Size(712, 225);
            this.dgAplicaciones.TabIndex = 92;
            this.dgAplicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAplicaciones_CellDoubleClick);
            this.dgAplicaciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgAplicaciones_RowsAdded);
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(92, 169);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(77, 21);
            this.Lbl_loginUser.TabIndex = 90;
            this.Lbl_loginUser.Text = "CODIGO: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(95, 193);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(226, 25);
            this.txtCodigo.TabIndex = 89;
            this.txtCodigo.Tag = "1";
            this.txtCodigo.EnabledChanged += new System.EventHandler(this.TxtCodigo_EnabledChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lbl_Encabezado);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 59);
            this.panel2.TabIndex = 87;
            // 
            // lbl_Encabezado
            // 
            this.lbl_Encabezado.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encabezado.ForeColor = System.Drawing.Color.White;
            this.lbl_Encabezado.Location = new System.Drawing.Point(25, 9);
            this.lbl_Encabezado.Name = "lbl_Encabezado";
            this.lbl_Encabezado.Size = new System.Drawing.Size(570, 45);
            this.lbl_Encabezado.TabIndex = 2;
            this.lbl_Encabezado.Text = "ASIGNACION PERFIL - APLICACION";
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
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPerfil.Location = new System.Drawing.Point(341, 259);
            this.txtCodigoPerfil.MaxLength = 30;
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.Size = new System.Drawing.Size(51, 25);
            this.txtCodigoPerfil.TabIndex = 95;
            this.txtCodigoPerfil.Tag = "2";
            this.txtCodigoPerfil.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(96, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "PERFIL:";
            // 
            // cboModulo
            // 
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.Location = new System.Drawing.Point(98, 260);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.Size = new System.Drawing.Size(223, 21);
            this.cboModulo.TabIndex = 93;
            this.cboModulo.SelectedIndexChanged += new System.EventHandler(this.CboModulo_SelectedIndexChanged);
            // 
            // txtCodigoApliacion
            // 
            this.txtCodigoApliacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoApliacion.Location = new System.Drawing.Point(341, 326);
            this.txtCodigoApliacion.MaxLength = 30;
            this.txtCodigoApliacion.Name = "txtCodigoApliacion";
            this.txtCodigoApliacion.Size = new System.Drawing.Size(51, 25);
            this.txtCodigoApliacion.TabIndex = 98;
            this.txtCodigoApliacion.Tag = "3";
            this.txtCodigoApliacion.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(96, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "APLICACION: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 96;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(491, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 25);
            this.checkBox1.TabIndex = 99;
            this.checkBox1.Text = "INGRESAR";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(491, 299);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 25);
            this.checkBox2.TabIndex = 100;
            this.checkBox2.Text = "EDITAR";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.CheckBox2_CheckStateChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(700, 260);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 25);
            this.checkBox3.TabIndex = 102;
            this.checkBox3.Text = "BORRAR";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckBox3_CheckStateChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(491, 339);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 25);
            this.checkBox4.TabIndex = 101;
            this.checkBox4.Text = "GUARDAR";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.CheckBox4_CheckStateChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(700, 299);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(119, 25);
            this.checkBox5.TabIndex = 103;
            this.checkBox5.Text = "CONSULTAR";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.CheckBox5_CheckStateChanged);
            // 
            // txtIngresar
            // 
            this.txtIngresar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresar.Location = new System.Drawing.Point(620, 257);
            this.txtIngresar.MaxLength = 30;
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(51, 25);
            this.txtIngresar.TabIndex = 104;
            this.txtIngresar.Tag = "4";
            this.txtIngresar.UseSystemPasswordChar = true;
            // 
            // txtEditar
            // 
            this.txtEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditar.Location = new System.Drawing.Point(620, 299);
            this.txtEditar.MaxLength = 30;
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(51, 25);
            this.txtEditar.TabIndex = 105;
            this.txtEditar.Tag = "5";
            this.txtEditar.UseSystemPasswordChar = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.Location = new System.Drawing.Point(620, 340);
            this.txtGuardar.MaxLength = 30;
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(51, 25);
            this.txtGuardar.TabIndex = 106;
            this.txtGuardar.Tag = "6";
            this.txtGuardar.UseSystemPasswordChar = true;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(841, 298);
            this.txtConsultar.MaxLength = 30;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(51, 25);
            this.txtConsultar.TabIndex = 108;
            this.txtConsultar.Tag = "8";
            this.txtConsultar.UseSystemPasswordChar = true;
            // 
            // txtBorrar
            // 
            this.txtBorrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrar.Location = new System.Drawing.Point(841, 256);
            this.txtBorrar.MaxLength = 30;
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(51, 25);
            this.txtBorrar.TabIndex = 107;
            this.txtBorrar.Tag = "7";
            this.txtBorrar.UseSystemPasswordChar = true;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(32, 79);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 109;
            // 
            // mantenimientoPerfilAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(972, 639);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCodigoApliacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCodigoPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModulo);
            this.Controls.Add(this.dgAplicaciones);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimientoPerfilAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mantenimientoPerfilAplicacion";
            this.Load += new System.EventHandler(this.MantenimientoPerfilAplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAplicaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAplicaciones;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Encabezado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCodigoPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModulo;
        private System.Windows.Forms.TextBox txtCodigoApliacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.TextBox txtBorrar;
        private CapaDiNavegador.Navegador navegador1;
    }
}