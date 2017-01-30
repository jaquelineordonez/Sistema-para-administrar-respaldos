using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace SistemaParaAdministrarRespaldos
{
    public partial class Form1 : Form
    {
        private SQLiteConnection conexion;
        //// private int contador;
  
        public Form1()
        {
            // contador = 0;
            InitializeComponent();

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conexion);
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
                MessageBox.Show("Tarea Agregada");

            }
            else
            {

            }
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarea modificada");
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarea ejecutada");
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("select * from  Tabla_Tarea", conexion);
            DataTable tabla = new DataTable("tareas");
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new SQLiteConnection("Data source = D:\\Sistema para manejar respaldos\\Sistema-para-administrar-respaldos\\mydatabase.sqlite;Version=3");
                CargarDatos();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
