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

        private int ObtenerUltimoID()
        {
            if (alojamientos.Count > 0)
            {
                alojamientos.Sort(new Alojamiento_Sort(EBuscar.ID));
                return alojamientos.Last().ID;
            }
            else return 0; 

        }


        public string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int minD)
        {
            try
            {
                int id = ObtenerUltimoID();
                id++;
                Alojamiento nuevoAlojamiento = new Casa(id,nombre, direccion, huesped, costo, minD);
                alojamientos.Add(nuevoAlojamiento);
                return nuevoAlojamiento.IDs;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al crear alojamiento " + e.Message);
            }
        }

        public bool ModificarAlojamiento(string ID,string nombre, string direccion, int huesped, double costo, int minD)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    if(alojamiento is Casa cc)
                    {
                        resultado =  cc.Modificar(nombre, direccion, huesped, costo, minD);
                    }
                }
                else
                {
                    throw new MiException("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public void ModificarAlojamiento(string ID,TimeSpan checkin,TimeSpan checkout) {
            try
            {
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    alojamiento.CheckIn = checkin;
                    alojamiento.CheckOut = checkout;
                }
                else
                {
                    throw new MiException("Error al buscar alojamiento");
                }
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool ModificarAlojamiento(string ID, string nombre, string direccion, int huesped, double costo, int estrellas, int nHab)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    if (alojamiento is Hotel cc)
                    {
                        resultado = cc.Modificar(nombre, direccion,huesped,costo,estrellas,nHab);
                    }
                }
                else
                {
                    throw new MiException("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool ModificarEstadoAlojamiento(string ID,EEstado estado)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    alojamiento.Estado = estado;
                }
                else
                {
                    throw new MiException("Error al buscar alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al actualizar " + e.Message);
            }
        }

        public bool AgregarCaracteristicas(string ID, string[] caracteristicas)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    alojamiento.AgregarCaracteristicas(caracteristicas);
                }
                else
                {
                    throw new MiException("Error al agregar caract. alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al agregar " + e.Message);
            }
        }

        public bool AgregarImagenes(string ID, string[] imagenes)
        {
            try
            {
                bool resultado = false;
                Alojamiento? alojamiento = alojamientos.Find(x => x.IDs == ID);
                if (alojamiento != null)
                {
                    alojamiento.AgregarImagenes(imagenes);
                }
                else
                {
                    throw new MiException("Error al agregar imagenes. alojamiento");
                }
                return resultado;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al agregar " + e.Message);
            }
        }

        public string CrearAlojamiento(string nombre, string direccion, int huesped, double costo, int estrellas, int nHab)
        {
            try
            {
                int ids = ObtenerUltimoID();
                ids++;
                Alojamiento nuevoAlojamiento = new Hotel(ids,nombre, direccion, huesped, costo, estrellas,nHab);
                alojamientos.Add(nuevoAlojamiento);
                return nuevoAlojamiento.IDs;
            }
            catch (Exception e)
            {

                throw new MiException("Ocurrio un error al crear alojamiento " + e.Message);
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
                    listaFiltrada = alojamientos.FindAll(emp => emp.IDs == valor).ToList();
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

        private bool FuncionComparacionFechas(Reserva x, DateTime checkIn, DateTime checkOut)
        {
            return ((checkIn >= x.Checkin && checkOut <= x.CheckOut) ||(checkOut>=x.Checkin && checkOut<=x.CheckOut) ||(checkIn<=x.CheckOut && checkOut>=x.CheckOut));
            //return ((checkIn >= x.Checkin &&  checkOut<= x.CheckOut) || ( checkIn>= x.Checkin && checkOut>= x.CheckOut) || ( checkIn<= x.Checkin &&  checkOut>= x.CheckOut) || (checkIn <= x.Checkin && checkOut <= x.CheckOut)) ;
        }

        public List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut)
        {
            List<string> alojaminentoOcup = new List<string>();
            foreach (Reserva x in reservas)
            {
                if (FuncionComparacionFechas(x,checkIn,checkOut))
                    alojaminentoOcup.Add(x.Alojamiento.IDs);
            }

            List<Alojamiento> alojamientosDisp = alojamientos.FindAll(x => !alojaminentoOcup.Contains(x.IDs));
            
            return alojamientosDisp;
        }

        public List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut,int huesped)
        {
            List<Alojamiento> alojamientosDisp = AlojamientosDisponibles(checkIn, checkOut);
            alojamientosDisp = alojamientosDisp.FindAll(x=> x.Huesped>=huesped);

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
            lista.Sort();
            return lista;
        }

        private Reserva? FechaOcupadas(Alojamiento alojamiento,DateTime checkIn,DateTime checkOut)
        {
            foreach (Reserva x in reservas)
            {
                if (FuncionComparacionFechas(x, checkIn, checkOut))
                    if (x.Alojamiento== alojamiento)return x;
            }
            return null;
        }
        #endregion


        #region AREA RESERVA
        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public int ObtenerUltimoIDReserva()
        {
            if (reservas.Count > 0)
            {
                reservas.Sort();
                return reservas.Last().Id;
            }
            else return 0;

        }

        public void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, double costoXdia, DateTime fechaReserva, int huesped)
        {
            try
            {
                if (huesped > alojamiento.Huesped) throw new MiException("Limite maximo de huesped: " + alojamiento.Huesped);
                if (alojamiento.Estado != EEstado.Activo) throw new MiException("El alojamiento esta " + alojamiento.Estado);

                foreach (Reserva x in reservas)
                {
                    if (FuncionComparacionFechas(x, checkin, checkout))
                        if (x.Alojamiento.ID == alojamiento.ID) throw new MiException("Alojamiento ocupado en ese fecha");
                }
                int id = ObtenerUltimoIDReserva();
                id++;
                Reserva nuevaReserva = new Reserva(id,alojamiento, cliente, checkin, checkout, costoXdia, fechaReserva, huesped);
                reservas.Add(nuevaReserva);

            }
            catch (Exception ex)
            {
                throw new MiException("Ocurrio un error al cargar reserva", ex);
            }
        }

        public void ModificarReserva(int reserva, DateTime Checkin, DateTime CheckOut, EEstadoReserva estado, int huesped)
        {
            Reserva? res = reservas.Find(x => x.Id == reserva);
            if (res == null) throw new MiException("Error al actualizar reserva");

            Reserva? rrOcupada = FechaOcupadas(res.Alojamiento, Checkin, CheckOut);
            if (rrOcupada != null && rrOcupada.Id != res.Id) throw new MiException("Fecha Ocupada en ese rango");
            if (huesped > res.Alojamiento.Huesped) throw new MiException("Excede la capacidad permitida "+res.Alojamiento.Huesped);

            res.Estado = estado;
            res.Checkin = Checkin;
            res.CheckOut = CheckOut;
            res.Huesped = huesped;
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
