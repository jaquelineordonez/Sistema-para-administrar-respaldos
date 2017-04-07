namespace SistemaParaAdministrarRespaldos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_nueva = new System.Windows.Forms.ToolStripButton();
            this.tsb_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ejecutar = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chk_seleccionartodo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ejecucion = new System.Windows.Forms.DataGridView();
            this.Nombre_TareaZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_SalidaZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejecucion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Tarea,
            this.Seleccionar,
            this.Nombre_Tarea,
            this.Fecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(432, 201);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_Tarea
            // 
            this.ID_Tarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.ID_Tarea.DataPropertyName = "ID_Tarea";
            this.ID_Tarea.FillWeight = 200F;
            this.ID_Tarea.HeaderText = "ID";
            this.ID_Tarea.MinimumWidth = 50;
            this.ID_Tarea.Name = "ID_Tarea";
            this.ID_Tarea.ReadOnly = true;
            this.ID_Tarea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Tarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ID_Tarea.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 69;
            this.Seleccionar.Name = "Seleccionar";
            // 
            // Nombre_Tarea
            // 
            this.Nombre_Tarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Nombre_Tarea.DataPropertyName = "Nombre_Tarea";
            this.Nombre_Tarea.FillWeight = 200F;
            this.Nombre_Tarea.HeaderText = "Nombre de la Tarea";
            this.Nombre_Tarea.MinimumWidth = 150;
            this.Nombre_Tarea.Name = "Nombre_Tarea";
            this.Nombre_Tarea.ReadOnly = true;
            this.Nombre_Tarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre_Tarea.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.FillWeight = 200F;
            this.Fecha.HeaderText = "Fecha de creacion";
            this.Fecha.MinimumWidth = 150;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Fecha.Width = 150;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_nueva,
            this.tsb_editar,
            this.toolStripSeparator2,
            this.tsb_eliminar,
            this.toolStripSeparator3,
            this.tsb_ejecutar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(805, 38);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsb_nueva
            // 
            this.tsb_nueva.Image = ((System.Drawing.Image)(resources.GetObject("tsb_nueva.Image")));
            this.tsb_nueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_nueva.Name = "tsb_nueva";
            this.tsb_nueva.Size = new System.Drawing.Size(77, 35);
            this.tsb_nueva.Text = "Nueva Tarea";
            this.tsb_nueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_nueva.Click += new System.EventHandler(this.tsb_nueva_Click);
            // 
            // tsb_editar
            // 
            this.tsb_editar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_editar.Image")));
            this.tsb_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_editar.Name = "tsb_editar";
            this.tsb_editar.Size = new System.Drawing.Size(73, 35);
            this.tsb_editar.Text = "Editar Tarea";
            this.tsb_editar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsb_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_editar.Click += new System.EventHandler(this.tsb_editar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsb_eliminar
            // 
            this.tsb_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_eliminar.Image")));
            this.tsb_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_eliminar.Name = "tsb_eliminar";
            this.tsb_eliminar.Size = new System.Drawing.Size(86, 35);
            this.tsb_eliminar.Text = "Eliminar Tarea";
            this.tsb_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_eliminar.Click += new System.EventHandler(this.tsb_eliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tsb_ejecutar
            // 
            this.tsb_ejecutar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ejecutar.Image")));
            this.tsb_ejecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ejecutar.Name = "tsb_ejecutar";
            this.tsb_ejecutar.Size = new System.Drawing.Size(53, 35);
            this.tsb_ejecutar.Text = "Ejecutar";
            this.tsb_ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_ejecutar.Click += new System.EventHandler(this.tsb_ejecutar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(160, 344);
            this.treeView1.TabIndex = 11;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView2.Location = new System.Drawing.Point(595, 62);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(210, 344);
            this.treeView2.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(160, 62);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 344);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(163, 62);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chk_seleccionartodo);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(432, 344);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 14;
            // 
            // chk_seleccionartodo
            // 
            this.chk_seleccionartodo.AutoSize = true;
            this.chk_seleccionartodo.Location = new System.Drawing.Point(48, 4);
            this.chk_seleccionartodo.Name = "chk_seleccionartodo";
            this.chk_seleccionartodo.Size = new System.Drawing.Size(15, 14);
            this.chk_seleccionartodo.TabIndex = 6;
            this.chk_seleccionartodo.UseVisualStyleBackColor = true;
            this.chk_seleccionartodo.CheckedChanged += new System.EventHandler(this.chk_seleccionartodo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgv_ejecucion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(510, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log de ejecuciones";
            // 
            // dgv_ejecucion
            // 
            this.dgv_ejecucion.AllowUserToAddRows = false;
            this.dgv_ejecucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ejecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ejecucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_TareaZip,
            this.FechaHoraZip,
            this.Ruta_SalidaZip});
            this.dgv_ejecucion.Location = new System.Drawing.Point(6, 19);
            this.dgv_ejecucion.Name = "dgv_ejecucion";
            this.dgv_ejecucion.RowHeadersWidth = 5;
            this.dgv_ejecucion.Size = new System.Drawing.Size(408, 106);
            this.dgv_ejecucion.TabIndex = 18;
            this.dgv_ejecucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ejecucion_CellContentClick);
            // 
            // Nombre_TareaZip
            // 
            this.Nombre_TareaZip.DataPropertyName = "Nombre_TareaZip";
            this.Nombre_TareaZip.HeaderText = "Nombre de la tarea";
            this.Nombre_TareaZip.Name = "Nombre_TareaZip";
            this.Nombre_TareaZip.ReadOnly = true;
            this.Nombre_TareaZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre_TareaZip.Width = 130;
            // 
            // FechaHoraZip
            // 
            this.FechaHoraZip.DataPropertyName = "FechaHoraZip";
            this.FechaHoraZip.HeaderText = "Fecha de ejecucion";
            this.FechaHoraZip.Name = "FechaHoraZip";
            this.FechaHoraZip.ReadOnly = true;
            this.FechaHoraZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FechaHoraZip.Width = 130;
            // 
            // Ruta_SalidaZip
            // 
            this.Ruta_SalidaZip.DataPropertyName = "Ruta_SalidaZip";
            this.Ruta_SalidaZip.HeaderText = "Ruta de salida del zip";
            this.Ruta_SalidaZip.Name = "Ruta_SalidaZip";
            this.Ruta_SalidaZip.ReadOnly = true;
            this.Ruta_SalidaZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ruta_SalidaZip.Width = 140;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::SistemaParaAdministrarRespaldos.Properties.Resources._1486521491_close2;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 406);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Respaldos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejecucion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_nueva;
        private System.Windows.Forms.ToolStripButton tsb_editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_ejecutar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chk_seleccionartodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ejecucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_TareaZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_SalidaZip;
    }
}

