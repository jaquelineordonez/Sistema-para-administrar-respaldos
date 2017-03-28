﻿using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
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

       
        private void CargarDatos()
        {
            tabla = new DataTable();
            adaptador = new SQLiteDataAdapter("SELECT * FROM Tabla_Tarea", conexion);
            adaptador.Fill(tabla);
            builder = new SQLiteCommandBuilder(adaptador);
            tabla.Columns.Add("Seleccionar", typeof(bool));
            dataGridView1.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                conexion = new SQLiteConnection("Data source = D:\\Sistema para manejar respaldos\\Sistema-para-administrar-respaldos\\mydatabase.sqlite;Version=3");
                conexion.Open();
                CargarDatos();
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
                    if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            if (dataGridView1.Rows.Count >= 1)
            {


                ///SQLiteCommand nom = new SQLiteCommand("SELECT Nombre_Tarea FROM Tabla_Tarea WHERE ID_Tarea=" + idtarea, conexion);
                string nombreruta = "xx";
                ////SQLiteCommand comandoinicio = new SQLiteCommand("SELECT Datos_Archivo FROM Tabla_Archivo WHERE ID_Tarea=" + idtarea, conexion);
                string rutainicio = @"C:\Users\residente.sistemas\Documents\5.1 Permitir agregar ruta de salida de una tarea.docx";
                /////SQLiteCommand comandosalida = new SQLiteCommand("SELECT Ruta_Salida FROM Tabla_Ruta WHERE ID_Tarea=" + idtarea, conexion);
                string rutasalida = @"C:\Users\residente.sistemas\Desktop\salida";

                string archivoinicio = System.IO.Path.Combine(rutainicio, nombreruta);
                string archivosalida = System.IO.Path.Combine(rutasalida, nombreruta);

                if (!System.IO.Directory.Exists(rutasalida))
                {
                    System.IO.Directory.CreateDirectory(rutasalida);
                }

                /////System.IO.File.Copy(archivoinicio, archivosalida, true);
                
                if (System.IO.File.Exists(rutainicio))
                {
                    string[] doc = System.IO.Directory.GetFiles(rutainicio);
                    foreach (string x in doc)
                    {
                        nombreruta = System.IO.Path.GetFileName(x);
                        archivosalida = System.IO.Path.Combine(rutasalida, nombreruta);
                        System.IO.File.Copy(x, archivosalida, true);
                    }
                }
                else
                {
                    MessageBox.Show("No existe");
                }
            }

            MessageBox.Show("Tarea ejecutada");
            /*if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            Form3 forma = new Form3(conexion);
            forma.ShowDialog();*/
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
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
