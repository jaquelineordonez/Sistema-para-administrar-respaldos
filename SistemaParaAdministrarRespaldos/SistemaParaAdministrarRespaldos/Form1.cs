﻿using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;
using Microsoft.VisualBasic.Devices;


namespace SistemaParaAdministrarRespaldos
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private SQLiteConnection conexion;
        private int idtarea;
        private Computer mycomputer = new Computer();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SQLiteConnection conexion, int id_tarea)
        {
            this.conexion = conexion;
            this.idtarea = id_tarea;
        }

        private DataTable tabla = new DataTable();
        private SQLiteDataAdapter adaptador;
        private SQLiteCommandBuilder builder;

        private DataTable tbl = new DataTable();
        private SQLiteDataAdapter adp;
        private SQLiteCommandBuilder build;

        private void CargarDatos()
        {
            tabla = new DataTable();
            adaptador = new SQLiteDataAdapter("SELECT * FROM Tabla_Tarea", conexion);
            adaptador.Fill(tabla);
            builder = new SQLiteCommandBuilder(adaptador);
            tabla.Columns.Add("Seleccionar", typeof(bool));
            dataGridView1.DataSource = tabla;
        }

        private void cargarejecucion()
        {
            tbl = new DataTable();
            adp = new SQLiteDataAdapter("SELECT * FROM Tabla_Ejecucion", conexion);
            adp.Fill(tbl);
            build = new SQLiteCommandBuilder(adp);
            dgv_ejecucion.DataSource = tbl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_ejecucion.AutoGenerateColumns = false;
            dgv_ejecucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_ejecucion.Sort(FechaHoraZip, System.ComponentModel.ListSortDirection.Ascending);

            try
            {
                conexion = new SQLiteConnection("Data source = D:\\Sistema para manejar respaldos\\Sistema-para-administrar-respaldos\\mydatabase.sqlite;Version=3");
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
            Form2 form2 = new Form2(conexion, Convert.ToInt32(dataGridView1["ID_Tarea", dataGridView1.CurrentRow.Index].Value), dataGridView1["Nombre_Tarea", dataGridView1.CurrentRow.Index].Value, System.Convert.ToDateTime(dataGridView1["Fecha", dataGridView1.CurrentRow.Index].Value));
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
                dataGridView1.EndEdit(); ///se abria beginEdit() pero no se cerraba, por eso no funcionaba el check  hasta que el foco dejaba de estar en el renglon
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
                            rowsSeleccionados[x].Delete();
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = tabla;
                        CargarDatos();

                        transaccion.Commit();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una tarea", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    object seleccionado = null;
                    for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    {
                        seleccionado = dataGridView1["Seleccionar", x].Value;
                        if (seleccionado != DBNull.Value)
                        {
                            if (Convert.ToBoolean(seleccionado))
                            {
                                dataGridView1.Rows.RemoveAt(x);
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
                dataGridView1.EndEdit();
                tabla.AcceptChanges();

                DataRow[] rowsSeleccionados = tabla.Select("Seleccionar = " + true);
                if (rowsSeleccionados != null && rowsSeleccionados.Length >= 1)
                {
                    for (int x = 0; x < rowsSeleccionados.Length; x++)
                    {
                        id_Tarea = rowsSeleccionados[x][0];
                        SQLiteCommand nom = new SQLiteCommand("SELECT Nombre_Tarea FROM Tabla_Tarea WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        string nombrezip = nom.ExecuteScalar().ToString();

                        SQLiteCommand comandosalida = new SQLiteCommand("SELECT Ruta_Salida FROM Tabla_Ruta WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        string rutasalida = comandosalida.ExecuteScalar().ToString();

                        string contraseña;
                        SQLiteCommand contra = new SQLiteCommand("SELECT Contraseña FROM Tabla_Ruta WHERE ID_Tarea=" + id_Tarea, conexion);
                        string contras = contra.ExecuteScalar().ToString();

                        if (contras == string.Empty)
                        {
                            contraseña = string.Empty;
                        }
                        else
                        {
                            contraseña = StringCipher.Decrypt(contras);
                        }

                        SQLiteCommand comandoinicio = new SQLiteCommand("SELECT Datos_Archivo FROM Tabla_Archivo WHERE (ID_Tarea= " + id_Tarea + ")", conexion, transaccion);
                        SQLiteDataReader rutainicio = comandoinicio.ExecuteReader();

                        string rutaarchivo = string.Empty;
                        using (ZipFile zip = new ZipFile())
                        {
                            while (rutainicio.Read())
                            {
                                rutaarchivo = Convert.ToString(rutainicio.GetValue(0));
                                if (File.Exists(rutaarchivo))
                                {

                                    if (contraseña != string.Empty)
                                    {
                                        zip.Password = contraseña;
                                    }
                                    zip.AddFile(rutaarchivo, string.Empty);
                                }
                            }
                            zip.Save(rutasalida + "\\" + nombrezip + ".zip");
                        }
                        
                        ////string hr = DateTime.Now.ToString();
                        ////string formato = string.Format("yyyy-MM-dd HH:mm:ss", hr);
                        ////string.Format("yyyy-MM-dd HH:mm:ss", DateTime.Now.Date.ToString()))
                        string comando = "insert into Tabla_Ejecucion (Nombre_TareaZip,FechaHoraZip,Ruta_SalidaZip,ID_Tarea)values(@Nombre_TareaZip,@FechaHoraZip,@Ruta_SalidaZip,@ID_Tarea)";
                        SQLiteCommand insercion = new SQLiteCommand(comando, conexion, transaccion);
                        insercion.Parameters.AddWithValue("@Nombre_TareaZip", nombrezip);
                        insercion.Parameters.AddWithValue("@FechaHoraZip", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                        insercion.Parameters.AddWithValue("@Ruta_SalidaZip", rutasalida);
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
            Form2 form2 = new Form2(conexion, Convert.ToInt32(dataGridView1["ID_Tarea", dataGridView1.CurrentRow.Index].Value), dataGridView1["Nombre_Tarea", dataGridView1.CurrentRow.Index].Value, System.Convert.ToDateTime(dataGridView1["Fecha", dataGridView1.CurrentRow.Index].Value));
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
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void dgv_ejecucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarejecucion();
        }
    }
}
