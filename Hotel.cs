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
        public Hotel(int id, string nombre, string direccion, int huesped, ref double costo, int estrellas, int nHab) : base(id, nombre, direccion, huesped, ref costo)
        {
            this.estrellas = estrellas;
            this.nHabitacion = nHab;
        }


        public override string IDs { get { return "H" + id; } }

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
                precio = precio *  0.8 + precio;
            }
            else if (Huesped >= 3)
            {
                precio = precio * 1.5 + precio;
            }
            if (estrellas >= 3)
            {
                precio = precio * 0.4 + precio;
            }
            return precio;
            //throw new Exception("Error al calcular precio");
        }

        public bool Modificar(string nombre, string direccion, int huesped, double costo, int estrellas, int nHab)
        {
            bool temp = base.Modificar(nombre, direccion, huesped, costo);
            if (!temp) return temp;
            this.estrellas = estrellas;
            this.nHabitacion = nHab;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + "-Nro Hab:"+ NHabitacion;
        }
    }
}
