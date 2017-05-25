using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using SistemaParaAdministrarRespaldos.Properties;

namespace SistemaParaAdministrarRespaldos
{
    public partial class FormSecundario : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
        private bool insertar = false;
        private bool modificar = false;
        private object nombreTarea;
        private DateTime fecha;
        private int idtarea;

        public FormSecundario(SQLiteConnection conexion)
        {
            InitializeComponent();

            this.conexion = conexion;
            this.insertar = true;
        }

        public FormSecundario(SQLiteConnection conexion, int id_tarea, object nombretarea, DateTime fecha)
        {
            InitializeComponent();

            this.conexion = conexion;
            this.idtarea = id_tarea;
            this.modificar = true;
            this.nombreTarea = nombretarea;
            this.fecha = fecha;
            this.txt_nombretarea.Text = Convert.ToString(nombretarea);
            this.dateTimePicker1.Value = fecha;
            this.tsbGuardar.Text = "Actualizar";
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if (insertar)
            {
                this.Text = "Nueva Tarea";
            }
            if (modificar)
            {
                this.Text = string.Empty +nombreTarea;
            }

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            chk_visible.Enabled = false;

            dgv_archivos.AutoGenerateColumns = false;
            dgv_archivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_archivos.Columns[0].Width = 50;
            dgv_archivos.Columns[2].Frozen = true;
          
                cargardatos();
                cargarrutas();         
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
            dgv_archivos.DataSource = tablaArchivos;
        }

        private void cargarrutas()
        {
            if (idtarea > 0)
            {
                string cons = ("SELECT * FROM Tabla_Ruta where ID_Tarea=" + idtarea);
                SQLiteCommand cmd = new SQLiteCommand(cons, conexion);
                adptb = new SQLiteDataAdapter(cons, conexion);
                adptb.Fill(tb);

                txt_ruta.Text= Convert.ToString(tb.Rows[0][1]);
                chk_sobreescribir.Checked = Convert.ToBoolean(tb.Rows[0][2]);
                chk_password.Checked = Convert.ToBoolean(tb.Rows[0][3]);

                SQLiteCommand comando = new SQLiteCommand("SELECT Contraseña FROM Tabla_Ruta WHERE ID_Tarea=" + idtarea, conexion);
                string contras = comando.ExecuteScalar().ToString();

                if (contras != null && contras !=string.Empty)
                {
                    string contraseñadesencriptada = StringCipher.Decrypt(comando.ExecuteScalar().ToString());
                    txt_contraseña.Text = contraseñadesencriptada;
                }
            }
        }

        private bool agregar(string[] archivos)
        {
            bool validacion = true;
          
                for (int x = 0; x < archivos.Length; x++)
                {
                    DataRow[] repetido = tablaArchivos.Select("Datos_Archivo = '" + archivos[x] + "'");
                    if (repetido != null && repetido.Length > 0)
                    {
                        validacion = false;
                        MessageBox.Show("El archivo: " + archivos[x] + " ya existe en la lista.");
                    }
                    else
                    {
                        tablaArchivos.Rows.Add(new object[]
                        {
                                null, archivos[x], idtarea, false
                        });
                    }
                }
            return validacion;
        }

