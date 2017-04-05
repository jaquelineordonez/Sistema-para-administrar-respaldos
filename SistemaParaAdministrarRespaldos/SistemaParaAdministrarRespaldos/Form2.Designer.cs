namespace SistemaParaAdministrarRespaldos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombretarea = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datos_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_seleccionartodo = new System.Windows.Forms.CheckBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.btn_visible = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.chk_password = new System.Windows.Forms.CheckBox();
            this.chk_sobreescribir = new System.Windows.Forms.CheckBox();
            this.btn_ruta = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la tarea";
            // 
            // txt_nombretarea
            // 
            this.txt_nombretarea.Location = new System.Drawing.Point(16, 36);
            this.txt_nombretarea.Name = "txt_nombretarea";
            this.txt_nombretarea.Size = new System.Drawing.Size(328, 20);
            this.txt_nombretarea.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.ID_Archivo,
            this.ID_Tarea,
            this.Datos_Archivo});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Location = new System.Drawing.Point(6, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(519, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.FillWeight = 111.6751F;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 69;
            this.Seleccionar.Name = "Seleccionar";
            // 
            // ID_Archivo
            // 
            this.ID_Archivo.DataPropertyName = "ID_Archivo";
            this.ID_Archivo.HeaderText = "ID_Archivo";
            this.ID_Archivo.Name = "ID_Archivo";
            this.ID_Archivo.Visible = false;
            // 
            // ID_Tarea
            // 
            this.ID_Tarea.DataPropertyName = "ID_Tarea";
            this.ID_Tarea.HeaderText = "ID_Tarea";
            this.ID_Tarea.Name = "ID_Tarea";
            this.ID_Tarea.Visible = false;
            // 
            // Datos_Archivo
            // 
            this.Datos_Archivo.DataPropertyName = "Datos_Archivo";
            this.Datos_Archivo.FillWeight = 88.32487F;
            this.Datos_Archivo.HeaderText = "Archivo";
            this.Datos_Archivo.Name = "Datos_Archivo";
            this.Datos_Archivo.ReadOnly = true;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 244);
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
            this.tabPage1.Size = new System.Drawing.Size(531, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuracion Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chk_seleccionartodo);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_quitar);
            this.tabPage2.Controls.Add(this.btn_agregar);
            this.tabPage2.ImageIndex = 3;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archivos a guardar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_seleccionartodo
            // 
            this.chk_seleccionartodo.AutoSize = true;
            this.chk_seleccionartodo.Location = new System.Drawing.Point(75, 19);
            this.chk_seleccionartodo.Name = "chk_seleccionartodo";
            this.chk_seleccionartodo.Size = new System.Drawing.Size(15, 14);
            this.chk_seleccionartodo.TabIndex = 8;
            this.chk_seleccionartodo.UseVisualStyleBackColor = true;
            this.chk_seleccionartodo.CheckedChanged += new System.EventHandler(this.chk_seleccionartodo_CheckedChanged);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_quitar.Location = new System.Drawing.Point(109, 168);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(55, 40);
            this.btn_quitar.TabIndex = 7;
            this.btn_quitar.Text = "&Quitar";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_agregar.Location = new System.Drawing.Point(37, 168);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(55, 40);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "&Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_visible);
            this.tabPage3.Controls.Add(this.btn_visible);
            this.tabPage3.Controls.Add(this.txt_contraseña);
            this.tabPage3.Controls.Add(this.chk_password);
            this.tabPage3.Controls.Add(this.chk_sobreescribir);
            this.tabPage3.Controls.Add(this.btn_ruta);
            this.tabPage3.Controls.Add(this.txt_ruta);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.ImageIndex = 5;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(531, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ruta de salida";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Image = global::SistemaParaAdministrarRespaldos.Properties.Resources._1489533888_eye;
            this.chk_visible.Location = new System.Drawing.Point(458, 86);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(47, 32);
            this.chk_visible.TabIndex = 7;
            this.chk_visible.UseVisualStyleBackColor = true;
            this.chk_visible.CheckedChanged += new System.EventHandler(this.chk_visible_CheckedChanged);
            // 
            // btn_visible
            // 
            this.btn_visible.Image = global::SistemaParaAdministrarRespaldos.Properties.Resources._1489533888_eye;
            this.btn_visible.Location = new System.Drawing.Point(41, 86);
            this.btn_visible.Name = "btn_visible";
            this.btn_visible.Size = new System.Drawing.Size(35, 25);
            this.btn_visible.TabIndex = 6;
            this.btn_visible.UseVisualStyleBackColor = true;
            this.btn_visible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_visible_MouseDown);
            this.btn_visible.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_visible_MouseUp);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Enabled = false;
            this.txt_contraseña.Location = new System.Drawing.Point(168, 91);
            this.txt_contraseña.MaxLength = 100;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(284, 20);
            this.txt_contraseña.TabIndex = 5;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // chk_password
            // 
            this.chk_password.AutoSize = true;
            this.chk_password.Location = new System.Drawing.Point(81, 91);
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
            this.chk_sobreescribir.Location = new System.Drawing.Point(81, 68);
            this.chk_sobreescribir.Name = "chk_sobreescribir";
            this.chk_sobreescribir.Size = new System.Drawing.Size(133, 17);
            this.chk_sobreescribir.TabIndex = 3;
            this.chk_sobreescribir.Text = "Sobre escribir respaldo";
            this.chk_sobreescribir.UseVisualStyleBackColor = true;
            // 
            // btn_ruta
            // 
            this.btn_ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ruta.Location = new System.Drawing.Point(458, 26);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(35, 23);
            this.btn_ruta.TabIndex = 2;
            this.btn_ruta.Text = "...";
            this.btn_ruta.UseVisualStyleBackColor = true;
            this.btn_ruta.Click += new System.EventHandler(this.btn_ruta_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(81, 28);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(371, 20);
            this.txt_ruta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guardar en:";
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
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelar.Location = new System.Drawing.Point(461, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 40);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(359, 262);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 40);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 311);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Tarea";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombretarea;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.CheckBox chk_password;
        private System.Windows.Forms.CheckBox chk_sobreescribir;
        private System.Windows.Forms.Button btn_ruta;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button btn_visible;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.CheckBox chk_seleccionartodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos_Archivo;
    }
}