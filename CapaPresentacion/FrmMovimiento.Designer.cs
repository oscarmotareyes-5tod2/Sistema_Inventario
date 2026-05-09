namespace CapaPresentacion
{
    partial class FrmMovimiento
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.gbMovimiento = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LNo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbMovimiento.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(316, 28);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(125, 24);
            this.LTitulo.TabIndex = 2;
            this.LTitulo.Text = "Movimientos";
            // 
            // gbMovimiento
            // 
            this.gbMovimiento.Controls.Add(this.cmbUsuario);
            this.gbMovimiento.Controls.Add(this.LUsuario);
            this.gbMovimiento.Controls.Add(this.txtNo);
            this.gbMovimiento.Controls.Add(this.dateTimePicker1);
            this.gbMovimiento.Controls.Add(this.LNo);
            this.gbMovimiento.Controls.Add(this.LFecha);
            this.gbMovimiento.Controls.Add(this.cmbProveedor);
            this.gbMovimiento.Controls.Add(this.cmbTipo);
            this.gbMovimiento.Controls.Add(this.LProveedor);
            this.gbMovimiento.Controls.Add(this.LTipo);
            this.gbMovimiento.Location = new System.Drawing.Point(76, 77);
            this.gbMovimiento.Name = "gbMovimiento";
            this.gbMovimiento.Size = new System.Drawing.Size(600, 78);
            this.gbMovimiento.TabIndex = 3;
            this.gbMovimiento.TabStop = false;
            this.gbMovimiento.Text = "Movimiento";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(507, 23);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(87, 21);
            this.cmbUsuario.TabIndex = 9;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(458, 26);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(43, 13);
            this.LUsuario.TabIndex = 5;
            this.LUsuario.Text = "Usuario";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(240, 52);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(40, 20);
            this.txtNo.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // LNo
            // 
            this.LNo.AutoSize = true;
            this.LNo.Location = new System.Drawing.Point(197, 58);
            this.LNo.Name = "LNo";
            this.LNo.Size = new System.Drawing.Size(25, 13);
            this.LNo.TabIndex = 5;
            this.LNo.Text = "°No";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(197, 26);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(37, 13);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "Fecha";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(68, 50);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(97, 21);
            this.cmbProveedor.TabIndex = 6;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(40, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(76, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Location = new System.Drawing.Point(6, 58);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(56, 13);
            this.LProveedor.TabIndex = 5;
            this.LProveedor.Text = "Proveedor";
            this.LProveedor.Click += new System.EventHandler(this.LProveedor_Click);
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(6, 26);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(28, 13);
            this.LTipo.TabIndex = 4;
            this.LTipo.Text = "Tipo";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btnSalir);
            this.gbDetalle.Controls.Add(this.btnGuardar);
            this.gbDetalle.Controls.Add(this.btnCancelar);
            this.gbDetalle.Controls.Add(this.dgvDetalle);
            this.gbDetalle.Controls.Add(this.btnEliminar);
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.txtCantidad);
            this.gbDetalle.Controls.Add(this.cmbProducto);
            this.gbDetalle.Controls.Add(this.LCantidad);
            this.gbDetalle.Controls.Add(this.LProducto);
            this.gbDetalle.Location = new System.Drawing.Point(76, 170);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(600, 242);
            this.gbDetalle.TabIndex = 10;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(507, 155);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(507, 73);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(507, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(79, 73);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(265, 150);
            this.dgvDetalle.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "✖️";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(339, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "✔️";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(244, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(68, 34);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(97, 21);
            this.cmbProducto.TabIndex = 10;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(189, 37);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(49, 13);
            this.LCantidad.TabIndex = 11;
            this.LCantidad.Text = "Cantidad";
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(12, 37);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(50, 13);
            this.LProducto.TabIndex = 10;
            this.LProducto.Text = "Producto";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(24, 418);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(95, 35);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbMovimiento);
            this.Controls.Add(this.LTitulo);
            this.Name = "FrmMovimiento";
            this.Text = "FrmMovimiento";
            this.Load += new System.EventHandler(this.FrmMovimiento_Load);
            this.gbMovimiento.ResumeLayout(false);
            this.gbMovimiento.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.GroupBox gbMovimiento;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LNo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cmbUsuario;
    }
}