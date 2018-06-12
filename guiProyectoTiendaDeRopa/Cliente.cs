using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiProyectoTiendaDeRopa
{
    class Cliente
    {
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Municipio { get; set; }
        public string Numero_de_telefono { get; set; }
        public string Codigo_Postal { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }

        public Cliente()
        {

        }
        public Cliente(string pRFC, string pNombre, string pApellido_Paterno, string pApellido_Materno,
            string pMunicipio, string pNumero_de_telefono, string pCodigo_Postal, string pColonia, string pCalle)
        {
            this.RFC = pRFC;
            this.Nombre = pNombre;
            this.Apellido_Paterno = pApellido_Paterno;
            this.Apellido_Materno = pApellido_Materno;
            this.Municipio = pMunicipio;
            this.Numero_de_telefono = pNumero_de_telefono;
            this.Codigo_Postal = pCodigo_Postal;
            this.Colonia = pColonia;
            this.Calle = pCalle;
        }
    }
}
