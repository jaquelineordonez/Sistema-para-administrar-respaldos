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
using SistemaParaAdministrarRespaldos.Properties;

namespace SistemaParaAdministrarRespaldos
{
    public partial class ReporteTarea : Form
    {
        private int idTarea = 0;

        public ReporteTarea(int idTarea)
        {
            this.idTarea = idTarea;
            InitializeComponent();       
        }

        private static string cadenadeconexion()
        {
            return Settings.Default.mydatabaseConnectionString;
        }

        private void ReporteTarea_Load(object sender, EventArgs e)
        {           
            ReporteNuevo rpt = new ReporteNuevo();
            DataTable tabla = (DataTable)new mydatabaseDataSetTableAdapters.Tabla_TodoTableAdapter().llenarReporte(idTarea);
            rpt.SetDataSource(tabla);
            DataTable tablaej = (DataTable)new mydatabaseDataSetTableAdapters.Tabla_EjecucionTableAdapter().llenarEjecuciones(idTarea);
            rpt.Subreports[0].SetDataSource(tablaej);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
