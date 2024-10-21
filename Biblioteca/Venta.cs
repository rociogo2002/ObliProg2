using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObliProgramacion
{
    public class Venta: Publicacion
    {
        private bool _ofertaRelampago;
       // private List<Articulo> articulos;
        private int _id;
        private int _contador = 1;



        public bool OfertaRelampago
        {
            get { return _ofertaRelampago; }  
            set { _ofertaRelampago = value; } 
        }


      

        //public List<Articulo> GetArticulos()
        //{
        //    return articulos;
        //}

        //public void SetArticulos(List<Articulo> articulos)
        //{
        //    this.articulos = articulos;
        //}

       



        public Venta(string nombrePublicacion, Estado estado,
             DateTime fechaPublicacion, Cliente usuarioComprador, Administrador administradorFinalizador, DateTime fechaFinalizacion, bool ofertaRelampago, List<Articulo> articulos) : base(nombrePublicacion, estado,
             fechaPublicacion, usuarioComprador, administradorFinalizador, fechaFinalizacion, articulos)
        {


            this._id = _contador++;
            this.NombrePublicacion = nombrePublicacion;
            this.Estado = estado;
            this.FechaPublicacion = fechaPublicacion;
            this.ClienteComprador = usuarioComprador;
            this.AdministradorFinalizador = administradorFinalizador;
            this.FechaFinalizacion = fechaFinalizacion;
            this.OfertaRelampago = ofertaRelampago;
            this.Articulos = articulos;


        }

        public Venta()
        {
            this._id = 0;
            this.NombrePublicacion = "";
            this.Estado = Estado.ABIERTA;
            this.FechaPublicacion = DateTime.Today;
            this.ClienteComprador = new Cliente();
            this.AdministradorFinalizador = new Administrador();
            this.FechaFinalizacion = DateTime.Today;
        }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(NombrePublicacion))
            {
                throw new Exception("el nombre no puede estar vacio");
            }
           
        }

        public override string ToString()
        {

            return $" Id : {this._id} Nombre : {this.NombrePublicacion}  Estado : {this.Estado} Fecha Publicacion : {this.FechaPublicacion}  ";

        }







    }

}
