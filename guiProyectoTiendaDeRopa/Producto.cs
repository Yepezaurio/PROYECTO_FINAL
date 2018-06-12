using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiProyectoTiendaDeRopa
{
    class Producto
    {
        public string Clave { get; set; }
        public Boolean boxHombre { get; set; }
        public Boolean boxMujer { get; set; }
        public string cbCategoria { get; set; }
        public decimal numericCantidad { get; set; }
        public string cbTalla { get; set; }
        public string cbMarca { get; set; }
        public string Color { get; set; }
        public string cbMaterial { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {

        }
        public Producto(string pClave, Boolean pboxHombre, Boolean pboxMujer, string pcbCategoria 
         , decimal pnumericCantidad, string pcbTalla, string pcbMarca,
            string pColor, string pcbMaterial, decimal pPrecio)
        {
            this.Clave = pClave;
            this.boxHombre = pboxHombre;
            this.boxMujer = pboxMujer;
            this.cbCategoria = pcbCategoria;
            this.numericCantidad = pnumericCantidad;
            this.cbTalla = pcbTalla;
            this.cbMarca = pcbMarca;
            this.Color = pColor;
            this.cbMaterial = pcbMaterial;
            this.Precio = pPrecio;
        }
    }
}
