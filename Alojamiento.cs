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
    abstract internal class Alojamiento : IComparable<Alojamiento>
    {
        protected int id;
        private string nombre;
        private Direccion direccion;
        protected double costo;
        private int huesped;
        private List<int> camas = new List<int>();
        private EEstado estado;
        private List<string> caracteristicas = new List<string>();
        private List<string> imagenes = new List<string>();
        private List<Reserva> reservas = new List<Reserva>();
        private TimeSpan checkIn;
        private TimeSpan checkOut;

        #region Constructores
        public Alojamiento(int id, string nombre, Direccion direccion, int huesped, double costo)
        {
            this.nombre = nombre;
            this.id = id;
            this.direccion = direccion;
            this.costo = costo;
            this.huesped = huesped;
            this.checkIn = new TimeSpan(12, 00, 00);
            this.checkOut = new TimeSpan(10, 00, 00);
        }
        #endregion

        #region Propiedades

        public int ID
        {
            get { return id; }
        }

        abstract public string IDs { get; }

        public string Nombre
        {
            get { return nombre; }
        }

        public Direccion Direccion
        {
            get { return direccion; }
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
            set { checkIn = value; }
        }

        public TimeSpan CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
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

        public bool Modificar(string nombre, Direccion direccion, int huesped, double costo)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.huesped = huesped;
            this.costo = costo;
            return true;
        }


        public void AgregarCamas(int[] camas)
        {
            this.camas.AddRange(camas);
        }

        public void AgregarImagenes(string[] img)
        {
            imagenes.Clear();
            foreach (string item in img)
            {
                if (item != null) imagenes.Add(item);
            }
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
        #endregion

        public override string ToString()
        {
            return this.nombre;
        }

        public int CompareTo(Alojamiento? other)
        {
            if (other == null) return -1;
            return this.nombre.CompareTo(other.nombre);
        }


        #region AREA RESERVA
        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public bool ReservadoenFecha(DateTime checkIn,DateTime checkOut)
        {
            foreach (Reserva x in reservas)
            {
                if (FuncionComparacionFechas(x, checkIn, checkOut)) return true;
            }
            return false;
        }

        public void CrearReserva(int idReserva,List<Cliente> cliente, DateTime checkin, DateTime checkout, int huesped)
        {
            try
            {
                if (huesped > this.huesped) throw new MiException("Limite maximo de huesped: " + this.huesped);
                if (this.estado != EEstado.Activo) throw new MiException("El alojamiento esta " + this.estado);

                foreach (Reserva x in reservas)
                {
                    if (FuncionComparacionFechas(x, checkin, checkout)) throw new MiException("Alojamiento ocupado en ese fecha");
                }
                DateTime fechaReserva = DateTime.Now;
                Reserva nuevaReserva = new Reserva(idReserva, this, cliente, checkin, checkout, this.Precio, fechaReserva, huesped);
                reservas.Add(nuevaReserva);

            }
            catch (Exception ex)
            {
                throw new MiException(ex.Message);
            }
        }

        public void ModificarReserva(int reserva, DateTime Checkin, DateTime CheckOut, EEstadoReserva estado, int huesped)
        {
            Reserva? res = reservas.Find(x => x.Id == reserva);
            if (res == null) throw new MiException("No se encontro reserva");

            foreach (Reserva x in reservas)
            {
                if(res.Id!=x.Id)
                    if (FuncionComparacionFechas(x, Checkin, CheckOut)) throw new MiException("Fecha Ocupada en ese rango");
            }

            if (huesped > this.huesped) throw new MiException("Excede la capacidad permitida " + this.huesped);

            res.Estado = estado;
            res.Checkin = Checkin;
            res.CheckOut = CheckOut;
            res.Huesped = huesped;
        }

        private bool FuncionComparacionFechas(Reserva x, DateTime checkIn, DateTime checkOut)
        {
            return ((checkIn >= x.Checkin && checkOut <= x.CheckOut) || (checkOut >= x.Checkin && checkOut <= x.CheckOut) || (checkIn <= x.CheckOut && checkOut >= x.CheckOut));
        }

        #endregion
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
                    index = x.ID.CompareTo(y.ID);
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
