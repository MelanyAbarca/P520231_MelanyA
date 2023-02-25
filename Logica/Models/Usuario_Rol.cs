using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica.Models
{
    public class Usuario_Rol
    {
        // Primero se digitan las propiedades de la clase

        public int usuarioRolID { get; set; }

        //private int usuarioRolID;
        //public int UsuarioRolID
        //{
        //    get { return usuarioRolID; }
        //    set { usuarioRolID = value; }
        //}

        public string UsuarioRolDescripcion { get; set;}

        // Luego escribir las propiedades simples se digitan
        // Las propiedades compuestas (En este caso no hay)

        //Por ultimo se escriben las funciones y metodos.

        public DataTable Listar()
        { 
         
          DataTable R = new DataTable();

            // Aqui va la programacion indicada en el diagrama de secuencias.
          
            return R;
        
        }


    }
}
