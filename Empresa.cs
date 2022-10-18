using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Empresa
    {
        private List<Alojamiento> alojamientos;
        private List<Reserva> reservas;
        private List<Cliente> clientes = new List<Cliente>();

        public Empresa()
        {
            
            alojamientos = new List<Alojamiento>();
            this.alojamientos.Add(new Casa("San carlos","Cordoba",2,8500,4));
            this.alojamientos.Add(new Casa("Espinillo", "Parana", 8, 12500, 7));
            this.alojamientos.Add(new Casa("San rafael", "Santa fe", 4, 8000, 4));
            this.alojamientos.Add(new Casa("Don pepe", "Cordoba", 6, 9500, 5));
            this.alojamientos.Add(new Hotel("Maran", "Cordoba", 6, 9500,3,555));
            this.alojamientos.Add(new Hotel("Maran", "Parana", 6, 9500, 2, 450));

            this.reservas = new List<Reserva>();
            this.reservas.Add(new Reserva(alojamientos[0], clientes, DateTime.Now, DateTime.Now, 2500, DateTime.Now, 2));
        }


        public void AgregarAlojamiento(Alojamiento alojamiento)
        {
            this.alojamientos.Add(alojamiento);
        }

        public Alojamiento BuscarAlojamiento(EBuscar buscar, string valor)
        {
            int id = -1;
            Alojamiento alojamiento = new Casa("", "", 0, 0, 0);
            switch (buscar)
            {
                case EBuscar.DNI:
                    break;
                case EBuscar.APELLIDO:
                    break;
                case EBuscar.NOMBRE:
                    alojamiento.Nombre = valor;
                    break;
                case EBuscar.PERSONAS:
                    alojamiento.Huesped = Convert.ToInt32(valor);
                    break;
                case EBuscar.ID:
                    alojamiento.ID = valor;
                    break;
                default:
                    break;
            }
            //Alojamiento alo = (Alojamiento)alojamientos[id].Clone();
            id = alojamientos.BinarySearch(alojamiento, new Alojamiento_Sort(buscar));
            return alojamientos[id];
        } 

        public void ModificarAlojamiento(Alojamiento alojamiento)
        {
            int indice = alojamientos.BinarySearch(alojamiento, new Alojamiento_Sort(EBuscar.ID));
            //this.alojamientos[indice] = alojamiento;
        }

        public List<Alojamiento> ListarAlojamientos(ETipo tipo= ETipo.TODOS, EBuscar parametro =EBuscar.ALL, string valor="")
        {
            List<Alojamiento> listaFiltrada = new List<Alojamiento>();
            switch (parametro)
            {
                case EBuscar.DNI:
                    break;
                case EBuscar.APELLIDO:
                    break;
                case EBuscar.NOMBRE:
                    listaFiltrada = alojamientos.FindAll(emp => emp.Nombre.ToUpper().Contains(valor.ToUpper())).ToList();
                    break;
                case EBuscar.PERSONAS:
                    listaFiltrada = alojamientos.FindAll(emp => emp.Huesped == Convert.ToInt32(valor)).ToList();
                    break;
                case EBuscar.ID:
                    listaFiltrada = alojamientos.FindAll(emp => emp.ID == valor).ToList();
                    break;
                case EBuscar.ALL:
                    listaFiltrada = alojamientos.ToList();
                    break;
                default:
                    listaFiltrada = alojamientos.ToList();
                    break;
            }
            switch (tipo)
            {
                case ETipo.CASA:
                case ETipo.HOTEL:
                    listaFiltrada = listaFiltrada.FindAll(emp => emp.Tipo == tipo).ToList();
                    break;
                case ETipo.TODOS:
                    break;
                default:
                    break;
            }
            return listaFiltrada;
        }

        public List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut)
        {
            List<Reserva> reservasFecha = reservas.FindAll(x=>x.Checkin == checkIn && x.CheckOut==checkOut);


            List<Alojamiento> alojamientosDisp = new List<Alojamiento>();
            foreach (Alojamiento item in alojamientos)
            {
                Reserva? re = reservas.Find(x => x.Alojamiento.ID == item.ID);
                if(re == null)
                {
                    alojamientosDisp.Add(item);
                }
            }
            return alojamientosDisp;
        }

        public List<DateTime> FechaOcupadas(Alojamiento alojamiento)
        {
            List<Reserva> res =  reservas.FindAll(x => x.Alojamiento == alojamiento);
            List<DateTime> lista = new List<DateTime>();
            foreach (Reserva item in res)
            {
                lista.Add(item.Checkin);
                DateTime nn = item.Checkin.AddDays(1);
                while (nn <= item.CheckOut)
                {
                    lista.Add(nn);
                    nn = nn.AddDays(1);
                }
            }
            return lista;
        }

        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped)
        {
            Reserva nuevaReserva = new Reserva(alojamiento, cliente, checkin, checkout, costoXdia, fechaReserva, huesped);
            reservas.Add(nuevaReserva);
        }


        public bool CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            try
            {
                Cliente cliente = new Cliente(nombre, apellido, dni, mail, codArea, celular);
                if (clientes == null) clientes = new List<Cliente>();
                clientes.Add(cliente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }
    }
}
