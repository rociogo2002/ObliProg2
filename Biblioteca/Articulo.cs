using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ObliProgramacion
{
    public class Articulo
    {
        private int _contador =1;
        private int _id;
        private string _nombre;
        private string _categoria;
        private decimal _precio;

        public int Contador
        {
            get { return _contador; }
            set { _contador = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }


        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }

        }

        public Articulo(string nombre, string categoria, decimal precio)
        {
           
            Id = Contador++;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }


        public Articulo()
        {
            
            Id = Contador++;
            Nombre = "";
            Categoria = "";
            Precio = 0;
        }


        public override string ToString()
        {
            string articulo = $"Nombre: {this.Nombre} Categoria : {this.Categoria} Precio: {this.Precio}";
            return articulo;

        }


        //Validaciones para articulos 
        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new Exception("el nombre no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(Categoria))
            {
                throw new Exception("la categoria no puede estar vacia");
            }
            if(this.Precio <= 0)
            {
                throw new Exception("el precio no puede ser negativo");
            }
        }
    }
}


