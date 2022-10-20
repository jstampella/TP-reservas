using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Reserva:IComparable<Reserva>
    {
        private int id;
        private Alojamiento alojamiento;
        private List<Cliente> cliente = new List<Cliente>();
        private DateTime checkin;
        private DateTime checkout;
        private double costoXdia;
        private DateTime fechaReserva;
        private int huesped;
        private EEstadoReserva estado;
        private string nota = "";


        public Reserva(int id,Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped)
        {
            this.id = id;
            this.alojamiento = alojamiento;
            this.cliente.AddRange(cliente);
            this.checkin = checkin;
            this.checkout = checkout;
            this.costoXdia = costoXdia;
            this.fechaReserva = fechaReserva;
            this.huesped = huesped;
            this.estado = EEstadoReserva.Activa;
        }

        public int Id { get => id; }
        public Alojamiento Alojamiento { get => alojamiento; }

        public Cliente Cliente
        {
            get { return cliente[0]; }
        }

        public List<Cliente> Clientes
        {
            get { return cliente; }
        }

        public DateTime Checkin
        {
            get { return checkin; }
            set
            {
                checkin = value;
            }
        }

        public DateTime CheckOut
        {
            get { return checkout; }
            set { checkout = value; }
        }

        public double CostoXdia
        {
            get => costoXdia; 
        }

        public double PrecioFinal
        {
            get
            {

                TimeSpan difFechas = checkout - checkin;
                return costoXdia * difFechas.Days;
            }
        }

        public int Dias
        {
            get
            {

                TimeSpan difFechas = checkout - checkin;
                return difFechas.Days;
            }
        }

        public DateTime FechaReserva
        {
            get { return fechaReserva; }
        }

        public int Huesped
        {
            get { return huesped; }
            set
            {
                huesped = value;
            }
        }

        public EEstadoReserva Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Nota
        {
            get { return nota; }
        }


        public void CancelarReserva(string nota)
        {
            //validar si tiene algun recargo cancelar 
            estado = EEstadoReserva.Cancelada;
            this.nota = nota;
        }

        public int CompareTo(Reserva? other)
        {
            if (other == null) return -1;
            return this.id.CompareTo(other.id);
        }
    }
}
