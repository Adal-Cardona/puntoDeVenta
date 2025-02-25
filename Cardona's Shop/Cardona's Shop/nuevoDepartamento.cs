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
    public partial class nuevoDepartamento : Form
    {
        public nuevoDepartamento(string id)
        {
            InitializeComponent();
            txtID.Text = id;
        }
        conexion conn = new conexion();
        DataTable dt = new DataTable();
        private void nuevoDepartamento_Load(object sender, EventArgs e)
        {
            dt= conn.consultaGeneralDepartamentos();
            dgvDepartamentos.DataSource = dt;
            txtNuevoDepa.Focus();
            dt = conn.consultaGeneralEmpleados();
            foreach (DataRow row in dt.Rows)
            {
                cmbIdGerente.Items.Add(row["id"].ToString());
            }
        }

       
        private void txtNuevoDepa_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoDepa.TextLength>0)
            {
                dt = conn.consultaGeneralDepartamentoPorNombre(txtNuevoDepa.Text);
                dgvDepartamentos.DataSource = dt;
            }
            else
            {
                dt=conn.consultaGeneralDepartamentos();
                dgvDepartamentos.DataSource = dt;
            }
        }

        private void btnNuevoDepa_Click_1(object sender, EventArgs e)
        {
            if (txtNuevoDepa.Text == "" || txtSiglas.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (conn.insertarNuevoDepa(txtNuevoDepa.Text, txtSiglas.Text, Convert.ToInt32(cmbIdGerente.Text)))
                {
                    txtNuevoDepa.Text="";
                    txtSiglas.Text="";
                    cmbIdGerente.Text="";
                    txtNuevoDepa.Focus();
                    dt=conn.consultaGeneralDepartamentos();
                    dgvDepartamentos.DataSource = dt;
                }
            }
        }

        private void dgvDepartamentos_DoubleClick(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas Seguro de eliminar este departamento?", "Eliminar departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.Yes)
            {
                if (conn.borrarDepartamento(dgvDepartamentos.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Departamento eliminado con exito", "Departamento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt=conn.consultaGeneralDepartamentos();
                    dgvDepartamentos.DataSource = dt;
                }
            }


        }
    }
}
