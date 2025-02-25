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
    public partial class revisarStock : Form
    {
        public revisarStock()
        {
            InitializeComponent();
        }

        private void revisarStock_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            dt = conn.consultaGeneralInventario();
            dgvStock.DataSource = dt;
            

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtCodigo.TextLength > 0)
            {
                dt = conn.consultaGeneralInventarioPorCodigo(Convert.ToInt64(txtCodigo.Text));
                dgvStock.DataSource = dt;
                txtNombre.ReadOnly = true;
            }
            else
            {
                dt = conn.consultaGeneralInventario();
                dgvStock.DataSource = dt;
                txtNombre.ReadOnly = false;
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtNombre.TextLength > 0)
            {
                dt = conn.consultaGeneralInventarioPorNombre(txtNombre.Text);
                dgvStock.DataSource = dt;
                txtCodigo.ReadOnly = true;
            }
            else
            {
                dt = conn.consultaGeneralInventario();
                dgvStock.DataSource = dt;
                txtCodigo.ReadOnly = false;
            }

        }
    }
}
