using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaAdministrarRespaldos
{
    public partial class Form3 : Form
    {
        private SQLiteConnection con;

        public Form3(SQLiteConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private SQLiteDataAdapter adapter;
        private SQLiteCommandBuilder builder;
        private DataTable tabla;

        private void Form3_Load(object sender, EventArgs e)
        {
           
            tabla = new DataTable();
            adapter = new SQLiteDataAdapter("SELECT ID_Tarea,Nombre_Tarea,Fecha FROM Tabla_Tarea", con);
            adapter.Fill(tabla);
            builder = new SQLiteCommandBuilder(adapter);

            bindingSource1.DataSource = tabla;
            
            dataGridView1.DataSource = bindingSource1;

            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nombre_Tarea"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable rowsEdited = tabla.GetChanges(DataRowState.Modified);
            if (tabla.GetChanges() != null)
            {
            adapter.Update(tabla);
            MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("no hay cambios");
            }
        }
    }
}
