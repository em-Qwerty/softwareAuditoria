namespace MDIPrincipal
{
    partial class Index
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dominioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRecursoDeTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAsignaciónAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MDIPrincipal.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(743, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MDIPrincipal.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(771, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.mundoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(59, 27);
            this.holaToolStripMenuItem.Text = "Inicio";
            this.holaToolStripMenuItem.Click += new System.EventHandler(this.HolaToolStripMenuItem_Click);
            // 
            // mundoToolStripMenuItem
            // 
            this.mundoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dominioToolStripMenuItem,
            this.objetivoToolStripMenuItem,
            this.normativaToolStripMenuItem,
            this.proyectoToolStripMenuItem});
            this.mundoToolStripMenuItem.Name = "mundoToolStripMenuItem";
            this.mundoToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.mundoToolStripMenuItem.Text = "Actividades";
            this.mundoToolStripMenuItem.Click += new System.EventHandler(this.MundoToolStripMenuItem_Click);
            // 
            // dominioToolStripMenuItem
            // 
            this.dominioToolStripMenuItem.Name = "dominioToolStripMenuItem";
            this.dominioToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.dominioToolStripMenuItem.Text = "Dominio";
            this.dominioToolStripMenuItem.Click += new System.EventHandler(this.DominioToolStripMenuItem_Click);
            // 
            // objetivoToolStripMenuItem
            // 
            this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
            this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.objetivoToolStripMenuItem.Text = "Objetivo";
            this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.ObjetivoToolStripMenuItem_Click);
            // 
            // normativaToolStripMenuItem
            // 
            this.normativaToolStripMenuItem.Name = "normativaToolStripMenuItem";
            this.normativaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.normativaToolStripMenuItem.Text = "Normativa";
            this.normativaToolStripMenuItem.Click += new System.EventHandler(this.NormativaToolStripMenuItem_Click);
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            this.proyectoToolStripMenuItem.Click += new System.EventHandler(this.ProyectoToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoAnalisisToolStripMenuItem,
            this.mantenimientoAuditorToolStripMenuItem,
            this.mantenimientoDepartamentosToolStripMenuItem,
            this.mantenimientoRecursoDeTIToolStripMenuItem,
            this.mantenimientoAsignaciónAuditorToolStripMenuItem,
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoAnalisisToolStripMenuItem
            // 
            this.mantenimientoAnalisisToolStripMenuItem.Name = "mantenimientoAnalisisToolStripMenuItem";
            this.mantenimientoAnalisisToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoAnalisisToolStripMenuItem.Text = "Mantenimiento analisis";
            this.mantenimientoAnalisisToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoAnalisisToolStripMenuItem_Click);
            // 
            // mantenimientoAuditorToolStripMenuItem
            // 
            this.mantenimientoAuditorToolStripMenuItem.Name = "mantenimientoAuditorToolStripMenuItem";
            this.mantenimientoAuditorToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoAuditorToolStripMenuItem.Text = "Mantenimiento auditor";
            this.mantenimientoAuditorToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoAuditorToolStripMenuItem_Click);
            // 
            // mantenimientoDepartamentosToolStripMenuItem
            // 
            this.mantenimientoDepartamentosToolStripMenuItem.Name = "mantenimientoDepartamentosToolStripMenuItem";
            this.mantenimientoDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoDepartamentosToolStripMenuItem.Text = "Mantenimiento Departamentos";
            this.mantenimientoDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoDepartamentosToolStripMenuItem_Click);
            // 
            // mantenimientoRecursoDeTIToolStripMenuItem
            // 
            this.mantenimientoRecursoDeTIToolStripMenuItem.Name = "mantenimientoRecursoDeTIToolStripMenuItem";
            this.mantenimientoRecursoDeTIToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoRecursoDeTIToolStripMenuItem.Text = "Mantenimiento Recurso de TI";
            this.mantenimientoRecursoDeTIToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoRecursoDeTIToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
            // 
            // mantenimientoAsignaciónAuditorToolStripMenuItem
            // 
            this.mantenimientoAsignaciónAuditorToolStripMenuItem.Name = "mantenimientoAsignaciónAuditorToolStripMenuItem";
            this.mantenimientoAsignaciónAuditorToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoAsignaciónAuditorToolStripMenuItem.Text = "Mantenimiento Asignación auditor";
            this.mantenimientoAsignaciónAuditorToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoAsignaciónAuditorToolStripMenuItem_Click);
            // 
            // mantenimientoAsignaciónRecursosDeTIToolStripMenuItem
            // 
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem.Name = "mantenimientoAsignaciónRecursosDeTIToolStripMenuItem";
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem.Text = "Mantenimiento Asignación recursos de TI";
            this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoAsignaciónRecursosDeTIToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mundoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dominioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAuditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRecursoDeTIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAsignaciónAuditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAsignaciónRecursosDeTIToolStripMenuItem;
    }
}

