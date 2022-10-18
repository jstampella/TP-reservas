using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    internal interface ITrasladarInfo
    {
        void Alojamiento(Alojamiento alojamiento);
        void ModificarAlojamiento(Alojamiento alojamiento);
        List<Alojamiento> ListarAlojamiento(ETipo tipo=ETipo.TODOS, EBuscar buscar=EBuscar.ALL,string valor="");

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn,DateTime checkOut);

        List<DateTime> FechaOcupadas(Alojamiento alojamiento);


        List<Reserva> ListarReservas();

        void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped);

        bool CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular);

        List<Cliente> ListarClientes();
    }
}
