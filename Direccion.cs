using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    public class Direccion
    {
        private string calle = "";
        private string ciudad = "";
        private string provincia = "";
        public string Calle { get { return calle; } set { calle = value; } }

        public string Ciudad { get { return ciudad; } set { ciudad = value; } }

        public string Provincia { get { return provincia; } set { provincia = value; } }

        public override string ToString()
        {
            return calle + ", " + ciudad + ", " + provincia;
        }
    }
}
