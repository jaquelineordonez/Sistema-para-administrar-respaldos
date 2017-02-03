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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_ejecutar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_baja);
            this.panel1.Controls.Add(this.btn_alta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 232);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(363, 165);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.Location = new System.Drawing.Point(248, 4);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(75, 30);
            this.btn_ejecutar.TabIndex = 3;
            this.btn_ejecutar.Text = "Ejecutar";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(166, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 30);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(84, 3);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 30);
            this.btn_baja.TabIndex = 1;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_alta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_alta.Location = new System.Drawing.Point(3, 3);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 30);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = false;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Respaldos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

