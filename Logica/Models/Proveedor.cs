using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        // Propiedades simples
        public int UsuarioID { get; set; }
        public string ProveedorNombre { get; set; }

        public string ProveedorCedula { get; set; }

        public string ProveedorEmail { get; set; }

        public string ProveedorDireccion { get; set; }

        public string ProveedorNotas { get; set; }

        public bool Activo { get; set; }

        TipoProveedor MiTipoProveedor { get; set; }

        // Propiedades Compuestas

        public Proveedor()
        {

            MiTipoProveedor = new TipoProveedor();
        }


        // Funciones y Metodos
        public bool Agregar()
        {
            bool R = false;
            return R;
        }

        public bool Editar()
        {
            bool R = false;
            return R;

        }

        public bool Eliminar()
        {
            bool R = false;
            return R;

        }

        public bool ConsultarPorCedula()
        {
            bool R = false;
            return R;

        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            return R;

        }
        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();
            return R;
        }




    }
}
