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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.RFC = textRFC.Text.Trim();
            pCliente.Nombre = textNombre.Text.Trim();
            pCliente.Apellido_Paterno = textApellidoPaterno.Text.Trim();
            pCliente.Apellido_Materno = textApellidoMaterno.Text.Trim();
            pCliente.Municipio = textMunicipio.Text.Trim();
            pCliente.Numero_de_telefono = textNumerodeTelefono.Text.Trim();
            pCliente.Codigo_Postal = textCodigoPostal.Text.Trim();
            pCliente.Colonia = textColonia.Text.Trim();
            pCliente.Calle = textCalle.Text.Trim();
            int comparacion = AgregarDatos.AgregarCliente(pCliente);
            if (comparacion > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textRFC.Clear();
                textNombre.Clear();
                textApellidoPaterno.Clear();
                textApellidoMaterno.Clear();
                textMunicipio.Clear();
                textNumerodeTelefono.Clear();
                textCodigoPostal.Clear();
                textColonia.Clear();
                textCalle.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void textRFC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
