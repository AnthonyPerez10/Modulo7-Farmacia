namespace Borrador
{
    partial class UCFrmInventarioFarmacia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblExistenciaActual = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.nudExitenciaActual = new System.Windows.Forms.NumericUpDown();
            this.lblExistenciaMinima = new System.Windows.Forms.Label();
            this.nudExistenciaMinima = new System.Windows.Forms.NumericUpDown();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwListaActual = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExitenciaActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentos.Location = new System.Drawing.Point(45, 155);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(114, 20);
            this.lblMedicamentos.TabIndex = 1;
            this.lblMedicamentos.Text = "Medicamentos: ";
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInterno.Location = new System.Drawing.Point(45, 200);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(116, 20);
            this.lblCodigoInterno.TabIndex = 2;
            this.lblCodigoInterno.Text = "Codigo Interno: ";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(45, 241);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(100, 20);
            this.lblPresentacion.TabIndex = 3;
            this.lblPresentacion.Text = "Presentación: ";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(45, 278);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(140, 20);
            this.lblUnidadMedida.TabIndex = 4;
            this.lblUnidadMedida.Text = "Unidad de medida: ";
            // 
            // lblExistenciaActual
            // 
            this.lblExistenciaActual.AutoSize = true;
            this.lblExistenciaActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistenciaActual.Location = new System.Drawing.Point(45, 319);
            this.lblExistenciaActual.Name = "lblExistenciaActual";
            this.lblExistenciaActual.Size = new System.Drawing.Size(127, 20);
            this.lblExistenciaActual.TabIndex = 5;
            this.lblExistenciaActual.Text = "Existencia Actual: ";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(45, 400);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(140, 20);
            this.lblFechaVencimiento.TabIndex = 6;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento: ";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(45, 437);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(45, 20);
            this.lblLote.TabIndex = 7;
            this.lblLote.Text = "Lote: ";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(45, 477);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(84, 20);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(45, 519);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 93);
            this.panel1.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(275, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(287, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inventario de Medicamentos";
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(165, 155);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(215, 21);
            this.cmbMedicamentos.TabIndex = 11;
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.Location = new System.Drawing.Point(165, 202);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoInterno.TabIndex = 12;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(180, 280);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(200, 21);
            this.cmbUnidadMedida.TabIndex = 13;
            // 
            // nudExitenciaActual
            // 
            this.nudExitenciaActual.Location = new System.Drawing.Point(180, 322);
            this.nudExitenciaActual.Name = "nudExitenciaActual";
            this.nudExitenciaActual.Size = new System.Drawing.Size(120, 20);
            this.nudExitenciaActual.TabIndex = 14;
            // 
            // lblExistenciaMinima
            // 
            this.lblExistenciaMinima.AutoSize = true;
            this.lblExistenciaMinima.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistenciaMinima.Location = new System.Drawing.Point(45, 360);
            this.lblExistenciaMinima.Name = "lblExistenciaMinima";
            this.lblExistenciaMinima.Size = new System.Drawing.Size(135, 20);
            this.lblExistenciaMinima.TabIndex = 15;
            this.lblExistenciaMinima.Text = "Existencia Minima: ";
            // 
            // nudExistenciaMinima
            // 
            this.nudExistenciaMinima.Location = new System.Drawing.Point(180, 360);
            this.nudExistenciaMinima.Name = "nudExistenciaMinima";
            this.nudExistenciaMinima.Size = new System.Drawing.Size(120, 20);
            this.nudExistenciaMinima.TabIndex = 16;
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(165, 243);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(215, 21);
            this.cmbPresentacion.TabIndex = 17;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(180, 399);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaVencimiento.TabIndex = 18;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(168, 439);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(215, 20);
            this.txtLote.TabIndex = 19;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(168, 479);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(215, 21);
            this.cmbProveedor.TabIndex = 20;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(168, 518);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(215, 21);
            this.cmbEstado.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(49, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 27);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(165, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 27);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(287, 113);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 27);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(170)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ver Stock";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lista Actual ";
            // 
            // dgwListaActual
            // 
            this.dgwListaActual.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwListaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaActual.Location = new System.Drawing.Point(452, 187);
            this.dgwListaActual.Name = "dgwListaActual";
            this.dgwListaActual.Size = new System.Drawing.Size(316, 301);
            this.dgwListaActual.TabIndex = 26;
            // 
            // UCFrmInventarioFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwListaActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.cmbPresentacion);
            this.Controls.Add(this.nudExistenciaMinima);
            this.Controls.Add(this.lblExistenciaMinima);
            this.Controls.Add(this.nudExitenciaActual);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.txtCodigoInterno);
            this.Controls.Add(this.cmbMedicamentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblExistenciaActual);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.lblMedicamentos);
            this.Name = "UCFrmInventarioFarmacia";
            this.Size = new System.Drawing.Size(780, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExitenciaActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblExistenciaActual;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbMedicamentos;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.NumericUpDown nudExitenciaActual;
        private System.Windows.Forms.Label lblExistenciaMinima;
        private System.Windows.Forms.NumericUpDown nudExistenciaMinima;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwListaActual;
    }
}
