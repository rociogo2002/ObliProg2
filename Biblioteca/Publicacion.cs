using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{


    public class Publicacion
    {
        //  Atributos
        private static  int _contador = 1;
        private int _id;
        private string _nombrePublicacion;
        private Estado _estado;
        private DateTime _fechaPublicacion;
        private Cliente _clienteComprador;
        private Administrador _administradorFinalizador;
        private DateTime _fechaFinalizacion;
        private List<Articulo> _articulos;





        public string NombrePublicacion
        {
            get { return _nombrePublicacion; }
            set { _nombrePublicacion = value; }
        }


        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }

        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }

        }


        public Cliente ClienteComprador
        {
            get{ return _clienteComprador;  }
            set { _clienteComprador = value; }
}

        public Administrador AdministradorFinalizador
        {
            set {  _administradorFinalizador = value; }
            get { return _administradorFinalizador; }

        }

        public DateTime FechaFinalizacion
        {

            set { _fechaFinalizacion = value; }
            get { return _fechaFinalizacion; }

        }

        public List<Articulo> Articulos
        {
            get { return _articulos; }
            set { _articulos = value; }
        }

        public Publicacion( string nombrePublicacion, Estado estado, 
            DateTime fechaPublicacion , Cliente usuarioComprador, Administrador administradorFinalizador, DateTime fechaFinalizacion , List<Articulo> articulos  )
        {
            this._id = _contador++;
            this.NombrePublicacion = nombrePublicacion;
            this.Estado = estado;
            this.FechaPublicacion = fechaPublicacion;
            this.ClienteComprador = usuarioComprador;
            this.AdministradorFinalizador = administradorFinalizador;
            this.FechaFinalizacion = fechaFinalizacion;
            this.Articulos = articulos;


        }

        public Publicacion()
        {

            this._id = 0;
            this.NombrePublicacion = "";
            this.Estado = Estado.ABIERTA;
            this.FechaPublicacion = DateTime.Today;
            this.ClienteComprador = new Cliente();
            this.AdministradorFinalizador = new Administrador () ;
            this.FechaFinalizacion = DateTime.Today;
            this.Articulos = new List<Articulo>();
      
        }





        public override string ToString()
        {
           string articulosStr = string.Join(", ", Articulos);

            return $"Publicación: {NombrePublicacion}, Estado: {Estado}, Fecha: {FechaPublicacion}, Artículos: {articulosStr}";

        }



    }
}