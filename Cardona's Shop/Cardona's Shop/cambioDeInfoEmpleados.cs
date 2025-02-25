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
    public partial class cambioDeInfoEmpleados : Form
    {
        public cambioDeInfoEmpleados(string id)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            try
            {
            dt = conn.consultaGeneralEmpleadosPorID(Convert.ToInt32(cmbIDEmpleado.Text));
            
            dt2 = conn.consultaGeneralDepartamentos();

            
            dt3 = conn.consultaGeneralPuesto();
            
                txtPNombre.Text = dt.Rows[0][1].ToString();
                txtSNombre.Text = dt.Rows[0][2].ToString();
                txtPApellido.Text = dt.Rows[0][3].ToString();
                txtSApellido.Text = dt.Rows[0][4].ToString();
                txtEdad.Text = dt.Rows[0][7].ToString();
                txtRFC.Text = dt.Rows[0][8].ToString();
                foreach(DataRow row in dt2.Rows)
                {
                    if (dt.Rows[0][5].ToString() == row["id"].ToString())
                    {
                        cmbDepartamento.Text = row["nombre"].ToString();
                    }
                }

                foreach (DataRow row in dt3.Rows)
                {
                    if (dt.Rows[0][6].ToString() == row["id"].ToString())
                    {
                        cmbPuesto.Text = row["nombre"].ToString();
                    }
                }
                cmbActivo.Text = dt.Rows[0][9].ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataRow row in dt2.Rows)
            {
               cmbDepartamento.Items.Add(row["nombre"].ToString());
  
            }

            foreach (DataRow row in dt3.Rows)
            {
                cmbPuesto.Items.Add(row["nombre"].ToString());

            }



            cmbActivo.Items.Add("0");
            cmbActivo.Items.Add("1");
        }

        private void cambioDeInfoEmpleados_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();

            dt = conn.consultaGeneralEmpleados();

            foreach (DataRow row in dt.Rows)
            {
                cmbIDEmpleado.Items.Add(row["id"].ToString());
            }
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            try
            {
                DataTable dt = new DataTable();
                dt = conn.consultaGeneralPuestoPorNombre(cmbPuesto.Text);
                if(conn.actualizarDatosEmpleado(Convert.ToInt32(cmbIDEmpleado.Text), txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, cmbDepartamento.Text, Convert.ToInt32(dt.Rows[0][0].ToString()), Convert.ToInt32(txtEdad.Text), txtRFC.Text, Convert.ToInt32(cmbActivo.Text))){
                    MessageBox.Show($"Datos del empleado con id {cmbIDEmpleado.Text} actualizado");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Codigo para cambio
    }
}
