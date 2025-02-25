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
    public partial class nuevoEmpleado : Form
    {
        public nuevoEmpleado(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            bool encontrado = false;
            dt = conn.consultaGeneralEmpleados();

            foreach (DataRow row in dt.Rows)
            {
                if (txtRFC.Text == row["rfc"].ToString())
                {
                    MessageBox.Show($"Empleado existente con el id {row["id"].ToString()}", "Empleado repetido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    encontrado= true;
                    break;
                }
               
            }

            dt=conn.consultaGeneralDepartamentos();

            string siglas = "";
            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre"].ToString() == cmbDepartamento.Text)
                {
                    siglas = row["siglasDepartamento"].ToString();
                    break;
                }
            }
            MessageBox.Show(siglas);

            dt = conn.consultaGeneralPuesto();
            int idPuesto =0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre"].ToString() == cmbPuesto.Text)
                {
                    idPuesto = Convert.ToInt32(row["id"].ToString());
                    break;
                }
            }

            MessageBox.Show(idPuesto.ToString());
            if (!encontrado)
            {
                if(conn.insertarNuevoEmpleado(txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, siglas, idPuesto, Convert.ToInt32(txtEdad.Text), txtRFC.Text))
                {
                    MessageBox.Show("Empleado registrado con exito", "Empleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void nuevoEmpleado_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt= conn.consultaGeneralDepartamentos();

            foreach (DataRow row in dt.Rows)
            {
                cmbDepartamento.Items.Add(row["nombre"].ToString());
            }

            dt= conn.consultaGeneralPuesto();

            foreach (DataRow row in dt.Rows)
            {
                cmbPuesto.Items.Add(row["nombre"].ToString());
            }
        }
    }
}
