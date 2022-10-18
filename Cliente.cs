using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    internal class Cliente
    {
        String Nombre;
        string apellido;
        float dni;
        string mail;
        string telefono;
        public Cliente (string nombre, string apellido, float dni, string mail, string telefono)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.dni = dni;

        }
    }
}
