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
    public partial class verInfoEmpleados : Form
    {
        public verInfoEmpleados()
        {
            InitializeComponent();
        }

        private void verInfoEmpleados_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            dt = conn.consultaGeneralEmpleadosNomCompleto();
            dgvEmpleados.DataSource = dt;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtID.TextLength > 0)
            {
                dt = conn.consultaGeneralEmpleadosNomCompletoPorID(Convert.ToInt32(txtID.Text));
                dgvEmpleados.DataSource = dt;
                txtNombre.ReadOnly = true;
            }
            else
            {
                dt = conn.consultaGeneralEmpleadosNomCompleto();
                dgvEmpleados.DataSource = dt;
                txtNombre.ReadOnly = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            if (txtNombre.TextLength > 0)
            {
                dt = conn.consultaGeneralEmpleadosNomCompletoPorNombre(txtNombre.Text);
                dgvEmpleados.DataSource = dt;
                txtID.ReadOnly = true;
            }
            else
            {
                dt = conn.consultaGeneralEmpleadosNomCompleto();
                dgvEmpleados.DataSource = dt;
                txtID.ReadOnly = false;
            }
        }
    }
}
