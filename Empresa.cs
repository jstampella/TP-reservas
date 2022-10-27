using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPreservas
{
    [Serializable]
    internal class Empresa
    {
        private List<Alojamiento> alojamientos = new List<Alojamiento>();
        private int cantidadReservas = 1;
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
            List<Alojamiento> alojaminentoDispo = new List<Alojamiento>();
            foreach (Alojamiento item in alojamientos)
            {
                if (item.Estado != EEstado.Activo) continue;
                if (!item.ReservadoenFecha(checkIn, checkOut)) alojaminentoDispo.Add(item);
            }
            return alojaminentoDispo;
        }

        public List<Alojamiento> AlojamientosDisponibles(DateTime checkIn, DateTime checkOut, int huesped)
        {
            List<Alojamiento> alojamientosDisp = AlojamientosDisponibles(checkIn, checkOut);
            alojamientosDisp = alojamientosDisp.FindAll(x => x.Huesped >= huesped);

            return alojamientosDisp;
        }

        public List<DateTime> FechaOcupadas(Alojamiento alojamiento)
        {

            List<Reserva> res = alojamiento.ListarReservas();
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

        public string ImportarAlojamiento(ETipo tipo,string path)
        {
            string errores = "";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader rm = new StreamReader(fs);
            int ln = 0;
            while (!rm.EndOfStream)
            {
                string? ll = rm.ReadLine();
                if (ln != 0)
                {
                    if (ll != null)
                    {
                        string[] linea = ll.Split(';');
                        try
                        {
                            int huesped = Convert.ToInt32(linea[2]);
                            double costo = Convert.ToDouble(linea[3]);
                            int minDias = Convert.ToInt32(linea[4]);
                            CrearAlojamiento(linea[0], linea[1], huesped, costo, minDias);
                        }
                        catch (Exception)
                        {
                            errores += ln + ",";
                        }
                    }
                }
                ln++;
            }
            rm.Close();
            fs.Close();
            return errores;
        }
        #endregion


        #region AREA RESERVA
        public List<Reserva> ListarReservas()
        {
            List<Reserva> lista = new List<Reserva>();
            foreach (Alojamiento item in alojamientos)
            {
                lista.AddRange(item.ListarReservas());
            }
            return lista;
        }

        public void CrearReserva(Alojamiento alojamiento, List<Cliente> cliente, DateTime checkin, DateTime checkout, DateTime fechaReserva, int huesped)
        {
            try
            {
                alojamiento.CrearReserva(cantidadReservas,cliente, checkin, checkout, huesped);
                cantidadReservas++;
            }
            catch (Exception ex)
            {
                throw new MiException("Ocurrio un error al cargar reserva", ex);
            }
        }

        public void ModificarReserva(int idAloj,int reserva, DateTime Checkin, DateTime CheckOut, EEstadoReserva estado, int huesped)
        {
            try
            {
                Alojamiento? alojamiento = alojamientos.Find(x => x.ID == idAloj);
                if (alojamiento == null) throw new MiException("No se encontro alojamiento");
                alojamiento.ModificarReserva(reserva, Checkin, CheckOut, estado, huesped);
            }
            catch (MiException ex)
            {
                throw new MiException("Ocurrio un error al actualizar la reserva", ex);
            }
        }
        #endregion


        #region AREA CLIENTE

        public bool CrearCliente(string nombre, string apellido, float dni, string mail, string codArea, string celular)
        {
            try
            {
                if (nombre == "" || apellido == "") throw new MiException("Error en los paramentros");
                Cliente? Exiscli = clientes.Find(x => x.Dni == dni);
                if (Exiscli != null) throw new MiException("El dni ya se encuentra registrado.");
                Cliente cliente = new Cliente(nombre, apellido, dni, mail, codArea, celular);
                if (clientes == null) clientes = new List<Cliente>();
                clientes.Add(cliente);
                return true;
            }
            catch (Exception ee)
            {
                throw new MiException(ee.Message);
            }
            
        }

        public bool ModificarCliente(string nombre, string apellido,float dni, string mail, string codArea, string celular)
        {
            try
            {
                if (nombre == "" || apellido == "") throw new MiException("Error en los paramentros");
                Cliente? nn = clientes.Find(x => x.Dni == dni);
                Cliente? Exiscli = clientes.Find(x => x.Dni == dni);
                if (Exiscli != null && Exiscli!=nn) throw new MiException("El dni ya se encuentra registrado.");
                if (nn == null) return false;
                else
                {
                    nn.ModificarCliente(nombre, apellido, mail, codArea, celular);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new MiException("Ocurrio un error" + ex.Message);
            }
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return clientes;
        }
        #endregion
    }
}
