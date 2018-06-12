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
    public partial class CrearProveedor : Form
    {
        public CrearProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textRFC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CrearProveedor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor pProveedor = new Proveedor();
            pProveedor.RFC = textRFC.Text.Trim();
            pProveedor.Nombre = textNombre.Text.Trim();
            pProveedor.Apellido_Paterno = textApellidoPaterno.Text.Trim();
            pProveedor.Apellido_Materno = textApellidoMaterno.Text.Trim();
            pProveedor.Calle = textCalle.Text.Trim();
            pProveedor.Colonia = textColonia.Text.Trim();
            pProveedor.Municipio = textMunicipio.Text.Trim();
            pProveedor.CodigoPostal = textCodigoPostal.Text.Trim();
            pProveedor.NumerodeTelefono = textNumerodeTelefono.Text.Trim();

            int Comparacion = AgregarDatos.AgregarProveedor(pProveedor);
            if (Comparacion > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textRFC.Clear();
                textNombre.Clear();
                textApellidoPaterno.Clear();
                textApellidoMaterno.Clear();
                textCalle.Clear();
                textColonia.Clear();
                textMunicipio.Clear();
                textCodigoPostal.Clear();
                textNumerodeTelefono.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
