using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObliProgramacion
{
    public class Subasta : Publicacion
    {
        private int _id;
        private int _contador = 1;
        private List<Articulo> articulos;
        private List<Oferta> _oferta = new List<Oferta>();         
       
        public List<Oferta> Oferta
        {
            get { return _oferta; }     
            set { _oferta = value; }    
        }




        public Subasta(string nombrePublicacion, Estado estado,
             DateTime fechaPublicacion, Cliente  usuarioComprador, Administrador administradorFinalizador,DateTime fechaFinalizacion, List<Articulo> articulos  , List<Oferta> oferta ) : base(  nombrePublicacion, estado,
             fechaPublicacion, usuarioComprador, administradorFinalizador, fechaFinalizacion , articulos)
        {


             this._id = _contador++;
            this.NombrePublicacion = nombrePublicacion;
            this.Estado = estado;
            this.FechaPublicacion = fechaPublicacion;
            this.ClienteComprador = usuarioComprador;
            this.AdministradorFinalizador = administradorFinalizador;
            this.FechaFinalizacion = fechaFinalizacion;
            this.articulos = articulos;
            this.Oferta = oferta;


        }

        public Subasta()
        {
            this._id = 0;
            this.NombrePublicacion = "";
            this.Estado = Estado.ABIERTA;
            this.FechaPublicacion = DateTime.Today;
            this.ClienteComprador = new Cliente();
            this.AdministradorFinalizador = new Administrador();
            this.FechaFinalizacion = DateTime.Today;
            this.Oferta = new List<Oferta>();


        }

        public override string ToString()
             
        {
            string OfertaStr = string.Join(", ", Oferta);
            return $" Id : {this._id} Nombre : {this.NombrePublicacion}  Estado : {this.Estado} Fecha Publicacion : {this.FechaPublicacion} Lista de ofertas: {OfertaStr} ";
        }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(NombrePublicacion))
            {
                throw new Exception("el nombre no puede estar vacio");
            }
            
        }
    }
}
