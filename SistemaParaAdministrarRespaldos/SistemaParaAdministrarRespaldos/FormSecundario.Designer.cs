namespace SistemaParaAdministrarRespaldos
{
    partial class FormSecundario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecundario));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombretarea = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_archivos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datos_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuitar = new System.Windows.Forms.ToolStripButton();
            this.chk_seleccionartodo = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_confirmarcontraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.chk_password = new System.Windows.Forms.CheckBox();
            this.chk_sobreescribir = new System.Windows.Forms.CheckBox();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ruta = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archivos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la tarea";
            // 
            // txt_nombretarea
            // 
            this.txt_nombretarea.Location = new System.Drawing.Point(34, 47);
            this.txt_nombretarea.MaxLength = 50;
            this.txt_nombretarea.Name = "txt_nombretarea";
            this.txt_nombretarea.Size = new System.Drawing.Size(328, 20);
            this.txt_nombretarea.TabIndex = 1;
            this.txt_nombretarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombretarea_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // dgv_archivos
            // 
            this.dgv_archivos.AllowUserToAddRows = false;
            this.dgv_archivos.AllowUserToDeleteRows = false;
            this.dgv_archivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_archivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_archivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_archivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.ID_Archivo,
            this.ID_Tarea,
            this.Datos_Archivo});
            this.dgv_archivos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_archivos.Location = new System.Drawing.Point(-4, 47);
            this.dgv_archivos.Name = "dgv_archivos";
            this.dgv_archivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_archivos.Size = new System.Drawing.Size(652, 180);
            this.dgv_archivos.TabIndex = 5;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.FillWeight = 111.6751F;
            this.Seleccionar.Frozen = true;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 69;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 329;
            // 
            // ID_Archivo
            // 
            this.ID_Archivo.DataPropertyName = "ID_Archivo";
            this.ID_Archivo.Frozen = true;
            this.ID_Archivo.HeaderText = "ID_Archivo";
            this.ID_Archivo.Name = "ID_Archivo";
            this.ID_Archivo.Visible = false;
            // 
            // ID_Tarea
            // 
            this.ID_Tarea.DataPropertyName = "ID_Tarea";
            this.ID_Tarea.Frozen = true;
            this.ID_Tarea.HeaderText = "ID_Tarea";
            this.ID_Tarea.Name = "ID_Tarea";
            this.ID_Tarea.Visible = false;
            // 
            // Datos_Archivo
            // 
            this.Datos_Archivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Datos_Archivo.DataPropertyName = "Datos_Archivo";
            this.Datos_Archivo.FillWeight = 88.32487F;
            this.Datos_Archivo.Frozen = true;
            this.Datos_Archivo.HeaderText = "Archivo";
            this.Datos_Archivo.Name = "Datos_Archivo";
            this.Datos_Archivo.ReadOnly = true;
            this.Datos_Archivo.Width = 68;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 250);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_nombretarea);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ImageIndex = 2;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuracion Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.chk_seleccionartodo);
            this.tabPage2.Controls.Add(this.dgv_archivos);
            this.tabPage2.ImageIndex = 3;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archivos a guardar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.toolStripSeparator2,
            this.tsbQuitar});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(638, 38);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(53, 35);
            this.tsbAgregar.Text = "&Agregar";
            this.tsbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbQuitar
            // 
            this.tsbQuitar.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitar.Image")));
            this.tsbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitar.Name = "tsbQuitar";
            this.tsbQuitar.Size = new System.Drawing.Size(44, 35);
            this.tsbQuitar.Text = "&Quitar";
            this.tsbQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbQuitar.Click += new System.EventHandler(this.tsbQuitar_Click);
            // 
            // chk_seleccionartodo
            // 
            this.chk_seleccionartodo.AutoSize = true;
            this.chk_seleccionartodo.Location = new System.Drawing.Point(64, 51);
            this.chk_seleccionartodo.Name = "chk_seleccionartodo";
            this.chk_seleccionartodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_seleccionartodo.Size = new System.Drawing.Size(15, 14);
            this.chk_seleccionartodo.TabIndex = 8;
            this.chk_seleccionartodo.TabStop = false;
            this.chk_seleccionartodo.UseVisualStyleBackColor = true;
            this.chk_seleccionartodo.CheckedChanged += new System.EventHandler(this.chk_seleccionartodo_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_confirmarcontraseña);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.chk_visible);
            this.tabPage3.Controls.Add(this.txt_contraseña);
            this.tabPage3.Controls.Add(this.chk_password);
            this.tabPage3.Controls.Add(this.chk_sobreescribir);
            this.tabPage3.Controls.Add(this.txt_ruta);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_ruta);
            this.tabPage3.ImageIndex = 5;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(644, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ruta de salida";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_confirmarcontraseña
            // 
            this.txt_confirmarcontraseña.Enabled = false;
            this.txt_confirmarcontraseña.Location = new System.Drawing.Point(189, 124);
            this.txt_confirmarcontraseña.Name = "txt_confirmarcontraseña";
            this.txt_confirmarcontraseña.Size = new System.Drawing.Size(284, 20);
            this.txt_confirmarcontraseña.TabIndex = 9;
            this.txt_confirmarcontraseña.UseSystemPasswordChar = true;
            this.txt_confirmarcontraseña.TextChanged += new System.EventHandler(this.txt_confirmarcontraseña_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar";
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Image = global::SistemaParaAdministrarRespaldos.Properties.Resources._1489533888_eye;
            this.chk_visible.Location = new System.Drawing.Point(479, 85);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(47, 32);
            this.chk_visible.TabIndex = 7;
            this.chk_visible.UseVisualStyleBackColor = true;
            this.chk_visible.CheckedChanged += new System.EventHandler(this.chk_visible_CheckedChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Enabled = false;
            this.txt_contraseña.Location = new System.Drawing.Point(189, 91);
            this.txt_contraseña.MaxLength = 100;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(284, 20);
            this.txt_contraseña.TabIndex = 5;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // chk_password
            // 
            this.chk_password.AutoSize = true;
            this.chk_password.Location = new System.Drawing.Point(102, 91);
            this.chk_password.Name = "chk_password";
            this.chk_password.Size = new System.Drawing.Size(80, 17);
            this.chk_password.TabIndex = 4;
            this.chk_password.Text = "Contraseña";
            this.chk_password.UseVisualStyleBackColor = true;
            this.chk_password.CheckedChanged += new System.EventHandler(this.chk_contraseña_CheckedChanged);
            // 
            // chk_sobreescribir
            // 
            this.chk_sobreescribir.AutoSize = true;
            this.chk_sobreescribir.Location = new System.Drawing.Point(102, 68);
            this.chk_sobreescribir.Name = "chk_sobreescribir";
            this.chk_sobreescribir.Size = new System.Drawing.Size(133, 17);
            this.chk_sobreescribir.TabIndex = 3;
            this.chk_sobreescribir.Text = "Sobre escribir respaldo";
            this.chk_sobreescribir.UseVisualStyleBackColor = true;
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(102, 28);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.ReadOnly = true;
            this.txt_ruta.Size = new System.Drawing.Size(371, 20);
            this.txt_ruta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guardar en:";
            // 
            // btn_ruta
            // 
            this.btn_ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ruta.Image = ((System.Drawing.Image)(resources.GetObject("btn_ruta.Image")));
            this.btn_ruta.Location = new System.Drawing.Point(479, 26);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(35, 23);
            this.btn_ruta.TabIndex = 2;
            this.btn_ruta.UseVisualStyleBackColor = true;
            this.btn_ruta.Click += new System.EventHandler(this.btn_ruta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nu1.png");
            this.imageList1.Images.SetKeyName(1, "nu2.png");
            this.imageList1.Images.SetKeyName(2, "numero.png");
            this.imageList1.Images.SetKeyName(3, "numero (1).png");
            this.imageList1.Images.SetKeyName(4, "numero (2).png");
            this.imageList1.Images.SetKeyName(5, "numero (5).png");
            this.imageList1.Images.SetKeyName(6, "1489533756_eye.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 38);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 35);
            this.tsbGuardar.Text = "&Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 35);
            this.tsbCancelar.Text = "&Cancelar";
            this.tsbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 313);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Tarea";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archivos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombretarea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_archivos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.CheckBox chk_password;
        private System.Windows.Forms.CheckBox chk_sobreescribir;
        private System.Windows.Forms.Button btn_ruta;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.CheckBox chk_seleccionartodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos_Archivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbQuitar;
        private System.Windows.Forms.TextBox txt_confirmarcontraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}