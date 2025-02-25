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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir();
            
        }
        private void abrir()
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Focus();
                usuario.Text = "Por favor, llena el usuario";
            }
            else if (txtContraseña.Text =="")
            {
                txtContraseña.Focus();
                contra.Text = "Por favor, llena la contraseña";
            }
            else
            {
                conexion conn = new conexion();
                DataTable dt = new DataTable();
                dt = conn.consultaGeneralInicioSesion();
                bool encuentro = false;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["id_empleado"].ToString() == txtUsuario.Text && dr["contraseña"].ToString() == txtContraseña.Text)
                    {
                        encuentro = true;   
                        string user = txtUsuario.Text;
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    }
                   
                }

                if (encuentro)
                {
                    MessageBox.Show("Bienvenido a Cardona's Shop", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Inicio de Sesion fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                abrir();
            }
        }
    }
}
