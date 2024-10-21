using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{
    public class Oferta
    {

        private int _id;
        private int contador = 1;
        private Usuario _usuario;
        private decimal _monto;
        private DateTime _fechaRealizacion;


        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }



            public decimal Monto 
        {   get { return _monto; } 
            
            set { _monto = value; } }



        public DateTime FechaRealizacion
        {
            get { return _fechaRealizacion; }
            set { _fechaRealizacion = value; }
        }



        public Oferta( Usuario usuario, decimal monto, DateTime fechaRealizacion )
        {
            this._id = contador++;
            this.Usuario = usuario;
            this.Monto = monto;
            this.FechaRealizacion = fechaRealizacion;

        }


        public Oferta()
        {
            this._id = 0 ;
            this.Usuario = new Usuario();
            this.Monto = 0;
            this.FechaRealizacion = DateTime.Today;


        }


    }
}
