using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Hotel : Alojamiento
    {
        private int estrellas;
        private int nHabitacion;
        public Hotel(string nombre,string direccion,int huesped,double costo,int estrellas,int nHab):base(nombre,direccion,huesped,costo)
        {
            this.estrellas = estrellas;
            this.nHabitacion = nHab;
            this.id = "H" + id;
        }

        public int Estrella
        {
            get { return estrellas; }
            set { estrellas = value; }
        }

        public int NHabitacion
        {
            get { return nHabitacion; }
            set
            {
                nHabitacion = value;
            }
        }

        public override double Precio
        {
            get { return PrecioXdia(); }
        }

        public override ETipo Tipo {
        get{return ETipo.HOTEL;}
        }

        public double PrecioXdia()
        {
            double precio = base.costo;
            if (Huesped==2)
            {
                precio = precio * 0.8 + precio;
            }
            else if (Huesped >= 3)
            {
                precio = precio * 1.5 + precio;
            }
            if (estrellas == 3)
            {
                precio = precio * 0.4 + precio;
            }
            return precio;
            //throw new Exception("Error al calcular precio");
        }

        public override string ToString()
        {
            return base.ToString() + ";"+ Costo;
        }
    }
}
