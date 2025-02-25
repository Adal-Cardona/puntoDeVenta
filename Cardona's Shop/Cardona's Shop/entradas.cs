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
    public partial class entradas : Form
    {
        public entradas(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado;
            txtCodigo.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.TextLength == 13)
            {
                txtCantidad.Focus();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresarLista();
        }

        private void ingresarLista()
        {
            bool encontrado = false;
            try
            {
                foreach (ListViewItem item in lstEntradaInventarios.Items)
                {
                    if (item.Text == txtCodigo.Text)
                    {
                        int cantidad;
                        cantidad = Convert.ToInt32(item.SubItems[2].Text);
                        cantidad += Convert.ToInt32(txtCantidad.Text);

                        item.SubItems[2].Text = cantidad.ToString();

                        encontrado = true;
                        break;
                    }
                }
                conexion conn = new conexion();

                if (!encontrado)
                {
                    DataTable dt = new DataTable();
                    dt = conn.consultarProducto(Convert.ToInt64(txtCodigo.Text));

                    ListViewItem lista = new ListViewItem(dt.Rows[0][1].ToString());
                    lista.SubItems.Add(dt.Rows[0][2].ToString());
                    lista.SubItems.Add(txtCantidad.Text);
                    lstEntradaInventarios.Items.Add(lista);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtCodigo.Text = "";
            txtCantidad.Text = "1";
            txtCodigo.Focus();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            try
            {
                if (conn.EntradaInventario(Convert.ToInt32(txtID.Text)))
                {
                    
                    int cantidad;
                    Int64 codigoBarras;
                    int id = Convert.ToInt32(txtID.Text);
                    foreach (ListViewItem item in lstEntradaInventarios.Items)
                    {
                        codigoBarras = Convert.ToInt64(item.Text);
                        cantidad = Convert.ToInt32(item.SubItems[2].Text); 

                        conn.infoEntradaInventario(id, codigoBarras, cantidad);
                        
                    }

                    lstEntradaInventarios.Items.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresarLista();
            }
        }

        private void lstEntradaInventarios_DoubleClick(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("Estas seguro que deseas borrar este articulo", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (aviso == DialogResult.Yes)
            {
                lstEntradaInventarios.SelectedItems[0].Remove();
            }
        }
    }
}
