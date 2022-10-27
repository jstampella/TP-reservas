using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    internal interface ITrasladarInfo
    {
        string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int minD);
        string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int estrellas, int nHab);

        bool ModificarAlojamiento(string ID, string nombre, string direccion, int huesped, double costo, int estrellas, int nHab);

        bool ModificarAlojamiento(string ID, string nombre, string direccion, int huesped, double costo, int minD);

        bool ModificarEstadoAlojamiento(string ID, EEstado estado);

        bool AgregarCaracteristicas(string ID, string[] caracteristicas);

        bool AgregarImagenes(string ID, string[] imagenes);

        void ModificarAlojamiento(string ID, TimeSpan checkin, TimeSpan checkout);

        //void Alojamiento(Alojamiento alojamiento);
        //void ModificarAlojamiento(Alojamiento alojamiento);
        List<Alojamiento> ListarAlojamiento(ETipo tipo=ETipo.TODOS, EBuscar buscar=EBuscar.ALL,string valor="");

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn,DateTime checkOut);

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut,int huesped);


        List<DateTime> FechaOcupadas(Alojamiento alojamiento);


        List<Reserva> ListarReservas();

        void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, DateTime fechaReserva, int huesped);

        void ModificarReserva(int alojamiento,int reserva, DateTime Checkin, DateTime CheckOut,EEstadoReserva estado,int huesped);

        bool CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular);

        bool ModificarCliente(string nombre, string apellido,float dni, string mail, string codArea, string celular);

        IEnumerable<Cliente> ListarClientes();
    }
}
