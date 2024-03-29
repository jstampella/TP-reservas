﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    internal interface ITrasladarInfo
    {
        void exportarCalendario(string id, string namefile);
        string CrearAlojamiento(string nombre, Direccion direccion, int huesped, double costo, int minD);
        string CrearAlojamiento(string nombre, Direccion direccion, int huesped, double costo, int estrellas, int nHab);

        bool ModificarAlojamiento(string ID, string nombre, Direccion direccion, int huesped, double costo, int estrellas, int nHab);

        bool ModificarAlojamiento(string ID, string nombre, Direccion direccion, int huesped, double costo, int minD);

        bool ModificarEstadoAlojamiento(string ID, EEstado estado);

        bool AgregarCaracteristicas(string ID, string[] caracteristicas);

        bool AgregarImagenes(string ID, string[] imagenes);

        void ModificarAlojamiento(string ID, TimeSpan checkin, TimeSpan checkout);

        void CargarPenalidad(int dias, double porcentaje);

        public int DiasPenalidad { get; }
        public double PorcentajePenalidad { get; }

        //void Alojamiento(Alojamiento alojamiento);
        //void ModificarAlojamiento(Alojamiento alojamiento);
        List<Alojamiento> ListarAlojamiento(ETipo tipo=ETipo.TODOS, EBuscar buscar=EBuscar.ALL,string valor="");

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn,DateTime checkOut,ETipo tipo);

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut, ETipo tipo, int huesped);

        List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut, ETipo tipo, int huesped, EBuscar buscar, string valor);


        List<DateTime> FechaOcupadas(Alojamiento alojamiento);


        List<Reserva> ListarReservas();

        void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, int huesped);

        void ModificarReserva(int alojamiento,int reserva, DateTime Checkin, DateTime CheckOut,EEstadoReserva estado,int huesped);

        bool CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular);

        bool ModificarCliente(string nombre, string apellido,float dni, string mail, string codArea, string celular);

        IEnumerable<Cliente> ListarClientes();

        void ActualizarPrecioHoteles(double precio);

        void ActualizarPrecioCasas(double porcentaje);

        Double PrecioHotel { get; }

        PageSetupDialog PagesSetup();
    }
}
