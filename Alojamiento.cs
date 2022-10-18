using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    abstract internal class Alojamiento : ICloneable, IComparable<Alojamiento>
    {
        private static int ids = 0;
        private protected string id;
        private string nombre;
        private string direccion;
        protected double costo;
        private int huesped;
        private List<int> camas = new List<int>();
        private EEstado estado;
        private List<string> caracteristicas = new List<string>();
        private List<string> imagenes = new List<string>();
        private TimeSpan checkIn;
        private TimeSpan checkOut;

        #region Constructores
        public Alojamiento(string nombre, string direccion, int huesped, double costo)
        {
            ids++;
            this.nombre = nombre;
            this.id = ids.ToString();
            this.direccion = direccion;
            this.costo = costo;
            this.huesped = huesped;
            this.checkIn = new TimeSpan(12, 00, 00);
            this.checkOut = new TimeSpan(10, 00, 00);
        }
        #endregion

        #region Propiedades

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Huesped
        {
            get { return huesped; }
            set
            {
                huesped = value;
            }
        }

        public virtual double Precio{get;}

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        

        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public abstract ETipo Tipo { get; }

        public TimeSpan CheckIn
        {
            get { return checkIn; }
        }

        public TimeSpan CheckOut
        {
            get { return checkOut; }
        }

        public List<string> Imagenes
        {
            get { return imagenes; }
        }

        public List<string> Caracteristicas
        {
            get { return caracteristicas; }
        }

        #endregion

        #region Metodos propios
        public void AgregarCamas(int[] camas)
        {
            this.camas.AddRange(camas);
        }

        public void AgregarImagenes(string[] img)
        {
            imagenes.AddRange(img);
        }

        public void AgregarCaracteristicas(string[] strr)
        {
            caracteristicas.Clear();
            caracteristicas.AddRange(strr);
        }

        public void QuitarCamas(int[] camas)
        {
            for (int i = 0; i < camas.Length; i++)
            {
                this.camas.RemoveAt(camas[i]);
            }
        }

        public object Clone()
        {
            Alojamiento nuevo = (Alojamiento)this.MemberwiseClone();
            return nuevo;
        }
        #endregion

        public override string ToString()
        {
            return this.id+";"+this.nombre + ";" + this.huesped + ";" + this.direccion+";"+camas.Count.ToString()+";"+ estado;
        }

        public int CompareTo(Alojamiento? other)
        {
            if (other == null) return -1;
            return this.nombre.CompareTo(other.nombre);
        }
    }

    #region IComparer para ordenar
    class Alojamiento_Sort : IComparer<Alojamiento>
    {
        private EBuscar tipo = EBuscar.NOMBRE;

        public Alojamiento_Sort() { }
        public Alojamiento_Sort(EBuscar tipo)
        {
            this.tipo = tipo;
        }

        public int Compare(Alojamiento? x, Alojamiento? y)
        {
            if (x == null || y == null) return -1;
            int index;
            switch (tipo)
            {
                case EBuscar.NOMBRE:
                    index = x.Nombre.ToUpper().CompareTo(y.Nombre.ToUpper());
                    break;
                case EBuscar.PERSONAS:
                    index = x.Huesped.CompareTo(y.Huesped);
                    break;
                case EBuscar.ID:
                    index = x.ID.ToString().CompareTo(y.ID.ToString());
                    break;
                case EBuscar.DNI:
                    index = -1;
                    break;
                case EBuscar.APELLIDO:
                    index = -1;
                    break;
                default:
                    index = -1;
                    break;
            }
            return index;
        }
    }
    #endregion

}
