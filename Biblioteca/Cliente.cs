using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{
    public class Cliente : Usuario

    {
        // atributos adicionales de cliente
        private int _saldoBilletera;

        // Atributos
       

        //Propiedades 

        public int SaldoBilletera
        {
            get { return _saldoBilletera; }
            set { _saldoBilletera = value; }
        }


        // constructor 



        public Cliente( string nombre, string apellido, string email, string contrasena, int saldoBilletera)
         : base( nombre, apellido, email, contrasena) // Llamada al constructor base usuario
        {
            //this.ID = _contador++;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Contrasenia = contrasena;
            this.SaldoBilletera = saldoBilletera;
        }

        public Cliente()
        {
            this.Nombre = "Cliente ";
            this.Apellido = "por defecto";
            this.Email = "na@na";
            this.Contrasenia = "123";
            this.SaldoBilletera = 100;

        }



        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new Exception("el nombre no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(Apellido))
            {
                throw new Exception("el apellido no puede estar vacia");
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new Exception("el email no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(Contrasenia))
            {
                throw new Exception("la contrasenia no puede estar vacia");

            }
            if (this.SaldoBilletera <= 0)
            {
                throw new Exception("el saldo no puede ser negativo");
            }
        }

        
        // public string ToString()
        //{
        //    return "Saldo Billetera: " + SaldoBilletera;

        // }
    }
}
