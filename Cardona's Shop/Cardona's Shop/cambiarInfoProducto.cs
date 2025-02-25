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
    public partial class cambiarInfoProducto : Form
    {
        public cambiarInfoProducto(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado;
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCodigo.Checked == true)
            {
                txtCodigo.Focus();
            }else if (rbNombre.Checked == true)
            {
                cmbNombre.Focus();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.TextLength == 13)
            {
                conexion conn = new conexion();
                DataTable dt = new DataTable();
                dt = conn.consultaGeneralInventarioPorCodigo(Convert.ToInt64(txtCodigo.Text));
                DataTable dt2 = new DataTable();
                dt2 = conn.consultaGeneralDepartamentos();
                try {
                    cmbNombre.Text = dt.Rows[0][1].ToString();
                    txtPrecio.Text = dt.Rows[0][2].ToString();
                    foreach (DataRow row in dt2.Rows)
                    {
                        if (dt.Rows[0][4].ToString() == row["siglasDepartamento"].ToString())
                        {
                            cmbCategoria.Text = row["nombre"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void Buscar()
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt = conn.consultaGeneralInventarioPorNombre(cmbNombre.Text);
            DataTable dt2 = new DataTable();
            dt2 = conn.consultaGeneralDepartamentos();

            try
            {
                txtCodigo.Text = dt.Rows[0][0].ToString();
                txtPrecio.Text = dt.Rows[0][2].ToString();
                foreach (DataRow row in dt2.Rows)
                {
                    if (dt.Rows[0][4].ToString() == row["siglasDepartamento"].ToString())
                    {
                        cmbCategoria.Text = row["nombre"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {   
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt = conn.consultaGeneralDepartamentos();
            string siglas = "";
            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre"].ToString() == cmbCategoria.Text)
                {
                    siglas = row["siglasDepartamento"].ToString();
                    break;
                }
            }
            
            if (rbCodigo.Checked == true)
            {
                if (conn.cambiarInformacionProductoPorID(Convert.ToInt64(txtCodigo.Text), cmbNombre.Text, Convert.ToInt32(txtPrecio.Text), siglas))
                {
                    txtCodigo.Text="";
                    cmbNombre.Text = "";
                    txtPrecio.Text = "";
                    cmbCategoria.Text = "";
                }
            }
            else if (rbNombre.Checked == true)
            {
                if (conn.cambiarInformacionProductoPorNombre(Convert.ToInt64(txtCodigo.Text), cmbNombre.Text, Convert.ToInt32(txtPrecio.Text), siglas))
                {
                    txtCodigo.Text="";
                    cmbNombre.Text = "";
                    txtPrecio.Text = "";
                    cmbCategoria.Text = "";
                }
            }
        }

        private void cmbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void cambiarInfoProducto_Load(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DataTable dt = new DataTable();
            dt= conn.consultaGeneralInventario();

            foreach (DataRow row in dt.Rows)
            {
                cmbNombre.Items.Add(row["nombre"].ToString());
            }
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbNombre_TextChanged(object sender, EventArgs e)
        {
            //cmbNombre.Items.Clear();
            //conexion conn = new conexion();
            //DataTable dt = new DataTable();
            //dt= conn.consultaGeneralInventarioPorNombre(cmbNombre.Text);

            //foreach (DataRow row in dt.Rows)
            //{
            //    cmbNombre.Items.Add(row["nombre"].ToString());
            //}
        }
    }
}
