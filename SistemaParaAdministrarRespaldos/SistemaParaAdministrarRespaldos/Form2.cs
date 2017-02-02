using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaParaAdministrarRespaldos
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
        private bool insertar=false;
        private bool modificar=false;
        private object nombreTarea;
        private DateTime fecha;
        private int idtarea;
        

        public Form2(SQLiteConnection conexion)
        {
            this.conexion = conexion;
            this.insertar = true;
            InitializeComponent();
        }

        public Form2(SQLiteConnection conexion, int id_tarea, object nombretarea, DateTime fecha)
        {
            this.conexion = conexion;
            this.idtarea = id_tarea;
            this.modificar = true;
            this.nombreTarea = nombretarea;
            this.fecha = fecha;
            InitializeComponent();
            this.txt_nombretarea.Text = Convert.ToString(nombretarea);
            this.dateTimePicker1.Value = fecha;
            this.btn_guardar.Text = "Actualizar";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            try
            {
                DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
                c1.Name = "Nombre";
                DataGridViewButtonColumn c2 = new DataGridViewButtonColumn();
                c2.Name = "Ruta";
                this.dataGridView2.Columns.AddRange(c1, c2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                if (string.IsNullOrEmpty(txt_nombretarea.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                }
                else
                {
                    this.DialogResult = DialogResult.OK; // registra el resultado del boton OK para que realize lo del form1 if
                    conexion.Open();
                    string comando = "insert into Tabla_Tarea (Nombre_Tarea,Fecha)values(@Nombre_Tarea,@Fecha)";
                    SQLiteCommand insercion = new SQLiteCommand(comando, conexion);
                    insercion.Parameters.AddWithValue("@Nombre_Tarea", txt_nombretarea.Text);
                    insercion.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    insercion.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            else
            {
                if (modificar)
                {
                    this.DialogResult = DialogResult.OK; // registra el resultado del boton OK para que realize lo del form1 if
                  
                    conexion.Open();
                    string comando = "UPDATE Tabla_Tarea SET Nombre_Tarea = @Nombre_Tarea, Fecha = @Fecha WHERE (ID_Tarea = @ID_Tarea)";
                    SQLiteCommand actualizacion = new SQLiteCommand(comando, conexion);
                    actualizacion.Parameters.AddWithValue("@Nombre_Tarea", txt_nombretarea.Text);
                    actualizacion.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    actualizacion.Parameters.AddWithValue("@ID_Tarea", idtarea);
                    if (actualizacion.ExecuteNonQuery() > 0)
                    {
                        modificar = true;
                        txt_nombretarea.Text = "Nombre_Tarea";
                        txt_nombretarea.ReadOnly = false;

                    }
                    conexion.Close();
                    

                }
            }
           
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.docx"; ///.cur
            openFileDialog1.Title = "Seleccione un archivo";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                /////this.Cursor = new Cursor(openFileDialog1.OpenFile());
                string[] ofdSelectedFiles = openFileDialog1.SafeFileNames;
                foreach (string fontFileNames in ofdSelectedFiles)
                {
                    dataGridView2.Rows.Add(fontFileNames);
                }
            }
        }
    }
}
