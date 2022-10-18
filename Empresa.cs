using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    [Serializable]
    internal class Empresa
    {
        private List<Alojamiento> alojamientos = new List<Alojamiento>();
        private List<Reserva> reservas = new List<Reserva>();
        private List<Cliente> clientes = new List<Cliente>();

        public Empresa(){}


        #region AREA ALOJAMIENTO

        public string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int minD)
        {
            try
            {
                Alojamiento nuevoAlojamiento = new Casa(nombre, direccion, huesped, costo, minD);
                alojamientos.Add(nuevoAlojamiento);
                return nuevoAlojamiento.ID;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al crear alojamiento " + e.Message);
            }
        }

        public bool ModificarAlojamiento(string ID,string nombre, string direccion, int huesped, double costo, int minD)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == ID);
                if (alojamiento != null)
                {
                    if(alojamiento is Casa cc)
                    {
                        resultado =  cc.Modificar(nombre, direccion, huesped, costo, minD);
                    }
                }
                else
                {
                    throw new Exception("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool ModificarAlojamiento(string ID, string nombre, string direccion, int huesped, double costo, int estrellas, int nHab)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == ID);
                if (alojamiento != null)
                {
                    if (alojamiento is Hotel cc)
                    {
                        resultado = cc.Modificar(nombre, direccion,huesped,costo,estrellas,nHab);
                    }
                }
                else
                {
                    throw new Exception("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool ModificarEstadoAlojamiento(string ID,EEstado estado)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == ID);
                if (alojamiento != null)
                {
                    alojamiento.Estado = estado;
                }
                else
                {
                    throw new Exception("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool AgregarCaracteristicas(string ID, string[] caracteristicas)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == ID);
                if (alojamiento != null)
                {
                    alojamiento.AgregarCaracteristicas(caracteristicas);
                }
                else
                {
                    throw new Exception("Error al agregar caract. alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al agregar " + e.Message);
            }
        }

        public bool AgregarImagenes(string ID, string[] imagenes)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == ID);
                if (alojamiento != null)
                {
                    alojamiento.AgregarImagenes(imagenes);
                }
                else
                {
                    throw new Exception("Error al agregar imagenes. alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al agregar " + e.Message);
            }
        }

        public string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int estrellas, int nHab)
        {
            try
            {
                Alojamiento nuevoAlojamiento = new Hotel(nombre, direccion, huesped, costo, estrellas,nHab);
                alojamientos.Add(nuevoAlojamiento);
                return nuevoAlojamiento.ID;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error al crear alojamiento " + e.Message);
            }
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
        #endregion


        #region AREA RESERVA
        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped)
        {
            Reserva nuevaReserva = new Reserva(alojamiento, cliente, checkin, checkout, costoXdia, fechaReserva, huesped);
            reservas.Add(nuevaReserva);
        }
        #endregion


        #region AREA CLIENTE

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

        public bool ModificarCliente(string nombre, string apellido,float dni, string mail, string codArea, string celular)
        {
            try
            {
                Cliente? nn = clientes.Find(x => x.Dni == dni);
                if(nn == null) return false;
                else
                {
                    nn.ModificarCliente(nombre, apellido, mail, codArea, celular);
                    return true;
                }
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
        #endregion
    }
}
