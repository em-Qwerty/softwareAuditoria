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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Cbo_seleccion = new System.Windows.Forms.ComboBox();
            this.Btn_crear_grafica = new System.Windows.Forms.Button();
            this.Lst_datos_a_elegir = new System.Windows.Forms.ListBox();
            this.Lst_datos_grafica = new System.Windows.Forms.ListBox();
            this.Btn_mover_todos_derecha = new System.Windows.Forms.Button();
            this.Btn_mover_derecha = new System.Windows.Forms.Button();
            this.Btn_mover_izquierda = new System.Windows.Forms.Button();
            this.Btn_mover_todos_izquierda = new System.Windows.Forms.Button();
            this.Lbl_datos_a_elegir = new System.Windows.Forms.Label();
            this.Lbl_datos_grafica = new System.Windows.Forms.Label();
            this.Chart_avance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cbo_tipo_grafica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_avance)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_seleccion
            // 
            this.Cbo_seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_seleccion.FormattingEnabled = true;
            this.Cbo_seleccion.Items.AddRange(new object[] {
            "Dominios",
            "Objetivos",
            "Subobjetivos"});
            this.Cbo_seleccion.Location = new System.Drawing.Point(24, 97);
            this.Cbo_seleccion.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_seleccion.Name = "Cbo_seleccion";
            this.Cbo_seleccion.Size = new System.Drawing.Size(314, 25);
            this.Cbo_seleccion.TabIndex = 1;
            this.Cbo_seleccion.Text = "Seleccionar parte de la norma...";
            this.Cbo_seleccion.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccion_SelectedIndexChanged);
            // 
            // Btn_crear_grafica
            // 
            this.Btn_crear_grafica.Location = new System.Drawing.Point(26, 700);
            this.Btn_crear_grafica.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear_grafica.Name = "Btn_crear_grafica";
            this.Btn_crear_grafica.Size = new System.Drawing.Size(314, 27);
            this.Btn_crear_grafica.TabIndex = 7;
            this.Btn_crear_grafica.Text = "Crear gráfica";
            this.Btn_crear_grafica.UseVisualStyleBackColor = true;
            this.Btn_crear_grafica.Click += new System.EventHandler(this.Btn_crear_grafica_Click);
            // 
            // Lst_datos_a_elegir
            // 
            this.Lst_datos_a_elegir.FormattingEnabled = true;
            this.Lst_datos_a_elegir.Location = new System.Drawing.Point(24, 148);
            this.Lst_datos_a_elegir.Margin = new System.Windows.Forms.Padding(2);
            this.Lst_datos_a_elegir.Name = "Lst_datos_a_elegir";
            this.Lst_datos_a_elegir.Size = new System.Drawing.Size(156, 485);
            this.Lst_datos_a_elegir.TabIndex = 0;
            // 
            // Lst_datos_grafica
            // 
            this.Lst_datos_grafica.FormattingEnabled = true;
            this.Lst_datos_grafica.Location = new System.Drawing.Point(183, 148);
            this.Lst_datos_grafica.Margin = new System.Windows.Forms.Padding(2);
            this.Lst_datos_grafica.Name = "Lst_datos_grafica";
            this.Lst_datos_grafica.Size = new System.Drawing.Size(156, 485);
            this.Lst_datos_grafica.TabIndex = 0;
            // 
            // Btn_mover_todos_derecha
            // 
            this.Btn_mover_todos_derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_derecha.Location = new System.Drawing.Point(104, 639);
            this.Btn_mover_todos_derecha.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_todos_derecha.Name = "Btn_mover_todos_derecha";
            this.Btn_mover_todos_derecha.Size = new System.Drawing.Size(75, 28);
            this.Btn_mover_todos_derecha.TabIndex = 3;
            this.Btn_mover_todos_derecha.Text = ">>";
            this.Btn_mover_todos_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_derecha.Click += new System.EventHandler(this.Btn_mover_todos_derecha_Click);
            // 
            // Btn_mover_derecha
            // 
            this.Btn_mover_derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_derecha.Location = new System.Drawing.Point(24, 639);
            this.Btn_mover_derecha.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_derecha.Name = "Btn_mover_derecha";
            this.Btn_mover_derecha.Size = new System.Drawing.Size(75, 28);
            this.Btn_mover_derecha.TabIndex = 2;
            this.Btn_mover_derecha.Text = ">";
            this.Btn_mover_derecha.UseVisualStyleBackColor = true;
            this.Btn_mover_derecha.Click += new System.EventHandler(this.Btn_mover_derecha_Click);
            // 
            // Btn_mover_izquierda
            // 
            this.Btn_mover_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_izquierda.Location = new System.Drawing.Point(262, 639);
            this.Btn_mover_izquierda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_izquierda.Name = "Btn_mover_izquierda";
            this.Btn_mover_izquierda.Size = new System.Drawing.Size(75, 28);
            this.Btn_mover_izquierda.TabIndex = 5;
            this.Btn_mover_izquierda.Text = "<";
            this.Btn_mover_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_izquierda.Click += new System.EventHandler(this.Btn_mover_izquierda_Click);
            // 
            // Btn_mover_todos_izquierda
            // 
            this.Btn_mover_todos_izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mover_todos_izquierda.Location = new System.Drawing.Point(183, 639);
            this.Btn_mover_todos_izquierda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mover_todos_izquierda.Name = "Btn_mover_todos_izquierda";
            this.Btn_mover_todos_izquierda.Size = new System.Drawing.Size(75, 28);
            this.Btn_mover_todos_izquierda.TabIndex = 4;
            this.Btn_mover_todos_izquierda.Text = "<<";
            this.Btn_mover_todos_izquierda.UseVisualStyleBackColor = true;
            this.Btn_mover_todos_izquierda.Click += new System.EventHandler(this.Btn_mover_todos_izquierda_Click);
            // 
            // Lbl_datos_a_elegir
            // 
            this.Lbl_datos_a_elegir.AutoSize = true;
            this.Lbl_datos_a_elegir.Location = new System.Drawing.Point(24, 134);
            this.Lbl_datos_a_elegir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_datos_a_elegir.Name = "Lbl_datos_a_elegir";
            this.Lbl_datos_a_elegir.Size = new System.Drawing.Size(72, 13);
            this.Lbl_datos_a_elegir.TabIndex = 0;
            this.Lbl_datos_a_elegir.Text = "Datos a elegir";
            // 
            // Lbl_datos_grafica
            // 
            this.Lbl_datos_grafica.AutoSize = true;
            this.Lbl_datos_grafica.Location = new System.Drawing.Point(181, 134);
            this.Lbl_datos_grafica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_datos_grafica.Name = "Lbl_datos_grafica";
            this.Lbl_datos_grafica.Size = new System.Drawing.Size(70, 13);
            this.Lbl_datos_grafica.TabIndex = 0;
            this.Lbl_datos_grafica.Text = "Datos gráfica";
            // 
            // Chart_avance
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.Chart_avance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_avance.Legends.Add(legend1);
            this.Chart_avance.Location = new System.Drawing.Point(350, 97);
            this.Chart_avance.Margin = new System.Windows.Forms.Padding(2);
            this.Chart_avance.Name = "Chart_avance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Progreso";
            this.Chart_avance.Series.Add(series1);
            this.Chart_avance.Size = new System.Drawing.Size(823, 630);
            this.Chart_avance.TabIndex = 0;
            this.Chart_avance.Text = "Chart_Avance";
            // 
            // Cbo_tipo_grafica
            // 
            this.Cbo_tipo_grafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipo_grafica.FormattingEnabled = true;
            this.Cbo_tipo_grafica.Items.AddRange(new object[] {
            "Barras",
            "Pie",
            "Radar",
            "Dona",
            "Area"});
            this.Cbo_tipo_grafica.Location = new System.Drawing.Point(28, 672);
            this.Cbo_tipo_grafica.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_tipo_grafica.Name = "Cbo_tipo_grafica";
            this.Cbo_tipo_grafica.Size = new System.Drawing.Size(312, 25);
            this.Cbo_tipo_grafica.TabIndex = 6;
            this.Cbo_tipo_grafica.Text = "Seleccionar tipo de gráfica...";
            this.Cbo_tipo_grafica.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_grafica_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Gráfica";
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1202, 749);
            this.ventana1.TabIndex = 8;
            // 
            // GraficasAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1202, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_tipo_grafica);
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
            this.Controls.Add(this.Cbo_seleccion);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1202, 749);
            this.Name = "GraficasAvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GraficasAvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_avance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_seleccion;
        private System.Windows.Forms.Button Btn_crear_grafica;
        private System.Windows.Forms.ListBox Lst_datos_a_elegir;
        private System.Windows.Forms.ListBox Lst_datos_grafica;
        private System.Windows.Forms.Button Btn_mover_todos_derecha;
        private System.Windows.Forms.Button Btn_mover_derecha;
        private System.Windows.Forms.Button Btn_mover_izquierda;
        private System.Windows.Forms.Button Btn_mover_todos_izquierda;
        private System.Windows.Forms.Label Lbl_datos_a_elegir;
        private System.Windows.Forms.Label Lbl_datos_grafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_avance;
        private System.Windows.Forms.ComboBox Cbo_tipo_grafica;
        private System.Windows.Forms.Label label1;
        private ventanaDiseno.ventana ventana1;
    }
}
