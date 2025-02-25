namespace Cardona_s_Shop
{
    partial class entradas
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
            System.Windows.Forms.ColumnHeader codigo;
            this.lstEntradaInventarios = new System.Windows.Forms.ListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboProductos = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigo
            // 
            codigo.Text = "Codigo";
            codigo.Width = 127;
            // 
            // lstEntradaInventarios
            // 
            this.lstEntradaInventarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            codigo,
            this.producto,
            this.cantidad});
            this.lstEntradaInventarios.FullRowSelect = true;
            this.lstEntradaInventarios.GridLines = true;
            this.lstEntradaInventarios.HideSelection = false;
            this.lstEntradaInventarios.Location = new System.Drawing.Point(350, 84);
            this.lstEntradaInventarios.Name = "lstEntradaInventarios";
            this.lstEntradaInventarios.Size = new System.Drawing.Size(398, 282);
            this.lstEntradaInventarios.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstEntradaInventarios.TabIndex = 11;
            this.lstEntradaInventarios.UseCompatibleStateImageBehavior = false;
            this.lstEntradaInventarios.View = System.Windows.Forms.View.Details;
            this.lstEntradaInventarios.DoubleClick += new System.EventHandler(this.lstEntradaInventarios_DoubleClick);
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 211;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 56;
            // 
            // gboProductos
            // 
            this.gboProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gboProductos.Controls.Add(this.txtCantidad);
            this.gboProductos.Controls.Add(this.btnIngresar);
            this.gboProductos.Controls.Add(this.txtCodigo);
            this.gboProductos.Controls.Add(this.label1);
            this.gboProductos.Controls.Add(this.label2);
            this.gboProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboProductos.Location = new System.Drawing.Point(27, 84);
            this.gboProductos.Name = "gboProductos";
            this.gboProductos.Size = new System.Drawing.Size(298, 282);
            this.gboProductos.TabIndex = 10;
            this.gboProductos.TabStop = false;
            this.gboProductos.Text = "Productos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 131);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 31);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(166, 212);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 36);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(263, 31);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(620, 397);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(128, 30);
            this.btnRegistar.TabIndex = 12;
            this.btnRegistar.Text = "Registrar Entrada";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(104, 8);
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
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Entradas de Inventario";
            // 
            // entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lstEntradaInventarios);
            this.Controls.Add(this.gboProductos);
            this.Name = "entradas";
            this.Text = "entradas";
            this.gboProductos.ResumeLayout(false);
            this.gboProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEntradaInventarios;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.GroupBox gboProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}