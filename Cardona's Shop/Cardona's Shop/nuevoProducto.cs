using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardona_s_Shop
{
    public partial class nuevoProducto : Form
    {
        public nuevoProducto(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado.ToString();
            txtCodigo.Focus();
        }

        private void nuevoProducto_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            dt = conn.consultaGeneralInventario();
            dgvProductos.DataSource = dt;

            dt = conn.consultaGeneralDepartamentos();

            foreach (DataRow row in dt.Rows)
            {
                cmbCategoria.Items.Add(row["nombre"].ToString());
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtCodigo.TextLength > 0)
            {
                dt = conn.consultaGeneralInventarioPorCodigo(Convert.ToInt64(txtCodigo.Text));
                dgvProductos.DataSource = dt;
            }
            else
            {
                if (txtNombreProducto.TextLength > 0)
                {
                    dt = conn.consultaGeneralInventarioPorNombre(txtNombreProducto.Text);
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    dt = conn.consultaGeneralInventario();
                    dgvProductos.DataSource = dt;
                }
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtNombreProducto.TextLength > 0)
            {
                dt = conn.consultaGeneralInventarioPorNombre(txtNombreProducto.Text);
                dgvProductos.DataSource = dt;
            }
            else
            {
                if (txtCodigo.TextLength > 0)
                {
                    dt = conn.consultaGeneralInventarioPorCodigo(Convert.ToInt64(txtCodigo.Text));
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    dt = conn.consultaGeneralInventario();
                    dgvProductos.DataSource = dt;
                }
            }
        }

        private void nuevoProductoIns()
        {
            if (txtCodigo.Text == "" || txtNombreProducto.Text == "" || txtPrecio.Text == "" || txtStock.Text == "" || cmbCategoria.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtCodigo.TextLength < 13)
            {
                MessageBox.Show("Codigo Incompleto", "Codigo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                conexion conn = new conexion();
                DataTable dt2 = new DataTable();
                dt2= conn.consultaGeneralDepartamentos();
                string siglas = "";
                foreach (DataRow row in dt2.Rows)
                {
                    if (row["nombre"].ToString() == cmbCategoria.Text)
                    {
                        siglas = row["siglasDepartamento"].ToString();
                        break;
                    }
                }
                if (conn.insertarNuevoProducto(Convert.ToInt64(txtCodigo.Text), txtNombreProducto.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), siglas))
                {
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    cmbCategoria.Text = "";
                    MessageBox.Show("Producto registrado con exito", "Producto registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();

                    dt = conn.consultaGeneralInventario();
                    dgvProductos.DataSource = dt;
                }
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            nuevoProductoIns();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            DialogResult respuesta = MessageBox.Show("Estas Seguro de eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                if (conn.borrarProducto(Convert.ToInt64(dgvProductos.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    MessageBox.Show("producto eliminado con exito", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt=conn.consultaGeneralInventario();
                    dgvProductos.DataSource = dt;
                }
            }
        }

        //codigo para comboBox
    }
}
