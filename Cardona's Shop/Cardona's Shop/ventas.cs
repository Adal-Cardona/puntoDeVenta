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
    public partial class ventas : Form
    {
        public ventas(string idEmpleado)
        {
            InitializeComponent();
            txtID.Text = idEmpleado.ToString();
            txtCodigo.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength == 13)
            {

                conexion conn = new conexion();
                bool encontrado = false;
                try
                {
                    foreach (ListViewItem item in lvListaVenta.Items)
                    {
                        if (item.Text == txtCodigo.Text)
                        {
                            int cantidad;
                            double precioUnitario, subtotalAct;
                            cantidad = Convert.ToInt32(item.SubItems[2].Text);
                            cantidad += Convert.ToInt32(txtNum.Text);
                            precioUnitario = Convert.ToDouble(item.SubItems[3].Text);
                            subtotalAct = cantidad * precioUnitario;

                            item.SubItems[2].Text = cantidad.ToString();
                            item.SubItems[4].Text = subtotalAct.ToString();

                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        DataTable dt = new DataTable();
                        dt = conn.consultarProducto(Convert.ToInt64(txtCodigo.Text));

                        double subtotal = Convert.ToDouble(txtNum.Text) * Convert.ToDouble(dt.Rows[0][3].ToString());

                        ListViewItem lista = new ListViewItem(dt.Rows[0][1].ToString());
                        lista.SubItems.Add(dt.Rows[0][2].ToString());
                        lista.SubItems.Add(txtNum.Text);
                        lista.SubItems.Add(dt.Rows[0][3].ToString());
                        lista.SubItems.Add(subtotal.ToString());
                        lvListaVenta.Items.Add(lista);


                    }
                    double total = 0;

                    foreach (ListViewItem item in lvListaVenta.Items)
                    {
                        total += Convert.ToDouble(item.SubItems[4].Text);
                    }
                    txtTotal.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtNum.Text = "1";
                txtCodigo.Text = "";
                
                txtCodigo.Focus();
            }
        }

        private void ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            conexion conn = new conexion();
            DateTime fecha = new DateTime();
            fecha = DateTime.Now;
            try
            {
                if (conn.registroTicket(Convert.ToDouble(txtTotal.Text), fecha, Convert.ToInt32(txtID.Text)))
                {  
                    int cantidad;
                    double total;
                    Int64 codigoBarras;
                    foreach (ListViewItem item in lvListaVenta.Items)
                    {
                        codigoBarras = Convert.ToInt64(item.Text);
                        cantidad = Convert.ToInt32(item.SubItems[2].Text);
                        total = Convert.ToDouble(item.SubItems[4].Text);

                        conn.infoTicket(codigoBarras, cantidad, total);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                lvListaVenta.Items.Clear();
                txtTotal.Text="0";
                txtCambio.Text="0";
            txtCantidadR.Text = "0";
            rbEfectivo.Checked = false;
            rbTarjeta.Checked = false;
        }




        //Codigo para informe al cerrar caja
            


        //Efectivo o Tarjeta
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
                txtCantidadR.ReadOnly = false;
                txtCantidadR.Focus();
                txtCantidadR.Text = txtAPagar.Text;
        }

        private void txtCantidadR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                double cantidadR = Convert.ToDouble(txtCantidadR.Text);
                double aPagar = Convert.ToDouble(txtAPagar.Text);

                if (cantidadR > aPagar)
                {
                    if (rbTarjeta.Checked == true)
                    {
                        MessageBox.Show("Cantidad Recibida Mayor a la Cantidad a Pagar", "Pago excedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if(rbEfectivo.Checked == true)
                    {
                        double cambio = cantidadR-aPagar;
                        aPagar = 0;
                        txtCambio.Text = cambio.ToString();
                    }
                }
                else {
                    aPagar -= cantidadR; 
                }

                

                txtAPagar.Text = aPagar.ToString();

                if(aPagar > 0)
                {
                    txtCantidadR.Text = "0";
                    txtCantidadR.Focus();
                }else if(aPagar == 0)
                {
                    txtCantidadR.Text = "0";
                }
            }
        }

        private void lvListaVenta_DoubleClick(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("Estas seguro que deseas borrar este articulo", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (aviso == DialogResult.Yes)
            {
                double total = 0;
                lvListaVenta.SelectedItems[0].Remove();

                foreach (ListViewItem item in lvListaVenta.Items)
                {
                    total += Convert.ToDouble(item.SubItems[4].Text);
                }

                txtTotal.Text=total.ToString();


            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtAPagar.Text = txtTotal.Text;
        }

        private void txtCantidadR_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadR.TextLength > 0 && rbTarjeta.Checked && Convert.ToDouble(txtCantidadR.Text) > Convert.ToDouble(txtAPagar.Text)) {
                txtCantidadR.Text = txtAPagar.Text;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidadR.ReadOnly = false;
            txtCantidadR.Focus();
            txtCantidadR.Text = txtAPagar.Text;
        }
    }
}
