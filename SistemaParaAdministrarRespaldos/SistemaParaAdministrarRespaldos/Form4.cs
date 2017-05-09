using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaParaAdministrarRespaldos.Properties;

namespace SistemaParaAdministrarRespaldos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private static string cadenadeconexion()
        {
            return Settings.Default.mydatabaseConnectionString;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydatabaseDataSet.Tabla_Tarea' table. You can move, or remove it, as needed.
            this.Tabla_TareaTableAdapter.Fill(this.mydatabaseDataSet.Tabla_Tarea);
            // TODO: This line of code loads data into the 'mydatabaseDataSet.Tabla_Archivo' table. You can move, or remove it, as needed.
            this.Tabla_ArchivoTableAdapter.Fill(this.mydatabaseDataSet.Tabla_Archivo);
            // TODO: This line of code loads data into the 'mydatabaseDataSet.Tabla_Ejecucion' table. You can move, or remove it, as needed.
            this.Tabla_EjecucionTableAdapter.Fill(this.mydatabaseDataSet.Tabla_Ejecucion);

            this.reportViewer1.RefreshReport();
        }
    }
}
