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
    public partial class Form1 : Form
    {
        public string idEmpleado;
        public Form1()
        {
            InitializeComponent();
            timer.Start();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateTime.Visible = false;
            menuStrip1.Visible = false;
            Bienvenida bienvenida = new Bienvenida();
            DialogResult respuesta = bienvenida.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                idEmpleado = bienvenida.txtUsuario.Text;
            }
            
            menuStrip1.Visible = true;
            lblDateTime.Visible = true;
            
        }
        

        //Pantalla Ventas
        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ventas ventas = new ventas(idEmpleado);

            ventas.Show();
            ventas.MdiParent = this;
            ventas.WindowState = FormWindowState.Maximized;
        }

        //Pantalla Entradas de Inventario

        private void eNTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            entradas entradas = new entradas(idEmpleado);
            entradas.Show();
            entradas.MdiParent = this;
            entradas.WindowState = FormWindowState.Maximized;
        }

        private void rEVISARSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            revisarStock revisarStock = new revisarStock();
            revisarStock.Show();
            revisarStock.MdiParent = this;
            revisarStock.WindowState = FormWindowState.Maximized;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            nuevoProducto nuevoProducto = new nuevoProducto(idEmpleado);
            nuevoProducto.Show();
            nuevoProducto.MdiParent = this;
            nuevoProducto.WindowState = FormWindowState.Maximized;
        }

        private void cAMBIARINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            cambiarInfoProducto cambiarInfoProducto = new cambiarInfoProducto(idEmpleado);
            cambiarInfoProducto.Show();
            cambiarInfoProducto.MdiParent = this;
            cambiarInfoProducto.WindowState = FormWindowState.Maximized;
        }

        private void nUEVOSEMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            nuevoEmpleado nuevoEmpleado = new nuevoEmpleado(idEmpleado);
            nuevoEmpleado.Show();
            nuevoEmpleado.MdiParent = this;
            nuevoEmpleado.WindowState = FormWindowState.Maximized;
        }

        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            verInfoEmpleados verInfoEmpleados = new verInfoEmpleados();
            verInfoEmpleados.Show();
            verInfoEmpleados.MdiParent = this;
            verInfoEmpleados.WindowState = FormWindowState.Maximized;

        }


        private void cAMBIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            cambioDeInfoEmpleados camb1 = new cambioDeInfoEmpleados(idEmpleado);
            camb1.Show();
            camb1.MdiParent = this;
            camb1.WindowState = FormWindowState.Maximized;
        }
        
         private void gERENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            cambioGerencia cambioGerencia = new cambioGerencia(idEmpleado);
            cambioGerencia.Show();
            cambioGerencia.MdiParent = this;
            cambioGerencia.WindowState = FormWindowState.Maximized;
        }
       
        private void nUEVOSPUESTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            nuevosPuestos nuevosPuestos = new nuevosPuestos(idEmpleado);
            nuevosPuestos.Show();
            nuevosPuestos.MdiParent = this;
            nuevosPuestos.WindowState = FormWindowState.Normal;
            nuevosPuestos.WindowState = FormWindowState.Maximized;
        }

       
        private void nUEVOSDEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            nuevoDepartamento nuevoDepartamento = new nuevoDepartamento(idEmpleado);
            nuevoDepartamento.Show();
            nuevoDepartamento.MdiParent = this;
            nuevoDepartamento.WindowState = FormWindowState.Maximized;
        }
         private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public void cerrarVentanas()
        {
            foreach (Form f1 in this.MdiChildren)
            {
                f1.Close();
            }
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            lblDateTime.Visible = false;
            menuStrip1.Visible = false;
            Bienvenida bienvenida = new Bienvenida();
            DialogResult respuesta = bienvenida.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                idEmpleado = bienvenida.txtUsuario.Text;
            }

            menuStrip1.Visible = true;
            lblDateTime.Visible = true;
        }
    }
}
