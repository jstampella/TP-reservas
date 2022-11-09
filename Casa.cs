using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Casa:Alojamiento
    {
        private int mindias;
        public Casa(int id, string nombre,Direccion direccion, int huesped, double costo,int minD) : base(id,nombre, direccion, huesped, costo)
        {
            this.mindias = minD;
        }

        public override string IDs { get { return "C" + base.id; } }

        public int Mindias
        {
            get { return mindias; }
            set { mindias = value; }
        }

        public override double Precio
        {
            get { return base.costo; }
        }

        public override ETipo Tipo
        {
            get { return ETipo.CASA; }
        }

        public bool Modificar(string nombre, Direccion direccion, int huesped, double costo, int minD)
        {
            bool temp = base.Modificar(nombre, direccion, huesped, costo);
            if (!temp) return temp;
            this.mindias = minD;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + mindias;
        }
    }
}
