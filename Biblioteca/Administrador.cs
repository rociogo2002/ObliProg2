using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{

       public class Administrador: Usuario

       {




        public Administrador(string nombre, string apellido, string email, string contrasena)
        : base(nombre, apellido, email, contrasena) // Llamada al constructor base
        {
           
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contrasena;

        }




        public Administrador()
        {
            Nombre = "";
            Apellido = "";
            Email = "";
            Contrasenia = "";
        }

        public override string ToString()
        {

            return "Nombre: " + Nombre + " Apellido: " + Apellido + " ID:" + ID;
        }

    }
}
