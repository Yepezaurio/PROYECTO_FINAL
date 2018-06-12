using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace guiProyectoTiendaDeRopa
{
    class AgregarDatos
    {
       
        public static int AgregarCliente(Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente" +
                "(rfc_cl, nombres_cl, Apellido_Paterno_cl, Apellido_Materno_cl, calle, colonia, municipio, Numero_Telefono, Codigo_Postal) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                pCliente.RFC, pCliente.Nombre, pCliente.Apellido_Paterno, pCliente.Apellido_Materno, pCliente.Calle, pCliente.Colonia, pCliente.Municipio, pCliente.Numero_de_telefono, pCliente.Codigo_Postal),
                ConexionBD.Conectarbd());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        
        public static int AgregarProveedor(Proveedor pProveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into proveedores" +
                "(rfc_p, Nombre, Apellido_Paterno_P, Apellido_Materno_P, Calle_P, Colonia_P, municipio_P, codigo_postal_P, Num_telefono_P) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
               pProveedor.RFC, pProveedor.Nombre, pProveedor.Apellido_Paterno, pProveedor.Apellido_Paterno,pProveedor.Calle, pProveedor.Colonia, pProveedor.Municipio,pProveedor.CodigoPostal,pProveedor.NumerodeTelefono),
                ConexionBD.Conectarbd());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int AgregarProducto( Producto pProducto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into productos" +
                "(clave,Tipo_Hombre,Tipo_Mujer,Categoria,Existencia,Talla,Marca, Color, Precio, Material) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                pProducto.Clave, pProducto.boxHombre, pProducto.boxMujer, pProducto.cbCategoria, pProducto.numericCantidad,pProducto.cbTalla, pProducto.cbMarca, pProducto.Color, pProducto.Precio, pProducto.cbMaterial),
                ConexionBD.Conectarbd());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }

}
