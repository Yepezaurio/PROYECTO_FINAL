using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiProyectoTiendaDeRopa
{
    class Proveedor
    {
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string CodigoPostal { get; set; }
        public string NumerodeTelefono { get; set; }
      
        
       
        

        public Proveedor()
        {

        }
    
        public Proveedor(string pRFC, string pNombre, string pApellido_Paterno, 
            string pApellido_Materno,string pCalle, string pColonia, string pMunicipio, string pCodigoPostal, string pNumerodeTelefono)
        {
            this.RFC = pRFC;
            this.Nombre = pNombre;
            this.Apellido_Paterno = pApellido_Paterno;
            this.Apellido_Materno = pApellido_Materno;
            this.Calle = pCalle;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.CodigoPostal = pCodigoPostal;
            this.NumerodeTelefono = pNumerodeTelefono;
        }

    }
}
