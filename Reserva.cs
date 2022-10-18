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
        static int ids = 0;
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


        public Reserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped)
        {
            ids++;
            this.id = ids;
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

        public List<Cliente> Cliente
        {
            get { return cliente; }
        }

        public DateTime Checkin
        {
            get { return checkin; }
        }

        public DateTime CheckOut
        {
            get { return checkout; }
        }

        public double CostoXdia
        {
            get => costoXdia; 
        }

        public DateTime FechaReserva
        {
            get { return fechaReserva; }
        }

        public int Huesped
        {
            get { return huesped; }
        }

        public EEstadoReserva Estado
        {
            get { return estado; }
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
            return this.alojamiento.CompareTo(other.alojamiento);
        }
    }
}
