namespace SistemaParaAdministrarRespaldos
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mydatabaseDataSet = new SistemaParaAdministrarRespaldos.mydatabaseDataSet();
            this.Tabla_ArchivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_ArchivoTableAdapter = new SistemaParaAdministrarRespaldos.mydatabaseDataSetTableAdapters.Tabla_ArchivoTableAdapter();
            this.Tabla_EjecucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_EjecucionTableAdapter = new SistemaParaAdministrarRespaldos.mydatabaseDataSetTableAdapters.Tabla_EjecucionTableAdapter();
            this.Tabla_TareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_TareaTableAdapter = new SistemaParaAdministrarRespaldos.mydatabaseDataSetTableAdapters.Tabla_TareaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_ArchivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_EjecucionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_TareaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Archivo";
            reportDataSource1.Value = this.Tabla_ArchivoBindingSource;
            reportDataSource2.Name = "FechayHoraEjecucion";
            reportDataSource2.Value = this.Tabla_EjecucionBindingSource;
            reportDataSource3.Name = "NombreTarea";
            reportDataSource3.Value = this.Tabla_TareaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaParaAdministrarRespaldos.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // mydatabaseDataSet
            // 
            this.mydatabaseDataSet.DataSetName = "mydatabaseDataSet";
            this.mydatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tabla_ArchivoBindingSource
            // 
            this.Tabla_ArchivoBindingSource.DataMember = "Tabla_Archivo";
            this.Tabla_ArchivoBindingSource.DataSource = this.mydatabaseDataSet;
            // 
            // Tabla_ArchivoTableAdapter
            // 
            this.Tabla_ArchivoTableAdapter.ClearBeforeFill = true;
            // 
            // Tabla_EjecucionBindingSource
            // 
            this.Tabla_EjecucionBindingSource.DataMember = "Tabla_Ejecucion";
            this.Tabla_EjecucionBindingSource.DataSource = this.mydatabaseDataSet;
            // 
            // Tabla_EjecucionTableAdapter
            // 
            this.Tabla_EjecucionTableAdapter.ClearBeforeFill = true;
            // 
            // Tabla_TareaBindingSource
            // 
            this.Tabla_TareaBindingSource.DataMember = "Tabla_Tarea";
            this.Tabla_TareaBindingSource.DataSource = this.mydatabaseDataSet;
            // 
            // Tabla_TareaTableAdapter
            // 
            this.Tabla_TareaTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 458);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Reporte Tarea";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_ArchivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_EjecucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_TareaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tabla_ArchivoBindingSource;
        private mydatabaseDataSet mydatabaseDataSet;
        private System.Windows.Forms.BindingSource Tabla_EjecucionBindingSource;
        private mydatabaseDataSetTableAdapters.Tabla_ArchivoTableAdapter Tabla_ArchivoTableAdapter;
        private mydatabaseDataSetTableAdapters.Tabla_EjecucionTableAdapter Tabla_EjecucionTableAdapter;
        private System.Windows.Forms.BindingSource Tabla_TareaBindingSource;
        private mydatabaseDataSetTableAdapters.Tabla_TareaTableAdapter Tabla_TareaTableAdapter;
    }
}