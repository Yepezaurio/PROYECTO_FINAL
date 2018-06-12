using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiProyectoTiendaDeRopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form crear = new Clientes();
            crear.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Compras = new Compras();
            Compras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form CrearProveedor = new CrearProveedor();
            CrearProveedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form AgregarProducto = new CrearProducto();
            AgregarProducto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form DevCliente = new DevolucionesClientes();
            DevCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form DevProveedor = new DevolucionesProveedores();
            DevProveedor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form cliente = new Ventas();
            cliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form mostrarCliente = new MostrarClientes();
            mostrarCliente.Show();
        }
    }
}
