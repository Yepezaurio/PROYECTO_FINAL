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
    public partial class CrearProducto : Form
    {
        Boolean Pasar;
        public CrearProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto pProducto = new Producto();
            pProducto.Clave = textClave.Text.Trim();

            if ( Pasar == true)
            {
                pProducto.boxHombre = false;
                pProducto.boxMujer = true;
                pProducto.cbCategoria = cbCategoriaMujer.Text.Trim();
            }
            else
            {
                pProducto.boxHombre = true;
                pProducto.boxMujer = false;
                pProducto.cbCategoria = cbCategoriaHombre.Text.Trim();
            }
            pProducto.numericCantidad = numericCantidad.Value;
            pProducto.cbTalla = cbTalla.Text.Trim();
            pProducto.cbMarca = cbMarca.Text.Trim();
            pProducto.Color = textColor.Text.Trim();
            pProducto.cbMaterial = cbMaterial.Text.Trim();
            pProducto.Precio = numericPrecio.Value;
            int comparacion = AgregarDatos.AgregarProducto(pProducto);
            if (comparacion > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkHombre_CheckedChanged(object sender, EventArgs e)
        {
            
            cbCategoriaMujer.Hide();
            cbCategoriaHombre.Visible = true;
            Pasar = false;
            
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {
            cbCategoriaMujer.Hide();
            
        }

        private void cbCategoriaMujer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkMujer_CheckedChanged(object sender, EventArgs e)
        {
            
            cbCategoriaHombre.Hide();
            cbCategoriaMujer.Visible = true;
            Pasar = true;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void boxHombre_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoriaMujer.Hide();
            cbCategoriaHombre.Visible = true; ;
            
        }

        private void boxMujer_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoriaHombre.Hide();
            cbCategoriaMujer.Visible = true;
        }
    }
}
