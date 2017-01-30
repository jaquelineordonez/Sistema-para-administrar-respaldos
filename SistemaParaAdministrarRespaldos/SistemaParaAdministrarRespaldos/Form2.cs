using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaParaAdministrarRespaldos
{
    public partial class Form2 : Form
    {
        private SQLiteConnection conexion;

        public Form2(SQLiteConnection conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombretarea.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                this.DialogResult = DialogResult.OK; // registra el resultado del boton OK para que realize lo del form1 iff
                    conexion.Open();
                string format = "yyyy-MM-dd HH:mm:ss";
                string fecha = dateTimePicker1.Value.ToString(format);
                string comando = "insert into Tabla_Tarea (nombretarea,fecha)values('"+txt_nombretarea.Text +"','"+ fecha + "');";
                    SQLiteCommand insercion = new SQLiteCommand(comando, conexion);
                    insercion.ExecuteNonQuery();
                    conexion.Close();
                

               
            }
           
        }
    }
}
