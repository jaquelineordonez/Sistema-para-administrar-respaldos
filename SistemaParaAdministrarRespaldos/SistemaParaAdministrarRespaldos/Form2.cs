using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaParaAdministrarRespaldos
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
        private bool insertar = false;
        private bool modificar = false;
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

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            dataGridView2.AutoGenerateColumns = false;
            //////dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (idtarea > 0)
            {
                cargardatos();
            }
        }

        private DataTable tablaArchivos = new DataTable();
        private SQLiteDataAdapter adapter;
        private SQLiteCommandBuilder builder;

        private void cargardatos()
        {
            tablaArchivos = new DataTable();
            adapter = new SQLiteDataAdapter("SELECT * FROM Tabla_Archivo where ID_Tarea="+idtarea, conexion);
            adapter.Fill(tablaArchivos);
            builder = new SQLiteCommandBuilder(adapter);
            tablaArchivos.Columns.Add("Seleccionar", typeof(bool));
            dataGridView2.DataSource = tablaArchivos;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                if (string.IsNullOrEmpty(txt_nombretarea.Text) || (dataGridView2.Rows.Count == 0))
                {
                    MessageBox.Show("Debe completar la informacion");
                }
                else
                {

                    this.DialogResult = DialogResult.OK; // registra el resultado del boton OK para que realize lo del form1 if

                    SQLiteTransaction transaccion = conexion.BeginTransaction(); 

                    try
                    {
                        string comando = "insert into Tabla_Tarea (Nombre_Tarea,Fecha)values(@Nombre_Tarea,@Fecha)";
                        SQLiteCommand insercion = new SQLiteCommand(comando, conexion, transaccion);
                        insercion.Parameters.AddWithValue("@Nombre_Tarea", txt_nombretarea.Text);
                        insercion.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                        insercion.ExecuteNonQuery();

                        SQLiteCommand comandoid = new SQLiteCommand("select last_insert_rowid()", conexion, transaccion);
                        int idtarea = System.Convert.ToInt16(comandoid.ExecuteScalar());

                        string comando2 = "insert into Tabla_Archivo (Datos_Archivo,ID_Tarea) values(@Datos_Archivo,@idtarea)";
                        SQLiteCommand insercion2 = new SQLiteCommand(comando2, conexion, transaccion);
                        object archivoruta = 0;
                        for (int x = 0; x < dataGridView2.Rows.Count; x++)
                        {
                            archivoruta = dataGridView2["Datos_Archivo", x].Value;
                            insercion2.Parameters.AddWithValue("@Datos_Archivo", archivoruta);
                            insercion2.Parameters.AddWithValue("@idtarea", idtarea);
                            insercion2.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                    }
                }
            }
            else
            {
                if (modificar)
                {
                    dataGridView2.EndEdit();
                    adapter.Update(tablaArchivos);
                    tablaArchivos.AcceptChanges();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = tablaArchivos;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Todos los archivos| *.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string dir = openFileDialog1.FileName;
                string[] ofdSelectedFiles = openFileDialog1.FileNames;
                foreach (string nombres in ofdSelectedFiles)
                {
                    if (idtarea > 0)
                    {
                        tablaArchivos.Rows.Add(new object[]
                        {
                            null, nombres, idtarea, false
                        });

                    }
                    else
                    {
                        dataGridView2.Rows.Add(new object[] { false, null, null, nombres });
                    }
                   
                }
            }
            
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            tablaArchivos.AcceptChanges();
            if (idtarea > 0)
            {
                DataRow[] rowsSeleccionados = tablaArchivos.Select("Seleccionar = " + true);
                if (rowsSeleccionados != null && rowsSeleccionados.Length >= 1)
                {

                    if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int x = 0; x < rowsSeleccionados.Length; x++)
                        {
                            rowsSeleccionados[x].Delete();
                        }

                        adapter.Update(tablaArchivos);
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = tablaArchivos;
                    }
 
                }
                else
                {
                    MessageBox.Show("Seleccione al menos un archivo.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                object seleccionado = false;
                for (int x = 0; x < dataGridView2.Rows.Count; x++)
                {
                    seleccionado = dataGridView2["Seleccionar", x].Value;
                    if (seleccionado != DBNull.Value)
                    {
                        if (Convert.ToBoolean(seleccionado))
                        {
                            dataGridView2.Rows.RemoveAt(x);
                            x--;
                        }
                    }
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView2.Columns[0].Index)
            {
                DataGridViewCheckBoxCell chkCelda = (DataGridViewCheckBoxCell)this.dataGridView2.Rows[e.RowIndex].Cells[0];

            }
        }
    }
}
