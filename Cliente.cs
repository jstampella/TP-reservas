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
        string celular;
        string codigoA;
        public Cliente (string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.codigoA= codArea;
            this.mail = mail;
            this.dni = dni;

        }
    }
}
