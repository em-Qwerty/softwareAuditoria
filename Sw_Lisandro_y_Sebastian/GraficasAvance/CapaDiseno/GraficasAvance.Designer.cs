namespace CapaDiseno
{
    partial class GraficasAvance
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Btn_crear_grafica = new System.Windows.Forms.Button();
            this.Lbl_seleccionar = new System.Windows.Forms.Label();
            this.Cbo_seleccion = new System.Windows.Forms.ComboBox();
            this.Lst_datos_a_elegir = new System.Windows.Forms.ListBox();
            this.Lst_datos_grafica = new System.Windows.Forms.ListBox();
            this.Btn_mover_todos_derecha = new System.Windows.Forms.Button();
            this.Btn_mover_derecha = new System.Windows.Forms.Button();
            this.Btn_mover_todos_izquierda = new System.Windows.Forms.Button();
            this.Btn_mover_izquierda = new System.Windows.Forms.Button();
            this.Lbl_datos_a_elegir = new System.Windows.Forms.Label();
            this.Lbl_datos_grafica = new System.Windows.Forms.Label();
            this.Chart_avance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccionar_tipo_grafica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_avance)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_crear_grafica
            // 
            this.Btn_crear_grafica.Location = new System.Drawing.Point(24, 534);
            this.Btn_crear_grafica.Name = "Btn_crear_grafica";
            this.Btn_crear_grafica.Size = new System.Drawing.Size(418, 86);
            this.Btn_crear_grafica.TabIndex = 6;
            this.Btn_crear_grafica.Text = "Crear gráfica";
            this.Btn_crear_grafica.UseVisualStyleBackColor = true;
            this.Btn_crear_grafica.Click += new System.EventHandler(this.Btn_crear_grafica_Click);
            // 
            // Lbl_seleccionar
            // 
            this.Lbl_seleccionar.AutoSize = true;
            this.Lbl_seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_seleccionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionar.Location = new System.Drawing.Point(22, 64);
            this.Lbl_seleccionar.Name = "Lbl_seleccionar";
            this.Lbl_seleccionar.Size = new System.Drawing.Size(111, 28);
            this.Lbl_seleccionar.TabIndex = 5;
            this.Lbl_seleccionar.Text = "Seleccionar";
            // 
            // Cbo_seleccion
            // 
            this.Cbo_seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_seleccion.FormattingEnabled = true;
            this.Cbo_seleccion.Items.AddRange(new object[] {
            "Normas",
            "Dominios",
            "Objetivos",
            "Subobjetivos"});
            this.Cbo_seleccion.Location = new System.Drawing.Point(24, 104);
            this.Cbo_seleccion.Name = "Cbo_seleccion";
            this.Cbo_seleccion.Size = new System.Drawing.Size(418, 33);
            this.Cbo_seleccion.TabIndex = 4;
            this.Cbo_seleccion.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccion_SelectedIndexChanged);
            // 
            // Lst_datos_a_elegir
            // 
            this.Lst_datos_a_elegir.FormattingEnabled = true;
            this.Lst_datos_a_elegir.ItemHeight = 16;
            this.Lst_datos_a_elegir.Location = new System.Drawing.Point(24, 179);
            this.Lst_datos_a_elegir.Name = "Lst_datos_a_elegir";
            this.Lst_datos_a_elegir.Size = new System.Drawing.Size(206, 228);
            this.Lst_datos_a_elegir.TabIndex = 7;
            // 
            // Lst_datos_grafica
            // 
            this.Lst_datos_grafica.FormattingEnabled = true;
            this.Lst_datos_grafica.ItemHeight = 16;
            this.Lst_datos_grafica.Location = new System.Drawing.Point(236, 179);
            this.Lst_datos_grafica.Name = "Lst_datos_grafica";
            this.Lst_datos_grafica.Size = new System.Drawing.Size(206, 228);
            this.Lst_datos_grafica.TabIndex = 8;
            // 
            // Btn_mover_todos_derecha
            // 
            this.Btn_mover_todos_derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_derecha.Location = new System.Drawing.Point(24, 413);
            this.Btn_mover_todos_derecha.Name = "Btn_mover_todos_derecha";
            this.Btn_mover_todos_derecha.Size = new System.Drawing.Size(100, 35);
            this.Btn_mover_todos_derecha.TabIndex = 9;
            this.Btn_mover_todos_derecha.Text = ">>";
            this.Btn_mover_todos_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_derecha.Click += new System.EventHandler(this.Btn_mover_todos_derecha_Click);
            // 
            // Btn_mover_derecha
            // 
            this.Btn_mover_derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_derecha.Location = new System.Drawing.Point(130, 413);
            this.Btn_mover_derecha.Name = "Btn_mover_derecha";
            this.Btn_mover_derecha.Size = new System.Drawing.Size(100, 35);
            this.Btn_mover_derecha.TabIndex = 10;
            this.Btn_mover_derecha.Text = ">";
            this.Btn_mover_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_derecha.Click += new System.EventHandler(this.Btn_mover_derecha_Click);
            // 
            // Btn_mover_todos_izquierda
            // 
            this.Btn_mover_todos_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_izquierda.Location = new System.Drawing.Point(342, 413);
            this.Btn_mover_todos_izquierda.Name = "Btn_mover_todos_izquierda";
            this.Btn_mover_todos_izquierda.Size = new System.Drawing.Size(100, 35);
            this.Btn_mover_todos_izquierda.TabIndex = 12;
            this.Btn_mover_todos_izquierda.Text = "<<";
            this.Btn_mover_todos_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_izquierda.Click += new System.EventHandler(this.Btn_mover_todos_izquierda_Click);
            // 
            // Btn_mover_izquierda
            // 
            this.Btn_mover_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_izquierda.Location = new System.Drawing.Point(236, 413);
            this.Btn_mover_izquierda.Name = "Btn_mover_izquierda";
            this.Btn_mover_izquierda.Size = new System.Drawing.Size(100, 35);
            this.Btn_mover_izquierda.TabIndex = 11;
            this.Btn_mover_izquierda.Text = "<";
            this.Btn_mover_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_izquierda.Click += new System.EventHandler(this.Btn_mover_izquierda_Click);
            // 
            // Lbl_datos_a_elegir
            // 
            this.Lbl_datos_a_elegir.AutoSize = true;
            this.Lbl_datos_a_elegir.Location = new System.Drawing.Point(24, 156);
            this.Lbl_datos_a_elegir.Name = "Lbl_datos_a_elegir";
            this.Lbl_datos_a_elegir.Size = new System.Drawing.Size(96, 17);
            this.Lbl_datos_a_elegir.TabIndex = 13;
            this.Lbl_datos_a_elegir.Text = "Datos a elegir";
            // 
            // Lbl_datos_grafica
            // 
            this.Lbl_datos_grafica.AutoSize = true;
            this.Lbl_datos_grafica.Location = new System.Drawing.Point(233, 156);
            this.Lbl_datos_grafica.Name = "Lbl_datos_grafica";
            this.Lbl_datos_grafica.Size = new System.Drawing.Size(92, 17);
            this.Lbl_datos_grafica.TabIndex = 14;
            this.Lbl_datos_grafica.Text = "Datos gráfica";
            // 
            // Chart_avance
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_avance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_avance.Legends.Add(legend1);
            this.Chart_avance.Location = new System.Drawing.Point(459, 104);
            this.Chart_avance.Name = "Chart_avance";
            this.Chart_avance.Size = new System.Drawing.Size(647, 516);
            this.Chart_avance.TabIndex = 15;
            this.Chart_avance.Text = "Chart_Avance";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 484);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(415, 33);
            this.comboBox2.TabIndex = 17;
            // 
            // Lbl_seleccionar_tipo_grafica
            // 
            this.Lbl_seleccionar_tipo_grafica.AutoSize = true;
            this.Lbl_seleccionar_tipo_grafica.Location = new System.Drawing.Point(24, 464);
            this.Lbl_seleccionar_tipo_grafica.Name = "Lbl_seleccionar_tipo_grafica";
            this.Lbl_seleccionar_tipo_grafica.Size = new System.Drawing.Size(103, 17);
            this.Lbl_seleccionar_tipo_grafica.TabIndex = 18;
            this.Lbl_seleccionar_tipo_grafica.Text = "Tipo de gráfica";
            // 
            // GraficasAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.Lbl_seleccionar_tipo_grafica);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Chart_avance);
            this.Controls.Add(this.Lbl_datos_grafica);
            this.Controls.Add(this.Lbl_datos_a_elegir);
            this.Controls.Add(this.Btn_mover_todos_izquierda);
            this.Controls.Add(this.Btn_mover_izquierda);
            this.Controls.Add(this.Btn_mover_derecha);
            this.Controls.Add(this.Btn_mover_todos_derecha);
            this.Controls.Add(this.Lst_datos_grafica);
            this.Controls.Add(this.Lst_datos_a_elegir);
            this.Controls.Add(this.Btn_crear_grafica);
            this.Controls.Add(this.Lbl_seleccionar);
            this.Controls.Add(this.Cbo_seleccion);
            this.Name = "GraficasAvance";
            this.Size = new System.Drawing.Size(1140, 643);
            this.Load += new System.EventHandler(this.GraficasAvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_avance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_crear_grafica;
        private System.Windows.Forms.Label Lbl_seleccionar;
        private System.Windows.Forms.ComboBox Cbo_seleccion;
        private System.Windows.Forms.ListBox Lst_datos_a_elegir;
        private System.Windows.Forms.ListBox Lst_datos_grafica;
        private System.Windows.Forms.Button Btn_mover_todos_derecha;
        private System.Windows.Forms.Button Btn_mover_derecha;
        private System.Windows.Forms.Button Btn_mover_todos_izquierda;
        private System.Windows.Forms.Button Btn_mover_izquierda;
        private System.Windows.Forms.Label Lbl_datos_a_elegir;
        private System.Windows.Forms.Label Lbl_datos_grafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_avance;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Lbl_seleccionar_tipo_grafica;
    }
}
