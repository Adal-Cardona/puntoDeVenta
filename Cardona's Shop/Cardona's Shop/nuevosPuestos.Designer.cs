namespace Cardona_s_Shop
{
    partial class nuevosPuestos
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoPuesto = new System.Windows.Forms.Button();
            this.chbCambios = new System.Windows.Forms.CheckBox();
            this.chbReporteInventarios = new System.Windows.Forms.CheckBox();
            this.chbReporteVentas = new System.Windows.Forms.CheckBox();
            this.chbSeccionEmpleados = new System.Windows.Forms.CheckBox();
            this.chbNuevosProductos = new System.Windows.Forms.CheckBox();
            this.chbRevisionStock = new System.Windows.Forms.CheckBox();
            this.chbEntradaInventario = new System.Windows.Forms.CheckBox();
            this.chbVentas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(403, 103);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(527, 311);
            this.dgvPuestos.TabIndex = 0;
            this.dgvPuestos.DoubleClick += new System.EventHandler(this.dgvPuestos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puestos existentes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Nuevo Puesto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoPuesto);
            this.groupBox1.Controls.Add(this.chbCambios);
            this.groupBox1.Controls.Add(this.chbReporteInventarios);
            this.groupBox1.Controls.Add(this.chbReporteVentas);
            this.groupBox1.Controls.Add(this.chbSeccionEmpleados);
            this.groupBox1.Controls.Add(this.chbNuevosProductos);
            this.groupBox1.Controls.Add(this.chbRevisionStock);
            this.groupBox1.Controls.Add(this.chbEntradaInventario);
            this.groupBox1.Controls.Add(this.chbVentas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnNuevoPuesto
            // 
            this.btnNuevoPuesto.Location = new System.Drawing.Point(271, 267);
            this.btnNuevoPuesto.Name = "btnNuevoPuesto";
            this.btnNuevoPuesto.Size = new System.Drawing.Size(88, 40);
            this.btnNuevoPuesto.TabIndex = 13;
            this.btnNuevoPuesto.Text = "Crear Nuevo Puesto";
            this.btnNuevoPuesto.UseVisualStyleBackColor = true;
            this.btnNuevoPuesto.Click += new System.EventHandler(this.btnNuevoPuesto_Click);
            // 
            // chbCambios
            // 
            this.chbCambios.AutoSize = true;
            this.chbCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCambios.Location = new System.Drawing.Point(190, 219);
            this.chbCambios.Name = "chbCambios";
            this.chbCambios.Size = new System.Drawing.Size(90, 24);
            this.chbCambios.TabIndex = 12;
            this.chbCambios.Text = "Cambios";
            this.chbCambios.UseVisualStyleBackColor = true;
            // 
            // chbReporteInventarios
            // 
            this.chbReporteInventarios.AutoSize = true;
            this.chbReporteInventarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbReporteInventarios.Location = new System.Drawing.Point(190, 196);
            this.chbReporteInventarios.Name = "chbReporteInventarios";
            this.chbReporteInventarios.Size = new System.Drawing.Size(190, 24);
            this.chbReporteInventarios.TabIndex = 11;
            this.chbReporteInventarios.Text = "Reporte de Inventarios";
            this.chbReporteInventarios.UseVisualStyleBackColor = true;
            // 
            // chbReporteVentas
            // 
            this.chbReporteVentas.AutoSize = true;
            this.chbReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbReporteVentas.Location = new System.Drawing.Point(190, 170);
            this.chbReporteVentas.Name = "chbReporteVentas";
            this.chbReporteVentas.Size = new System.Drawing.Size(163, 24);
            this.chbReporteVentas.TabIndex = 10;
            this.chbReporteVentas.Text = "Reporte de Ventas";
            this.chbReporteVentas.UseVisualStyleBackColor = true;
            // 
            // chbSeccionEmpleados
            // 
            this.chbSeccionEmpleados.AutoSize = true;
            this.chbSeccionEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSeccionEmpleados.Location = new System.Drawing.Point(190, 147);
            this.chbSeccionEmpleados.Name = "chbSeccionEmpleados";
            this.chbSeccionEmpleados.Size = new System.Drawing.Size(169, 24);
            this.chbSeccionEmpleados.TabIndex = 9;
            this.chbSeccionEmpleados.Text = "Seccion Empleados";
            this.chbSeccionEmpleados.UseVisualStyleBackColor = true;
            // 
            // chbNuevosProductos
            // 
            this.chbNuevosProductos.AutoSize = true;
            this.chbNuevosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNuevosProductos.Location = new System.Drawing.Point(6, 219);
            this.chbNuevosProductos.Name = "chbNuevosProductos";
            this.chbNuevosProductos.Size = new System.Drawing.Size(161, 24);
            this.chbNuevosProductos.TabIndex = 8;
            this.chbNuevosProductos.Text = "Seccion Productos";
            this.chbNuevosProductos.UseVisualStyleBackColor = true;
            // 
            // chbRevisionStock
            // 
            this.chbRevisionStock.AutoSize = true;
            this.chbRevisionStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRevisionStock.Location = new System.Drawing.Point(6, 196);
            this.chbRevisionStock.Name = "chbRevisionStock";
            this.chbRevisionStock.Size = new System.Drawing.Size(155, 24);
            this.chbRevisionStock.TabIndex = 7;
            this.chbRevisionStock.Text = "Revision de Stock";
            this.chbRevisionStock.UseVisualStyleBackColor = true;
            // 
            // chbEntradaInventario
            // 
            this.chbEntradaInventario.AutoSize = true;
            this.chbEntradaInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEntradaInventario.Location = new System.Drawing.Point(6, 170);
            this.chbEntradaInventario.Name = "chbEntradaInventario";
            this.chbEntradaInventario.Size = new System.Drawing.Size(179, 24);
            this.chbEntradaInventario.TabIndex = 6;
            this.chbEntradaInventario.Text = "Entrada de inventario";
            this.chbEntradaInventario.UseVisualStyleBackColor = true;
            // 
            // chbVentas
            // 
            this.chbVentas.AutoSize = true;
            this.chbVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVentas.Location = new System.Drawing.Point(6, 147);
            this.chbVentas.Name = "chbVentas";
            this.chbVentas.Size = new System.Drawing.Size(79, 24);
            this.chbVentas.TabIndex = 5;
            this.chbVentas.Text = "Ventas";
            this.chbVentas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Permisos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(7, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(101, 8);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 18;
            this.txtID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Empleado";
            // 
            // nuevosPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 448);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPuestos);
            this.Name = "nuevosPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "nuevosPuestos";
            this.Load += new System.EventHandler(this.nuevosPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chbCambios;
        private System.Windows.Forms.CheckBox chbReporteInventarios;
        private System.Windows.Forms.CheckBox chbReporteVentas;
        private System.Windows.Forms.CheckBox chbSeccionEmpleados;
        private System.Windows.Forms.CheckBox chbNuevosProductos;
        private System.Windows.Forms.CheckBox chbRevisionStock;
        private System.Windows.Forms.CheckBox chbEntradaInventario;
        private System.Windows.Forms.Button btnNuevoPuesto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
    }
}