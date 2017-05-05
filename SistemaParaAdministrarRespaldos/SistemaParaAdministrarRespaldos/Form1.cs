using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;
using Microsoft.VisualBasic.Devices;
using SistemaParaAdministrarRespaldos.Properties;


namespace SistemaParaAdministrarRespaldos
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
        private int idtareamostrarLog;

        public Form1()
        {
            InitializeComponent();
        }

        private DataTable tabla = new DataTable();
        private SQLiteDataAdapter adaptador;
        private SQLiteCommandBuilder builder;

        private DataTable tbl = new DataTable();
        private SQLiteDataAdapter adp;
        private SQLiteCommandBuilder build;

        private DataTable dta = new DataTable();

       private void cargarlista(int id_tarea)
        {
            list_ejecuciones.Items.Clear();
            if (tbl!= null)
            {
                DataRow[] filas = tbl.Select("ID_Tarea = " + id_tarea);
                foreach (DataRow dr in filas)
                {
                    ListViewItem item = new ListViewItem(dr["FechaHoraZip"].ToString());
                    item.SubItems.Add(dr["Ruta_SalidaZip"].ToString());
                    list_ejecuciones.Items.Add(item);
                }
            }
        }

        private void CargarDatos()
        {
            tabla = new DataTable();
            adaptador = new SQLiteDataAdapter("SELECT * FROM Tabla_Tarea", conexion);
            adaptador.Fill(tabla);
            builder = new SQLiteCommandBuilder(adaptador);
            tabla.Columns.Add("Seleccionar", typeof(bool));
            dgv_tareas.DataSource = tabla;
        }

        private void cargarejecucion()
        {
            tbl = new DataTable();
            adp = new SQLiteDataAdapter("SELECT * FROM Tabla_Ejecucion", conexion);
            adp.Fill(tbl);
            build = new SQLiteCommandBuilder(adp);
            dgv_ejecucion.DataSource = tbl;
            if (dgv_ejecucion.Rows.Count >= 0)
            {
                dgv_ejecucion.Sort(FechaHoraZip, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private static string cadenadeconexion()
        {
            return Settings.Default.mydatabaseConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_tareas.AutoGenerateColumns = false;
            dgv_tareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_tareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tareas.Columns[1].Width = 50;
            dgv_tareas.Columns[1].Frozen = true;

            dgv_ejecucion.AutoGenerateColumns = false;
            dgv_ejecucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                conexion = new SQLiteConnection(cadenadeconexion());
                conexion.Open();
                CargarDatos();
                cargarejecucion();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void tsb_nueva_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conexion);
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
                MessageBox.Show("Tarea Agregada");
            }
        }

        private void tsb_editar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conexion, Convert.ToInt32(dgv_tareas["ID_Tarea", dgv_tareas.CurrentRow.Index].Value), dgv_tareas["Nombre_Tarea", dgv_tareas.CurrentRow.Index].Value, System.Convert.ToDateTime(dgv_tareas["Fecha", dgv_tareas.CurrentRow.Index].Value));
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
                MessageBox.Show("Tarea Modificada");
            }
        }

        private void tsb_eliminar_Click(object sender, EventArgs e)
        {
            SQLiteTransaction transaccion = conexion.BeginTransaction();
            object id_Tarea = 0;
            SQLiteCommand comando;
            try
            {
                dgv_tareas.EndEdit(); ///se abria beginEdit() pero no se cerraba, por eso no funcionaba el check  hasta que el foco dejaba de estar en el renglon
                tabla.AcceptChanges();

                DataRow[] rowsSeleccionados = tabla.Select("Seleccionar = " + true);
                if (rowsSeleccionados != null && rowsSeleccionados.Length >= 1)
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int x = 0; x < rowsSeleccionados.Length; x++)
                        {
                            id_Tarea = rowsSeleccionados[x][0];
                            string a = "DELETE FROM Tabla_Archivo WHERE (ID_Tarea = " + id_Tarea + ")";
                            comando = new SQLiteCommand("DELETE FROM Tabla_Archivo WHERE (ID_Tarea = " + id_Tarea + ")", conexion, transaccion);
                            comando.ExecuteNonQuery();
                            comando = new SQLiteCommand("DELETE FROM Tabla_Tarea WHERE (ID_Tarea = " + id_Tarea + ")", conexion, transaccion);
                            comando.ExecuteNonQuery();
                            comando = new SQLiteCommand("DELETE FROM Tabla_Ruta WHERE (ID_Tarea = " + id_Tarea + ")", conexion, transaccion);
                            comando.ExecuteNonQuery();
                            comando = new SQLiteCommand("DELETE FROM Tabla_Ejecucion WHERE (ID_Tarea = " + id_Tarea + ")", conexion, transaccion);
                            comando.ExecuteNonQuery();
                            rowsSeleccionados[x].Delete();
                        }

                        dgv_tareas.DataSource = null;
                        dgv_tareas.DataSource = tabla;
                        dgv_ejecucion.DataSource = null;
                        dgv_ejecucion.DataSource = tbl;
                        CargarDatos();
                        cargarejecucion();

                        transaccion.Commit();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una tarea", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    object seleccionado = null;
                    for (int x = 0; x < dgv_tareas.Rows.Count; x++)
                    {
                        seleccionado = dgv_tareas["Seleccionar", x].Value;
                        if (seleccionado != DBNull.Value)
                        {
                            if (Convert.ToBoolean(seleccionado))
                            {
                                dgv_tareas.Rows.RemoveAt(x);
                                x--;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR EN TRANSACCION");
                transaccion.Rollback();
            }
        }

        private void tsb_ejecutar_Click(object sender, EventArgs e)
        {
            SQLiteTransaction transaccion = conexion.BeginTransaction();
            object id_Tarea = 0;
            try
            {
                dgv_tareas.EndEdit();
                tabla.AcceptChanges();

                DataRow[] rowsSeleccionados = tabla.Select("Seleccionar = " + true);
                if (rowsSeleccionados != null && rowsSeleccionados.Length >= 1)
                {
                    for (int x = 0; x < rowsSeleccionados.Length; x++)
                    {
                        id_Tarea = rowsSeleccionados[x][0];
                        SQLiteCommand chk = new SQLiteCommand("SELECT sobreescribir FROM Tabla_Ruta WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        string chksobreescribir = chk.ExecuteScalar().ToString();

                        SQLiteCommand nom = new SQLiteCommand("SELECT Nombre_Tarea FROM Tabla_Tarea WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        string nombrezip = nom.ExecuteScalar().ToString();

                        SQLiteCommand comandosalida = new SQLiteCommand("SELECT Ruta_Salida FROM Tabla_Ruta WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        string rutasalida = comandosalida.ExecuteScalar().ToString();

                        string contraseña;
                        SQLiteCommand contra = new SQLiteCommand("SELECT Contraseña FROM Tabla_Ruta WHERE ID_Tarea=" + id_Tarea, conexion);
                        string contras = contra.ExecuteScalar().ToString();

                        if (contras == null | contras== string.Empty)
                        {
                            contraseña = null;
                        }
                        else
                        {
                            contraseña = StringCipher.Decrypt(contras);
                        }

                        SQLiteCommand comandoinicio = new SQLiteCommand("SELECT Datos_Archivo FROM Tabla_Archivo WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        SQLiteDataReader rutainicio = comandoinicio.ExecuteReader();

                        string tiempo = DateTime.Now.ToString(" dd-MM-yyyy HH_mm_ss");
                        string nombreFinalZip = nombrezip + tiempo;

                        string rutaarchivo = string.Empty;
                        using (ZipFile zip = new ZipFile())
                        {
                            while (rutainicio.Read())
                            {
                                rutaarchivo = Convert.ToString(rutainicio.GetValue(0));
                                if (File.Exists(rutaarchivo))
                                {

                                    if (contraseña != null)
                                    {
                                        zip.Password = contraseña;
                                    }
                                    zip.AddFile(rutaarchivo, string.Empty);
                                }
                            }

                            if (chksobreescribir == Convert.ToString(1))
                            {
                                zip.Save(rutasalida + Path.DirectorySeparatorChar + nombrezip + ".zip");
                            }
                            else
                            {          
                                zip.Save(rutasalida + Path.DirectorySeparatorChar + nombreFinalZip + ".zip");
                            }
                        }
                        
                        string comando = "insert into Tabla_Ejecucion (Nombre_TareaZip,FechaHoraZip,Ruta_SalidaZip,ID_Tarea)values(@Nombre_TareaZip,@FechaHoraZip,@Ruta_SalidaZip,@ID_Tarea)";
                        SQLiteCommand insercion = new SQLiteCommand(comando, conexion, transaccion);
                        
                        insercion.Parameters.AddWithValue("@Nombre_TareaZip", nombrezip);
                        insercion.Parameters.AddWithValue("@FechaHoraZip", DateTime.Now);
                        if (chksobreescribir == Convert.ToString(1))
                        {
                            insercion.Parameters.AddWithValue("@Ruta_SalidaZip", rutasalida + Path.DirectorySeparatorChar + nombrezip + ".zip");
                        }
                        else
                        {
                            insercion.Parameters.AddWithValue("@Ruta_SalidaZip", rutasalida + Path.DirectorySeparatorChar + nombreFinalZip + ".zip");
                        }
                        insercion.Parameters.AddWithValue("@ID_Tarea", id_Tarea);
                        insercion.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    CargarDatos();
                    cargarejecucion();
                    MessageBox.Show("Tarea ejecutada");
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una tarea", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ERROR EN TRANSACCION");
                transaccion.Rollback();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2(conexion, Convert.ToInt32(dgv_tareas["ID_Tarea", dgv_tareas.CurrentRow.Index].Value), dgv_tareas["Nombre_Tarea", dgv_tareas.CurrentRow.Index].Value, System.Convert.ToDateTime(dgv_tareas["Fecha", dgv_tareas.CurrentRow.Index].Value));
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
                MessageBox.Show("Tarea Modificada");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chk_seleccionartodo_CheckedChanged(object sender, EventArgs e)
        {
            if (dgv_tareas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_tareas.Rows)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tareas.SelectedRows.Count ==1)
            {
                idtareamostrarLog = Convert.ToInt32(dgv_tareas["ID_Tarea", dgv_tareas.CurrentRow.Index].Value);
                cargarlista(idtareamostrarLog);
            }           
        }
    }
}
