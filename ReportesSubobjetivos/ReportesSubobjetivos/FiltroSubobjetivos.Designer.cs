namespace ReportesSubobjetivos
{
    partial class FiltroSubobjetivos
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
            this.Cbo_seleccion_proyecto = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccionar_proyecto = new System.Windows.Forms.Label();
            this.Lst_dominios = new System.Windows.Forms.ListBox();
            this.Lbl_dominios = new System.Windows.Forms.Label();
            this.Lbl_seleccion_dominios = new System.Windows.Forms.Label();
            this.Cbo_objetivos = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccion_objetivos = new System.Windows.Forms.Label();
            this.Btn_cargar = new System.Windows.Forms.Button();
            this.Btn_mover_todos_izquierda = new System.Windows.Forms.Button();
            this.Btn_mover_izquierda = new System.Windows.Forms.Button();
            this.Btn_mover_derecha = new System.Windows.Forms.Button();
            this.Btn_mover_todos_derecha = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lst_seleccion_dominios = new System.Windows.Forms.ListBox();
            this.Lbl_filtro = new System.Windows.Forms.Label();
            this.Dgv_subobjetivos = new System.Windows.Forms.DataGridView();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.ventana1 = new ventanaDiseno.ventana();
            this.Cbo_avance_min = new System.Windows.Forms.ComboBox();
            this.Cbo_avance_max = new System.Windows.Forms.ComboBox();
            this.Cbo_auditores = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccionar_auditor = new System.Windows.Forms.Label();
            this.Lbl_avance_min = new System.Windows.Forms.Label();
            this.Lbl_avance_max = new System.Windows.Forms.Label();
            this.lbl_subobjetivos = new System.Windows.Forms.Label();
            this.Lbl_porcentaje1 = new System.Windows.Forms.Label();
            this.Lbl_porcentaje2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_subobjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_seleccion_proyecto
            // 
            this.Cbo_seleccion_proyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_seleccion_proyecto.FormattingEnabled = true;
            this.Cbo_seleccion_proyecto.Location = new System.Drawing.Point(21, 150);
            this.Cbo_seleccion_proyecto.Name = "Cbo_seleccion_proyecto";
            this.Cbo_seleccion_proyecto.Size = new System.Drawing.Size(295, 28);
            this.Cbo_seleccion_proyecto.TabIndex = 0;
            this.Cbo_seleccion_proyecto.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccion_proyecto_SelectedIndexChanged);
            // 
            // Lbl_seleccionar_proyecto
            // 
            this.Lbl_seleccionar_proyecto.AutoSize = true;
            this.Lbl_seleccionar_proyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccionar_proyecto.Location = new System.Drawing.Point(17, 127);
            this.Lbl_seleccionar_proyecto.Name = "Lbl_seleccionar_proyecto";
            this.Lbl_seleccionar_proyecto.Size = new System.Drawing.Size(148, 20);
            this.Lbl_seleccionar_proyecto.TabIndex = 0;
            this.Lbl_seleccionar_proyecto.Text = "Seleccionar proyecto";
            // 
            // Lst_dominios
            // 
            this.Lst_dominios.FormattingEnabled = true;
            this.Lst_dominios.HorizontalScrollbar = true;
            this.Lst_dominios.ItemHeight = 20;
            this.Lst_dominios.Location = new System.Drawing.Point(21, 213);
            this.Lst_dominios.Name = "Lst_dominios";
            this.Lst_dominios.ScrollAlwaysVisible = true;
            this.Lst_dominios.Size = new System.Drawing.Size(144, 184);
            this.Lst_dominios.TabIndex = 2;
            // 
            // Lbl_dominios
            // 
            this.Lbl_dominios.AutoSize = true;
            this.Lbl_dominios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_dominios.Location = new System.Drawing.Point(17, 191);
            this.Lbl_dominios.Name = "Lbl_dominios";
            this.Lbl_dominios.Size = new System.Drawing.Size(73, 20);
            this.Lbl_dominios.TabIndex = 4;
            this.Lbl_dominios.Text = "Dominios";
            // 
            // Lbl_seleccion_dominios
            // 
            this.Lbl_seleccion_dominios.AutoSize = true;
            this.Lbl_seleccion_dominios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccion_dominios.Location = new System.Drawing.Point(167, 190);
            this.Lbl_seleccion_dominios.Name = "Lbl_seleccion_dominios";
            this.Lbl_seleccion_dominios.Size = new System.Drawing.Size(143, 20);
            this.Lbl_seleccion_dominios.TabIndex = 5;
            this.Lbl_seleccion_dominios.Text = "Selección de domin.";
            // 
            // Cbo_objetivos
            // 
            this.Cbo_objetivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_objetivos.FormattingEnabled = true;
            this.Cbo_objetivos.Location = new System.Drawing.Point(26, 479);
            this.Cbo_objetivos.Name = "Cbo_objetivos";
            this.Cbo_objetivos.Size = new System.Drawing.Size(294, 28);
            this.Cbo_objetivos.TabIndex = 8;
            this.Cbo_objetivos.DropDown += new System.EventHandler(this.Cbo_objetivos_DropDown);
            // 
            // Lbl_seleccion_objetivos
            // 
            this.Lbl_seleccion_objetivos.AutoSize = true;
            this.Lbl_seleccion_objetivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccion_objetivos.Location = new System.Drawing.Point(21, 456);
            this.Lbl_seleccion_objetivos.Name = "Lbl_seleccion_objetivos";
            this.Lbl_seleccion_objetivos.Size = new System.Drawing.Size(144, 20);
            this.Lbl_seleccion_objetivos.TabIndex = 0;
            this.Lbl_seleccion_objetivos.Text = "Seleccionar objetivo";
            // 
            // Btn_cargar
            // 
            this.Btn_cargar.Location = new System.Drawing.Point(210, 652);
            this.Btn_cargar.Name = "Btn_cargar";
            this.Btn_cargar.Size = new System.Drawing.Size(110, 28);
            this.Btn_cargar.TabIndex = 12;
            this.Btn_cargar.Text = "Cargar";
            this.Btn_cargar.UseVisualStyleBackColor = true;
            this.Btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
            // 
            // Btn_mover_todos_izquierda
            // 
            this.Btn_mover_todos_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_izquierda.Location = new System.Drawing.Point(169, 405);
            this.Btn_mover_todos_izquierda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_todos_izquierda.Name = "Btn_mover_todos_izquierda";
            this.Btn_mover_todos_izquierda.Size = new System.Drawing.Size(72, 32);
            this.Btn_mover_todos_izquierda.TabIndex = 6;
            this.Btn_mover_todos_izquierda.Text = "<<";
            this.Btn_mover_todos_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_izquierda.Click += new System.EventHandler(this.Btn_mover_todos_izquierda_Click);
            // 
            // Btn_mover_izquierda
            // 
            this.Btn_mover_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_izquierda.Location = new System.Drawing.Point(244, 405);
            this.Btn_mover_izquierda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_izquierda.Name = "Btn_mover_izquierda";
            this.Btn_mover_izquierda.Size = new System.Drawing.Size(72, 32);
            this.Btn_mover_izquierda.TabIndex = 7;
            this.Btn_mover_izquierda.Text = "<";
            this.Btn_mover_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_izquierda.Click += new System.EventHandler(this.Btn_mover_izquierda_Click);
            // 
            // Btn_mover_derecha
            // 
            this.Btn_mover_derecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_derecha.Location = new System.Drawing.Point(22, 404);
            this.Btn_mover_derecha.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_derecha.Name = "Btn_mover_derecha";
            this.Btn_mover_derecha.Size = new System.Drawing.Size(72, 33);
            this.Btn_mover_derecha.TabIndex = 4;
            this.Btn_mover_derecha.Text = ">";
            this.Btn_mover_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_derecha.Click += new System.EventHandler(this.Btn_mover_derecha_Click);
            // 
            // Btn_mover_todos_derecha
            // 
            this.Btn_mover_todos_derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_derecha.Location = new System.Drawing.Point(93, 405);
            this.Btn_mover_todos_derecha.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_todos_derecha.Name = "Btn_mover_todos_derecha";
            this.Btn_mover_todos_derecha.Size = new System.Drawing.Size(72, 32);
            this.Btn_mover_todos_derecha.TabIndex = 5;
            this.Btn_mover_todos_derecha.Text = ">>";
            this.Btn_mover_todos_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_derecha.Click += new System.EventHandler(this.Btn_mover_todos_derecha_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))));
            this.Lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_titulo.Location = new System.Drawing.Point(90, 18);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(308, 37);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Reportes Subobjetivos";
            // 
            // Lst_seleccion_dominios
            // 
            this.Lst_seleccion_dominios.FormattingEnabled = true;
            this.Lst_seleccion_dominios.HorizontalScrollbar = true;
            this.Lst_seleccion_dominios.ItemHeight = 20;
            this.Lst_seleccion_dominios.Location = new System.Drawing.Point(171, 213);
            this.Lst_seleccion_dominios.Name = "Lst_seleccion_dominios";
            this.Lst_seleccion_dominios.ScrollAlwaysVisible = true;
            this.Lst_seleccion_dominios.Size = new System.Drawing.Size(145, 184);
            this.Lst_seleccion_dominios.TabIndex = 3;
            // 
            // Lbl_filtro
            // 
            this.Lbl_filtro.AutoSize = true;
            this.Lbl_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_filtro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_filtro.Location = new System.Drawing.Point(17, 88);
            this.Lbl_filtro.Name = "Lbl_filtro";
            this.Lbl_filtro.Size = new System.Drawing.Size(59, 25);
            this.Lbl_filtro.TabIndex = 0;
            this.Lbl_filtro.Text = "Filtro";
            // 
            // Dgv_subobjetivos
            // 
            this.Dgv_subobjetivos.AllowUserToAddRows = false;
            this.Dgv_subobjetivos.AllowUserToDeleteRows = false;
            this.Dgv_subobjetivos.AllowUserToResizeColumns = false;
            this.Dgv_subobjetivos.AllowUserToResizeRows = false;
            this.Dgv_subobjetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_subobjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_subobjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_subobjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_subobjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_subobjetivos.EnableHeadersVisualStyles = false;
            this.Dgv_subobjetivos.Location = new System.Drawing.Point(340, 150);
            this.Dgv_subobjetivos.Name = "Dgv_subobjetivos";
            this.Dgv_subobjetivos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_subobjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_subobjetivos.RowHeadersVisible = false;
            this.Dgv_subobjetivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_subobjetivos.Size = new System.Drawing.Size(837, 531);
            this.Dgv_subobjetivos.TabIndex = 0;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Location = new System.Drawing.Point(1042, 699);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(135, 28);
            this.Btn_reporte.TabIndex = 13;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1202, 749);
            this.ventana1.TabIndex = 0;
            // 
            // Cbo_avance_min
            // 
            this.Cbo_avance_min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_avance_min.FormattingEnabled = true;
            this.Cbo_avance_min.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Cbo_avance_min.Location = new System.Drawing.Point(25, 653);
            this.Cbo_avance_min.Name = "Cbo_avance_min";
            this.Cbo_avance_min.Size = new System.Drawing.Size(65, 28);
            this.Cbo_avance_min.TabIndex = 10;
            // 
            // Cbo_avance_max
            // 
            this.Cbo_avance_max.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_avance_max.FormattingEnabled = true;
            this.Cbo_avance_max.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "0"});
            this.Cbo_avance_max.Location = new System.Drawing.Point(116, 653);
            this.Cbo_avance_max.Name = "Cbo_avance_max";
            this.Cbo_avance_max.Size = new System.Drawing.Size(64, 28);
            this.Cbo_avance_max.TabIndex = 11;
            // 
            // Cbo_auditores
            // 
            this.Cbo_auditores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_auditores.FormattingEnabled = true;
            this.Cbo_auditores.Location = new System.Drawing.Point(25, 585);
            this.Cbo_auditores.Name = "Cbo_auditores";
            this.Cbo_auditores.Size = new System.Drawing.Size(295, 28);
            this.Cbo_auditores.TabIndex = 9;
            // 
            // Lbl_seleccionar_auditor
            // 
            this.Lbl_seleccionar_auditor.AutoSize = true;
            this.Lbl_seleccionar_auditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccionar_auditor.Location = new System.Drawing.Point(21, 562);
            this.Lbl_seleccionar_auditor.Name = "Lbl_seleccionar_auditor";
            this.Lbl_seleccionar_auditor.Size = new System.Drawing.Size(137, 20);
            this.Lbl_seleccionar_auditor.TabIndex = 0;
            this.Lbl_seleccionar_auditor.Text = "Seleccionar auditor";
            // 
            // Lbl_avance_min
            // 
            this.Lbl_avance_min.AutoSize = true;
            this.Lbl_avance_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_avance_min.Location = new System.Drawing.Point(21, 630);
            this.Lbl_avance_min.Name = "Lbl_avance_min";
            this.Lbl_avance_min.Size = new System.Drawing.Size(89, 20);
            this.Lbl_avance_min.TabIndex = 0;
            this.Lbl_avance_min.Text = "Avance Min.";
            // 
            // Lbl_avance_max
            // 
            this.Lbl_avance_max.AutoSize = true;
            this.Lbl_avance_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_avance_max.Location = new System.Drawing.Point(112, 630);
            this.Lbl_avance_max.Name = "Lbl_avance_max";
            this.Lbl_avance_max.Size = new System.Drawing.Size(92, 20);
            this.Lbl_avance_max.TabIndex = 0;
            this.Lbl_avance_max.Text = "Avance Max.";
            // 
            // lbl_subobjetivos
            // 
            this.lbl_subobjetivos.AutoSize = true;
            this.lbl_subobjetivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_subobjetivos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subobjetivos.Location = new System.Drawing.Point(21, 527);
            this.lbl_subobjetivos.Name = "lbl_subobjetivos";
            this.lbl_subobjetivos.Size = new System.Drawing.Size(99, 20);
            this.lbl_subobjetivos.TabIndex = 0;
            this.lbl_subobjetivos.Text = "Subobjetivos";
            // 
            // Lbl_porcentaje1
            // 
            this.Lbl_porcentaje1.AutoSize = true;
            this.Lbl_porcentaje1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_porcentaje1.Location = new System.Drawing.Point(89, 656);
            this.Lbl_porcentaje1.Name = "Lbl_porcentaje1";
            this.Lbl_porcentaje1.Size = new System.Drawing.Size(21, 20);
            this.Lbl_porcentaje1.TabIndex = 0;
            this.Lbl_porcentaje1.Text = "%";
            this.Lbl_porcentaje1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_porcentaje2
            // 
            this.Lbl_porcentaje2.AutoSize = true;
            this.Lbl_porcentaje2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_porcentaje2.Location = new System.Drawing.Point(183, 656);
            this.Lbl_porcentaje2.Name = "Lbl_porcentaje2";
            this.Lbl_porcentaje2.Size = new System.Drawing.Size(21, 20);
            this.Lbl_porcentaje2.TabIndex = 0;
            this.Lbl_porcentaje2.Text = "%";
            this.Lbl_porcentaje2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FiltroSubobjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 749);
            this.Controls.Add(this.Lbl_porcentaje2);
            this.Controls.Add(this.Lbl_porcentaje1);
            this.Controls.Add(this.lbl_subobjetivos);
            this.Controls.Add(this.Lbl_avance_max);
            this.Controls.Add(this.Lbl_avance_min);
            this.Controls.Add(this.Lbl_seleccionar_auditor);
            this.Controls.Add(this.Cbo_auditores);
            this.Controls.Add(this.Cbo_avance_max);
            this.Controls.Add(this.Cbo_avance_min);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Dgv_subobjetivos);
            this.Controls.Add(this.Lbl_filtro);
            this.Controls.Add(this.Lst_seleccion_dominios);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Btn_mover_todos_izquierda);
            this.Controls.Add(this.Btn_mover_izquierda);
            this.Controls.Add(this.Btn_mover_derecha);
            this.Controls.Add(this.Btn_mover_todos_derecha);
            this.Controls.Add(this.Btn_cargar);
            this.Controls.Add(this.Lbl_seleccion_objetivos);
            this.Controls.Add(this.Cbo_objetivos);
            this.Controls.Add(this.Lbl_seleccion_dominios);
            this.Controls.Add(this.Lbl_dominios);
            this.Controls.Add(this.Lst_dominios);
            this.Controls.Add(this.Lbl_seleccionar_proyecto);
            this.Controls.Add(this.Cbo_seleccion_proyecto);
            this.Controls.Add(this.ventana1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1202, 749);
            this.Name = "FiltroSubobjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FiltroSubobjetivos";
            this.Load += new System.EventHandler(this.FiltroSubobjetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_subobjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_seleccion_proyecto;
        private System.Windows.Forms.Label Lbl_seleccionar_proyecto;
        private System.Windows.Forms.ListBox Lst_dominios;
        private System.Windows.Forms.Label Lbl_dominios;
        private System.Windows.Forms.Label Lbl_seleccion_dominios;
        private System.Windows.Forms.ComboBox Cbo_objetivos;
        private System.Windows.Forms.Label Lbl_seleccion_objetivos;
        private System.Windows.Forms.Button Btn_cargar;
        private System.Windows.Forms.Button Btn_mover_todos_izquierda;
        private System.Windows.Forms.Button Btn_mover_izquierda;
        private System.Windows.Forms.Button Btn_mover_derecha;
        private System.Windows.Forms.Button Btn_mover_todos_derecha;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.ListBox Lst_seleccion_dominios;
        private System.Windows.Forms.Label Lbl_filtro;
        private System.Windows.Forms.DataGridView Dgv_subobjetivos;
        private System.Windows.Forms.Button Btn_reporte;
        private ventanaDiseno.ventana ventana1;
        private System.Windows.Forms.ComboBox Cbo_avance_min;
        private System.Windows.Forms.ComboBox Cbo_avance_max;
        private System.Windows.Forms.ComboBox Cbo_auditores;
        private System.Windows.Forms.Label Lbl_seleccionar_auditor;
        private System.Windows.Forms.Label Lbl_avance_min;
        private System.Windows.Forms.Label Lbl_avance_max;
        private System.Windows.Forms.Label lbl_subobjetivos;
        private System.Windows.Forms.Label Lbl_porcentaje1;
        private System.Windows.Forms.Label Lbl_porcentaje2;
    }
}