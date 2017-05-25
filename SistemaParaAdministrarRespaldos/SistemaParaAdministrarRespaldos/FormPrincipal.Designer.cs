namespace SistemaParaAdministrarRespaldos
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_nueva = new System.Windows.Forms.ToolStripButton();
            this.tsb_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ejecutar = new System.Windows.Forms.ToolStripButton();
            this.tsb_imprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ejecucion = new System.Windows.Forms.DataGridView();
            this.Nombre_TareaZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_SalidaZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.list_ejecuciones = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_seleccionartodo = new System.Windows.Forms.CheckBox();
            this.dgv_tareas = new System.Windows.Forms.DataGridView();
            this.ID_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejecucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_nueva,
            this.tsb_editar,
            this.toolStripSeparator2,
            this.tsb_eliminar,
            this.toolStripSeparator3,
            this.tsb_ejecutar,
            this.tsb_imprimir});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(838, 38);
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
            // tsb_imprimir
            // 
            this.tsb_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_imprimir.Image")));
            this.tsb_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_imprimir.Name = "tsb_imprimir";
            this.tsb_imprimir.Size = new System.Drawing.Size(57, 35);
            this.tsb_imprimir.Text = "Imprimir";
            this.tsb_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_imprimir.Click += new System.EventHandler(this.tsb_imprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgv_ejecucion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(486, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log de ejecuciones";
            // 
            // dgv_ejecucion
            // 
            this.dgv_ejecucion.AllowUserToAddRows = false;
            this.dgv_ejecucion.AllowUserToDeleteRows = false;
            this.dgv_ejecucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_ejecucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ejecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ejecucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_TareaZip,
            this.FechaHoraZip,
            this.Ruta_SalidaZip});
            this.dgv_ejecucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ejecucion.Location = new System.Drawing.Point(3, 16);
            this.dgv_ejecucion.Name = "dgv_ejecucion";
            this.dgv_ejecucion.RowHeadersWidth = 5;
            this.dgv_ejecucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ejecucion.Size = new System.Drawing.Size(480, 137);
            this.dgv_ejecucion.TabIndex = 18;
            // 
            // Nombre_TareaZip
            // 
            this.Nombre_TareaZip.DataPropertyName = "Nombre_TareaZip";
            this.Nombre_TareaZip.HeaderText = "Nombre de la tarea";
            this.Nombre_TareaZip.Name = "Nombre_TareaZip";
            this.Nombre_TareaZip.ReadOnly = true;
            this.Nombre_TareaZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre_TareaZip.Width = 90;
            // 
            // FechaHoraZip
            // 
            this.FechaHoraZip.DataPropertyName = "FechaHoraZip";
            this.FechaHoraZip.HeaderText = "Fecha de ejecucion";
            this.FechaHoraZip.Name = "FechaHoraZip";
            this.FechaHoraZip.ReadOnly = true;
            this.FechaHoraZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FechaHoraZip.Width = 115;
            // 
            // Ruta_SalidaZip
            // 
            this.Ruta_SalidaZip.DataPropertyName = "Ruta_SalidaZip";
            this.Ruta_SalidaZip.HeaderText = "Ruta de salida del zip";
            this.Ruta_SalidaZip.Name = "Ruta_SalidaZip";
            this.Ruta_SalidaZip.ReadOnly = true;
            this.Ruta_SalidaZip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Ruta_SalidaZip.Width = 95;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(835, 38);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 402);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // list_ejecuciones
            // 
            this.list_ejecuciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_ejecuciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.list_ejecuciones.Location = new System.Drawing.Point(3, 11);
            this.list_ejecuciones.Name = "list_ejecuciones";
            this.list_ejecuciones.Size = new System.Drawing.Size(324, 384);
            this.list_ejecuciones.TabIndex = 20;
            this.list_ejecuciones.UseCompatibleStateImageBehavior = false;
            this.list_ejecuciones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha y hora";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ruta salida Zip";
            this.columnHeader3.Width = 400;
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 38);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(835, 402);
            this.splitContainer2.SplitterDistance = 495;
            this.splitContainer2.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chk_seleccionartodo);
            this.groupBox2.Controls.Add(this.dgv_tareas);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 233);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // chk_seleccionartodo
            // 
            this.chk_seleccionartodo.AutoSize = true;
            this.chk_seleccionartodo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_seleccionartodo.Location = new System.Drawing.Point(36, 21);
            this.chk_seleccionartodo.Name = "chk_seleccionartodo";
            this.chk_seleccionartodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_seleccionartodo.Size = new System.Drawing.Size(15, 14);
            this.chk_seleccionartodo.TabIndex = 6;
            this.chk_seleccionartodo.UseVisualStyleBackColor = true;
            this.chk_seleccionartodo.CheckedChanged += new System.EventHandler(this.chk_seleccionartodo_CheckedChanged);
            // 
            // dgv_tareas
            // 
            this.dgv_tareas.AllowUserToAddRows = false;
            this.dgv_tareas.AllowUserToDeleteRows = false;
            this.dgv_tareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tareas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Tarea,
            this.Seleccionar,
            this.Nombre_Tarea,
            this.Fecha});
            this.dgv_tareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tareas.Location = new System.Drawing.Point(3, 16);
            this.dgv_tareas.Name = "dgv_tareas";
            this.dgv_tareas.RowHeadersWidth = 5;
            this.dgv_tareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tareas.Size = new System.Drawing.Size(480, 214);
            this.dgv_tareas.TabIndex = 5;
            this.dgv_tareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_tareas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_Tarea
            // 
            this.ID_Tarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.ID_Tarea.DataPropertyName = "ID_Tarea";
            this.ID_Tarea.FillWeight = 200F;
            this.ID_Tarea.Frozen = true;
            this.ID_Tarea.HeaderText = "ID";
            this.ID_Tarea.MinimumWidth = 50;
            this.ID_Tarea.Name = "ID_Tarea";
            this.ID_Tarea.ReadOnly = true;
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
            this.Nombre_Tarea.DataPropertyName = "Nombre_Tarea";
            this.Nombre_Tarea.FillWeight = 200F;
            this.Nombre_Tarea.HeaderText = "Nombre de la Tarea";
            this.Nombre_Tarea.MinimumWidth = 150;
            this.Nombre_Tarea.Name = "Nombre_Tarea";
            this.Nombre_Tarea.ReadOnly = true;
            this.Nombre_Tarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.FillWeight = 200F;
            this.Fecha.HeaderText = "Fecha de creacion";
            this.Fecha.MinimumWidth = 150;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.list_ejecuciones);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 396);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(838, 440);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion de Respaldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejecucion)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ejecucion;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView list_ejecuciones;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chk_seleccionartodo;
        private System.Windows.Forms.DataGridView dgv_tareas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_TareaZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_SalidaZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.ToolStripButton tsb_imprimir;
    }
}

