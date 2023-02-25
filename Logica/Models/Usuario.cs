using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {       
        // Propiedades simples
        public int UsuarioID { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioContrasennia { get;set; }
        public string UsuarioNombre { get;set; }

        public string UsuarioCedula { get; set; }

        public string UsuarioTelefono { get; set; }

        public string UsuarioDireccion { get;set; }

        public bool Activo { get; set; }    


        // Propiedades Compuestas

        Usuario_Rol MiRolTipo { get; set; }

        // Normalmente cuando tenemos propiedades compuestas con tipos que hemos programado, 
        // nosotros debemos instanciar dichas propiedades ya que son objetos. Para eso se recomienda
        //hacerlo en el constructor de la clase

        //Para hacerlo se debe escribir cto tab
        public Usuario()
        {
            //Al crear una nueva instancia de la clase Usuario, se ejecuta el codigo de este
            // constructor, y tambien se crea una nueva instancia de la clase usuario_rol para
            // el objeto MiRolTipo

            MiRolTipo = new Usuario_Rol();
        }



        // Funciones y Metodos
        public bool Agregar() {

            // Cuando la funcion devuelve un bool me gusta inicializar la variable de retorno
            //en false(tiende a negativo el resultado de la fn) y SOLO si la operacion 
            // (en este caso insert) se cambia el valor R a true

            bool R = false;

            // Aca va el codigo funcional que invoca a un  procedimiento almacenado que contiene
            // el DML Insert

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
        public bool ConsultarPorID()
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

        public DataTable ListarActivos()
        {
            DataTable  R = new DataTable();
            return R;
        }

        public DataTable ListarInActivos()
        {
            DataTable R = new DataTable();
            return R;
        }

        public Usuario Validar(String pEmail, String pContrasennia)
        {
            Usuario R = new Usuario();
            return R;
        }









    }
    }
