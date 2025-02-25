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
    public partial class cambioGerencia : Form
    {
        public cambioGerencia(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado.ToString();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            
            if (cmbDepartamento.Text == "" || cmbIDGerente.Text == "")
            {
                MessageBox.Show("Llena todos los campos solicitados");
            }
            else
            {
                try
                {
                    conexion conn = new conexion();
                    if (conn.actualizarGerente(cmbDepartamento.Text, Convert.ToInt32(cmbIDGerente.Text))){
                        MessageBox.Show("Gerente Actualizado");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cambioGerencia_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            dt = conn.consultaGeneralDepartamentos();
            foreach (DataRow row in dt.Rows)
            {
                cmbDepartamento.Items.Add(row["siglasDepartamento"].ToString());
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt = conn.consultaGeneralEmpleados();
            foreach (DataRow row in dt.Rows)
            {
                cmbIDGerente.Items.Add(row["id"].ToString());
            }
            
            
        }
    }
}
