using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{
    public class Usuario
    {
        //Atributos
        private static int _contador = 1;
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _contrasenia;


        //Propiedades
        public int ID
        {
            get { return _id; }
            set { _id = value; }

        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }


        //Constructor
        public Usuario( string nombre, string apellido, string email, string contrasena)
        {
            this.ID = _contador++;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Contrasenia = contrasena;
        }

        public Usuario()
        {
            Nombre = "";
            Apellido = "";
            Email = "";
            Contrasenia = "";
        }



        public override string ToString()
        {

            return " ID: " + ID + " Nombre: " + Nombre + " Apellido: " + Apellido;
        }


    }
}
