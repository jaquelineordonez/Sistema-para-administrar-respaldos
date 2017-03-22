using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Windows.Forms;
using SimpleCrypto;

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
            InitializeComponent();

            this.conexion = conexion;
            this.insertar = true;
        }

        public Form2(SQLiteConnection conexion, int id_tarea, object nombretarea, DateTime fecha)
        {
            InitializeComponent();

            this.conexion = conexion;
            this.idtarea = id_tarea;
            this.modificar = true;
            this.nombreTarea = nombretarea;
            this.fecha = fecha;
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
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (idtarea > 0)
            {
                cargardatos();
                cargarrutas();
            }
        }

        private DataTable tablaArchivos = new DataTable();
        private SQLiteDataAdapter adapter;
        private SQLiteCommandBuilder builder;
        private DataTable tb = new DataTable();
        private SQLiteDataAdapter adptb;

        private void cargardatos()
        {
            tablaArchivos = new DataTable();
            adapter = new SQLiteDataAdapter("SELECT * FROM Tabla_Archivo where ID_Tarea=" + idtarea, conexion);
            adapter.Fill(tablaArchivos);
            builder = new SQLiteCommandBuilder(adapter);
            tablaArchivos.Columns.Add("Seleccionar", typeof(bool));
            dataGridView2.DataSource = tablaArchivos;
        }

        private void cargarrutas()
        {
            if (idtarea > 0)
            {
                string cons = ("SELECT * FROM Tabla_Ruta where ID_Tarea=" + idtarea);
                SQLiteCommand cmd = new SQLiteCommand(cons, conexion);
                adptb = new SQLiteDataAdapter(cons, conexion);
                adptb.Fill(tb);

                string rutasal = tb.Rows[0]["Ruta_Salida"].ToString();
                txt_ruta.Text = rutasal;

                

                SQLiteCommand comando = new SQLiteCommand("SELECT Contraseña FROM Tabla_Ruta WHERE ID_Tarea=" + idtarea, conexion);
                string contraseñadesencriptada = StringCipher.Decrypt(comando.ExecuteScalar().ToString());
                txt_contraseña.Text = contraseñadesencriptada;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                if (string.IsNullOrEmpty(txt_nombretarea.Text) || (dataGridView2.Rows.Count == 0) || string.IsNullOrEmpty(txt_ruta.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
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

                        string comando3 = ("insert into Tabla_Ruta (Ruta_Salida,sobreescribir,password,Contraseña,ID_Tarea) values(@Ruta_Salida,@sobreescribir,@password,@contraseña,@idtarea)");
                        SQLiteCommand insercion3 = new SQLiteCommand(comando3, conexion, transaccion);
                        insercion3.Parameters.AddWithValue("@Ruta_Salida", txt_ruta.Text);
                        insercion3.Parameters.AddWithValue("@sobreescribir", chk_sobreescribir.Checked);
                        insercion3.Parameters.AddWithValue("@password", chk_password.Checked);
                        insercion3.Parameters.AddWithValue("@Contraseña", StringCipher.Encrypt(txt_contraseña.Text));
                        insercion3.Parameters.AddWithValue("@idtarea", idtarea);
                        insercion3.ExecuteNonQuery();

                        object archivoruta = 0;
                        for (int x = 0; x < dataGridView2.Rows.Count; x++)
                        {
                            archivoruta = dataGridView2["Datos_Archivo", x].Value;
                            insercion2.Parameters.AddWithValue("@Datos_Archivo", archivoruta);
                            insercion2.Parameters.AddWithValue("@idtarea", idtarea);
                            insercion2.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        this.DialogResult = DialogResult.OK; // registra el resultado del boton OK para que realize lo del form1 if

                    }
                    catch
                    {
                        MessageBox.Show("ERROR EN TRANSACCION");
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
                    adptb.Update(tb);
                    tablaArchivos.AcceptChanges();
                    tb.AcceptChanges();
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

        private void chk_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_password.Checked == true)
            {
                txt_contraseña.Enabled = true;
            }
            else
            {
                txt_contraseña.Enabled = false;
            }
        }

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = fbd1.SelectedPath;
            }
        }

        private void chk_visible_CheckedChanged(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = chk_visible.Checked ? false : true;
        }


        private void btn_validar_Click(object sender, EventArgs e)
        {
            if (idtarea > 0)
            {
                SQLiteCommand comando = new SQLiteCommand("SELECT Contraseña FROM Tabla_Ruta WHERE ID_Tarea=" + idtarea, conexion);
                string contraseñadesencriptada = StringCipher.Decrypt(comando.ExecuteScalar().ToString());

                if (txt_contraseña.Text == contraseñadesencriptada)
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                }
            }
        }

        private void btn_visible_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }


        private void btn_visible_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
