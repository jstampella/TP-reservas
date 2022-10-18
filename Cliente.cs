using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Cliente
    {
        string nombre;
        string apellido;
        float dni;
        string mail;
        string celular;
        string codigoA;
        public Cliente(string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.codigoA = codArea;
            this.mail = mail;
            this.dni = dni;

        }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public float Dni { get { return dni; } }
        public string Mail {get { return mail; } }

        public string Celular { get { return celular; } }
    }
}
