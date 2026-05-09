namespace CapaPresentacion
{
    partial class FrmReporte
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
            this.inventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new CapaPresentacion.InventarioDataSet();
            this.rvMovi = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDataSetBindingSource
            // 
            this.inventarioDataSetBindingSource.DataSource = this.inventarioDataSet;
            this.inventarioDataSetBindingSource.Position = 0;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "InventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvMovi
            // 
            this.rvMovi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosReporte";
            reportDataSource1.Value = this.inventarioDataSetBindingSource;
            this.rvMovi.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMovi.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Movimientos.rdlc";
            this.rvMovi.Location = new System.Drawing.Point(0, 0);
            this.rvMovi.Name = "rvMovi";
            this.rvMovi.ServerReport.BearerToken = null;
            this.rvMovi.Size = new System.Drawing.Size(768, 481);
            this.rvMovi.TabIndex = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 481);
            this.Controls.Add(this.rvMovi);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMovi;
        private System.Windows.Forms.BindingSource inventarioDataSetBindingSource;
        private InventarioDataSet inventarioDataSet;
    }
}