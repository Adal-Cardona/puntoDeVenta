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
    public partial class nuevosPuestos : Form
    {
        public nuevosPuestos(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado.ToString();
        }
        

        private void btnNuevoPuesto_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            int ventas = 0, entradaInventario = 0, revisionStock = 0, secProductos = 0, secEmpleados = 0, reporteVentas = 0, reporteInventario = 0, cambios = 0;

            ventas = chbVentas.Checked ? 1:0;
            entradaInventario = chbEntradaInventario.Checked ? 1:0;
            revisionStock = chbRevisionStock.Checked ? 1:0;
            secProductos = chbNuevosProductos.Checked ? 1:0;
            secEmpleados = chbSeccionEmpleados.Checked ? 1:0;
            reporteVentas = chbReporteVentas.Checked ? 1:0;
            reporteInventario = chbReporteInventarios.Checked ? 1:0;
            cambios = chbCambios.Checked ? 1:0;

            if (conn.insertarNuevoPuesto(txtNombre.Text, ventas, entradaInventario, revisionStock, secProductos, secEmpleados, reporteVentas, reporteInventario, cambios))
            {
                txtNombre.Text = "";
                chbVentas.Checked = false;
                chbEntradaInventario.Checked = false;
                chbRevisionStock.Checked = false;
                chbNuevosProductos.Checked = false;
                chbSeccionEmpleados.Checked = false;
                chbReporteVentas.Checked = false;
                chbReporteInventarios.Checked = false;
                chbCambios.Checked = false;
                dt= conn.consultaGeneralPuesto();
                dgvPuestos.DataSource = dt;
            }

        }

        private void nuevosPuestos_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt= conn.consultaGeneralPuesto();
            dgvPuestos.DataSource = dt;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            if (txtNombre.TextLength > 0)
            {
                dt = conn.consultaGeneralPuestoPorNombre(txtNombre.Text);
                dgvPuestos.DataSource = dt;
            }
            else
            {
                dt= conn.consultaGeneralPuesto();
                dgvPuestos.DataSource = dt;
            }
        }

        private void dgvPuestos_DoubleClick(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            DialogResult respuesta = MessageBox.Show("Estas Seguro de eliminar este puesto?", "Eliminar puesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                if (conn.borrarPuesto(Convert.ToInt32(dgvPuestos.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Puesto eliminado con exito", "Puesto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt=conn.consultaGeneralPuesto();
                    dgvPuestos.DataSource = dt;
                }
            }
        }
    }
}