        private void chk_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (idtarea>0)
            {
                if (chk_password.Checked == true)
                {
                    txt_contraseña.Enabled = true;
                    txt_confirmarcontraseña.Enabled = true;
                    chk_visible.Enabled = true;
                }
                else
                {
                    txt_contraseña.Enabled = false;
                    txt_contraseña.Clear();
                    txt_confirmarcontraseña.Clear();
                    txt_confirmarcontraseña.Enabled = false;
                    chk_visible.Checked = false;
                    chk_visible.Enabled = false;
                    tsbGuardar.Enabled = true;
                }
            }
            else
            {
                if (chk_password.Checked == true)
                {
                    txt_contraseña.Enabled = true;
                    txt_confirmarcontraseña.Enabled = true;
                    chk_visible.Enabled = true;
                    tsbGuardar.Enabled = false;
                }
                else
                {
                    txt_contraseña.Enabled = false;
                    txt_contraseña.Clear();
                    txt_confirmarcontraseña.Clear();
                    txt_confirmarcontraseña.Enabled = false;
                    chk_visible.Checked = false;
                    chk_visible.Enabled = false;
                    tsbGuardar.Enabled = true;
                }
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
            if (chk_password.Checked == true)
            {
                txt_contraseña.UseSystemPasswordChar = chk_visible.Checked ? false : true;

                if (chk_visible.Checked == true)
                {
                    txt_confirmarcontraseña.Enabled = false;
                    txt_confirmarcontraseña.Clear();
                    tsbGuardar.Enabled = true;
                    errorProvider1.Clear();
                }
                else
                {
                    txt_confirmarcontraseña.Enabled = true;
                    tsbGuardar.Enabled = false;
                }
            }
        }
        
