using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace SistemaParaAdministrarRespaldos
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
  
        public Form1()
        {
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
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conexion, Convert.ToInt32(dataGridView1["ID_Tarea", dataGridView1.CurrentRow.Index].Value), dataGridView1["Nombre_Tarea", dataGridView1.CurrentRow.Index].Value, System.Convert.ToDateTime(dataGridView1["Fecha", dataGridView1.CurrentRow.Index].Value));
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
                MessageBox.Show("Tarea Modificada");
            }
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarea ejecutada");
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter adaptador;
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            SQLiteConnection conexion = new SQLiteConnection("Data source = D:\\Sistema para manejar respaldos\\Sistema-para-administrar-respaldos\\mydatabase.sqlite;Version=3;New=False;Compress=true;");
            conexion.Open();
            string comando = "SELECT * FROM Tabla_Tarea";
            adaptador = new SQLiteDataAdapter(comando, conexion);
            ds.Reset();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adaptador);
            cb.QuotePrefix = "[";
            cb.QuoteSuffix = "]";
            adaptador.InsertCommand = cb.GetDeleteCommand();
            int fila = dataGridView1.CurrentCell.RowIndex;
            if (fila > tabla.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione un registro");
            }
            if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabla.Rows[fila].Delete();
                adaptador.Update(tabla);
                tabla.AcceptChanges();
                dataGridView1.DataSource = tabla;
                conexion.Close();
            }
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