        private void chk_seleccionartodo_CheckedChanged(object sender, EventArgs e)
        {
            if (dgv_archivos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_archivos.Rows)
                {
                    row.Cells["Seleccionar"].Value = true;
                    if (chk_seleccionartodo.Checked == false)
                    {
                        row.Cells["Seleccionar"].Value = false;
                    }
                }
            }
            else
            {
                chk_seleccionartodo.Checked = false;
            }
        }

        private void tsbQuitar_Click(object sender, EventArgs e) 
        {
            dgv_archivos.EndEdit();
            tablaArchivos.AcceptChanges();
            if (idtarea > 0)
            {
                DataRow[] rowsSeleccionados = tablaArchivos.Select("Seleccionar = " + true);
                if (rowsSeleccionados != null && rowsSeleccionados.Length >= 1)
                {

                    if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int x = 0; x < rowsSeleccionados.Length; x++)
                        {

                            rowsSeleccionados[x].Delete();
                        }

                        adapter.Update(tablaArchivos);
                        dgv_archivos.DataSource = null;
                        dgv_archivos.DataSource = tablaArchivos;

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione al menos un archivo", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                object seleccionado = false;
                for (int x = 0; x < dgv_archivos.Rows.Count; x++)
                {
                    seleccionado = dgv_archivos["Seleccionar", x].Value;
                    if (seleccionado != DBNull.Value)
                    {
                        if (Convert.ToBoolean(seleccionado))
                        {
                            dgv_archivos.Rows.RemoveAt(x);
                            x--;
                        }
                    }
                }
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Todos los archivos| *.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string dir = openFileDialog1.FileName;
                string[] ofdSelectedFiles = openFileDialog1.FileNames;
                agregar(ofdSelectedFiles);
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                if (string.IsNullOrEmpty(txt_nombretarea.Text) || (dgv_archivos.Rows.Count == 0) || string.IsNullOrEmpty(txt_ruta.Text))
                {
                    if (string.IsNullOrEmpty(txt_nombretarea.Text))
                    {
                        MessageBox.Show("Nombre de la tarea vacio", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if ((dgv_archivos.Rows.Count == 0))
                    {
                        MessageBox.Show("La tarea no contiene archivos", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(txt_ruta.Text))
                    {
                        MessageBox.Show("No existe ruta de salida", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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

                        string comando3 = ("insert into Tabla_Ruta (Ruta_Salida,sobreescribir,password,Contraseña,ID_Tarea) values(@Ruta_Salida,@sobreescribir,@password,@contraseña,@idtarea)");
                        SQLiteCommand insercion3 = new SQLiteCommand(comando3, conexion, transaccion);
                        insercion3.Parameters.AddWithValue("@Ruta_Salida", txt_ruta.Text);
                        insercion3.Parameters.AddWithValue("@sobreescribir", chk_sobreescribir.Checked);
                        insercion3.Parameters.AddWithValue("@password", chk_password.Checked);
                        if (string.IsNullOrEmpty(txt_contraseña.Text))
                        {
                            insercion3.Parameters.AddWithValue("@Contraseña", null);
                        }
                        else
                        {
                            insercion3.Parameters.AddWithValue("@Contraseña", StringCipher.Encrypt(txt_contraseña.Text));

                        }
                        insercion3.Parameters.AddWithValue("@idtarea", idtarea);
                        insercion3.ExecuteNonQuery();

                        string comando2 = "insert into Tabla_Archivo (Datos_Archivo,ID_Tarea) values(@Datos_Archivo,@idtarea)";
                        SQLiteCommand insercion2 = new SQLiteCommand(comando2, conexion, transaccion);

                        object archivoruta = 0;
                        for (int x = 0; x < dgv_archivos.Rows.Count; x++)
                        {
                            archivoruta = dgv_archivos["Datos_Archivo", x].Value;
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
                    if (string.IsNullOrEmpty(txt_nombretarea.Text) || (dgv_archivos.Rows.Count == 0) || string.IsNullOrEmpty(txt_ruta.Text))
                    {
                        if (string.IsNullOrEmpty(txt_nombretarea.Text))
                        {
                            MessageBox.Show("Nombre de la tarea vacio", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if ((dgv_archivos.Rows.Count == 0))
                        {
                            MessageBox.Show("La tarea no contiene archivos", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (string.IsNullOrEmpty(txt_ruta.Text))
                        {
                            MessageBox.Show("No existe ruta de salida", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        SQLiteTransaction transaccion = conexion.BeginTransaction();
                        try
                        {
                            string modifi = "UPDATE Tabla_Tarea SET Nombre_Tarea=@Nombre_Tarea, Fecha=@Fecha WHERE (ID_Tarea = @ID_Tarea)";
                            SQLiteCommand actualizacion = new SQLiteCommand(modifi, conexion);
                            actualizacion.Parameters.AddWithValue("@Nombre_Tarea", txt_nombretarea.Text);
                            actualizacion.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                            actualizacion.Parameters.AddWithValue("@ID_Tarea", idtarea);

                            dgv_archivos.EndEdit();
                            adapter.Update(tablaArchivos);
                            tablaArchivos.AcceptChanges();
                            dgv_archivos.DataSource = null;
                            dgv_archivos.DataSource = tablaArchivos;

                            string modif = "UPDATE Tabla_Ruta SET Ruta_Salida=@Ruta_Salida, sobreescribir=@sobreescribir, password=@password, Contraseña=@Contraseña WHERE (ID_Tarea = @ID_Tarea)";
                            SQLiteCommand actualizacion2 = new SQLiteCommand(modif, conexion);
                            actualizacion2.Parameters.AddWithValue("@Ruta_Salida", txt_ruta.Text);
                            actualizacion2.Parameters.AddWithValue("@sobreescribir", chk_sobreescribir.Checked);
                            actualizacion2.Parameters.AddWithValue("@password", chk_password.Checked);
                            if (string.IsNullOrEmpty(txt_contraseña.Text))
                            {
                                actualizacion2.Parameters.AddWithValue("@Contraseña", null);
                            }
                            else
                            {
                                actualizacion2.Parameters.AddWithValue("@Contraseña", StringCipher.Encrypt(txt_contraseña.Text));

                            }
                            actualizacion2.Parameters.AddWithValue("@ID_Tarea", idtarea);

                            if (actualizacion2.ExecuteNonQuery() > 0 && actualizacion.ExecuteNonQuery() > 0)
                            {
                                modificar = true;
                            }
                         
                            transaccion.Commit();                          
                            this.DialogResult = DialogResult.OK;

                        }
                        catch
                        {
                            MessageBox.Show("ERROR EN TRANSACCION");
                            transaccion.Rollback();
                        }
                    }
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_confirmarcontraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_contraseña.Text != txt_confirmarcontraseña.Text)
            {
                errorProvider1.SetError(txt_confirmarcontraseña, "Las contraseñas no coinciden");
                tsbGuardar.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                tsbGuardar.Enabled = true;
            }
        }

        public void sololetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)) || (char.IsSeparator(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_nombretarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }
    }
}
